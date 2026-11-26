using System;
using System.Data;
using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Admin
{
    public partial class AdminHomeContentControl : UserControl
    {
        public AdminHomeContentControl()
        {
            InitializeComponent();
            dgvRecentActivities.AutoGenerateColumns = false;
            dgvRecentActivities.CurrentCellDirtyStateChanged += dgvRecentActivities_CurrentCellDirtyStateChanged;
            dgvRecentActivities.CellValueChanged += dgvRecentActivities_CellValueChanged;
            LoadRecentActivities();
            LoadDashboardStatistics();
        }
        private void LoadRecentActivities()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT ReferenceID, RequestType, DateSubmitted, Status FROM dbo.AllResidentRequests ORDER BY DateSubmitted DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRecentActivities.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load recent activities: " + ex.Message, "Admin Dashboard");
            }
        }
        private void dgvRecentActivities_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvRecentActivities.IsCurrentCellDirty)
            {
                dgvRecentActivities.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvRecentActivities_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                dgvRecentActivities.Columns[e.ColumnIndex].Name != "cmbAction")
                return;

            string referenceID = dgvRecentActivities.Rows[e.RowIndex].Cells["ReferenceID"].Value?.ToString();
            string selectedAction = dgvRecentActivities.Rows[e.RowIndex].Cells["cmbAction"].Value?.ToString();

            if (string.IsNullOrEmpty(referenceID) ||
                (selectedAction != "Approve" && selectedAction != "Reject"))
                return;

            string tableName;

            if (referenceID.StartsWith("CRT-"))
                tableName = "dbo.CertificateRequests";
            else if (referenceID.StartsWith("CMP-"))
                tableName = "dbo.Complaints";
            else if (referenceID.StartsWith("RSV-"))
                tableName = "dbo.EquipmentReservations";
            else
            {
                MessageBox.Show("Unknown request type.");
                return;
            }
            string newStatus = selectedAction == "Approve" ? "Approved" : "Rejected";

            DialogResult confirmation = MessageBox.Show("Are you sure you want to " + selectedAction.ToLower() + " request " + referenceID + "?","Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                LoadRecentActivities();
                return;
            }
            try
            {
                UpdateRequestStatus(referenceID, tableName, newStatus);
                MessageBox.Show("Request " + referenceID + " has been " + newStatus.ToLower() + " successfully.","Request Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadRecentActivities();
                LoadDashboardStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update request: " + ex.Message, "Admin Request Management");
                LoadRecentActivities();
            }
        }
        private void UpdateRequestStatus(string referenceID, string tableName, string newStatus)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        if (referenceID.StartsWith("RSV-"))
                        {
                            string reservationQuery = @"SELECT EquipmentID, Quantity, Status FROM dbo.EquipmentReservations WITH (UPDLOCK, HOLDLOCK)WHERE ReferenceID = @ReferenceID";

                            int equipmentID;
                            int requestedQuantity;
                            string currentStatus;

                            using (SqlCommand command = new SqlCommand(reservationQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ReferenceID", referenceID);

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (!reader.Read())
                                        throw new Exception("Reservation not found.");

                                    equipmentID = Convert.ToInt32(reader["EquipmentID"]);
                                    requestedQuantity = Convert.ToInt32(reader["Quantity"]);
                                    currentStatus = reader["Status"].ToString();
                                }
                            }

                            if (currentStatus != "Pending")
                                throw new Exception("This reservation has already been processed. Current status: " + currentStatus);

                            if (newStatus == "Approved")
                            {
                                string quantityQuery = @"UPDATE dbo.Equipment SET AvailableQuantity = AvailableQuantity - @Quantity WHERE EquipmentID = @EquipmentID AND AvailableQuantity >= @Quantity";
                                using (SqlCommand command = new SqlCommand(quantityQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@EquipmentID", equipmentID);
                                    command.Parameters.AddWithValue("@Quantity", requestedQuantity);

                                    if (command.ExecuteNonQuery() == 0)
                                        throw new Exception("Not enough available equipment to approve this reservation.");
                                }
                            }
                        }

                        string updateQuery = "UPDATE " + tableName +" SET Status = @Status WHERE ReferenceID = @ReferenceID AND Status = 'Pending'";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Status", newStatus);
                            command.Parameters.AddWithValue("@ReferenceID", referenceID);

                            if (command.ExecuteNonQuery() == 0)
                                throw new Exception("The request could not be updated. It may have already been processed.");
                        }

                        string dashboardQuery = @"UPDATE dbo.AllResidentRequests SET Status = @Status WHERE ReferenceID = @ReferenceID";

                        using (SqlCommand command = new SqlCommand(dashboardQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Status", newStatus);
                            command.Parameters.AddWithValue("@ReferenceID", referenceID);
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        private void dgvRecentActivities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvRecentActivities.Columns[e.ColumnIndex].Name != "btnView")
                return;

            string referenceID = dgvRecentActivities.Rows[e.RowIndex].Cells["ReferenceID"].Value?.ToString();

            if (string.IsNullOrEmpty(referenceID))
                return;

            string query;

            if (referenceID.StartsWith("CRT-"))
            {
                query = @"SELECT C.ReferenceID, R.FullName, C.CertificateType, C.Purpose, C.DateRequested, C.AdditionalRemarks
                  FROM dbo.CertificateRequests C
                  INNER JOIN dbo.Residents R ON C.ResidentID = R.ResidentID
                  WHERE C.ReferenceID = @ReferenceID";
            }
            else if (referenceID.StartsWith("CMP-"))
            {
                query = @"SELECT C.ReferenceID, R.FullName, C.Category, C.IncidentLocation, C.Description, C.IncidentDate, C.DateSubmitted
                  FROM dbo.Complaints C
                  INNER JOIN dbo.Residents R ON C.ResidentID = R.ResidentID
                  WHERE C.ReferenceID = @ReferenceID";
            }

            else if (referenceID.StartsWith("RSV-"))
            {
                query = @"SELECT ER.ReferenceID, R.FullName, E.EquipmentName,
              ER.Quantity, ER.EventName, ER.EventDate,
              ER.ReturnDate, ER.Purpose, ER.DateRequested
      FROM dbo.EquipmentReservations ER
      INNER JOIN dbo.Residents R ON ER.ResidentID = R.ResidentID
      INNER JOIN dbo.Equipment E ON ER.EquipmentID = E.EquipmentID
      WHERE ER.ReferenceID = @ReferenceID";
            }

            else
            {
                MessageBox.Show("Unknown request type.");
                return;
            }
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReferenceID", referenceID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string details = "";

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string value = reader.IsDBNull(i) ? "N/A" : reader[i].ToString();

                                    if (reader.GetName(i).Contains("Date"))
                                        value = reader.IsDBNull(i) ? "N/A" : Convert.ToDateTime(reader[i]).ToString("dd/MM/yyyy hh:mm tt");

                                    details += reader.GetName(i) + ": " + value + Environment.NewLine;
                                }

                                MessageBox.Show(details, "Request Details - " + referenceID, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Request details not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load request details: " + ex.Message, "Request Details");
            }
        }
        private void LoadDashboardStatistics()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT
                    (SELECT COUNT(*) FROM dbo.Residents) AS TotalResidents,
                    (SELECT COUNT(*) FROM dbo.AllResidentRequests) AS TotalRequests,
                    (SELECT COUNT(*) FROM dbo.AllResidentRequests WHERE Status = 'Approved') AS ApprovedCount,
                    (SELECT COUNT(*) FROM dbo.AllResidentRequests WHERE Status = 'Pending') AS PendingCount,
                    (SELECT COUNT(*) FROM dbo.CertificateRequests) AS TotalCertificates,
                    (SELECT COUNT(*) FROM dbo.EquipmentReservations) AS TotalReservations,
                    (SELECT COUNT(*) FROM dbo.Complaints) AS TotalComplaints";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTotalResidents.Text = reader["TotalResidents"].ToString();
                            lblTotalCount.Text = reader["TotalRequests"].ToString();
                            lblApprovedCount.Text = reader["ApprovedCount"].ToString();
                            lblPendingCount.Text = reader["PendingCount"].ToString();
                            lblTotalCert.Text = reader["TotalCertificates"].ToString();
                            lblTotalReserve.Text = reader["TotalReservations"].ToString();
                            lblTotalComplaint.Text = reader["TotalComplaints"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load dashboard statistics: " + ex.Message, "Admin Dashboard");
            }
        }
    }
}