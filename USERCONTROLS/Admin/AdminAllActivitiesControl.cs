
using System;
using System.Data;
using System.Windows.Forms;
using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;

namespace Barangay_E_Service_System.USERCONTROLS.Admin
{
    public partial class AdminAllActivitiesControl : UserControl
    {
        public AdminAllActivitiesControl()
        {
            InitializeComponent();

            dgvAllActivities.AutoGenerateColumns = false;
            lblNoActivitiesFound.Visible = false;

            dgvAllActivities.CurrentCellDirtyStateChanged += dgvAllActivities_CurrentCellDirtyStateChanged;
            dgvAllActivities.CellValueChanged += dgvAllActivities_CellValueChanged;
            dgvAllActivities.CellContentClick += dgvAllActivities_CellContentClick;

            txtSearchActivities.TextChanged += txtSearchActivities_TextChanged;

            dgvAllActivities.CellPainting += dgvAllActivities_CellPainting;

            LoadAllActivities();
        }

        // LOAD ALL ACTIVITIES
        private void LoadAllActivities(string searchTerm = "")
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT ReferenceID, RequestType, DateSubmitted, Status
                        FROM dbo.AllResidentRequests
                        WHERE ReferenceID LIKE @Search
                           OR RequestType LIKE @Search
                           OR Status LIKE @Search
                        ORDER BY DateSubmitted DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvAllActivities.DataSource = dt;

                            foreach (DataGridViewRow row in dgvAllActivities.Rows)
                            {
                                string referenceID = row.Cells["ReferenceID"].Value?.ToString();
                                string status = row.Cells["Status"].Value?.ToString();

                                if (referenceID != null && referenceID.StartsWith("RSV-") && status == "Approved")
                                {
                                    row.Cells["btnReturn"].Value = "Return";
                                }
                                else
                                {
                                    row.Cells["btnReturn"].Value = "";
                                }
                            }

                            lblNoActivitiesFound.Visible = dt.Rows.Count == 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load activities: " + ex.Message, "All Activities");
            }
        }

        // SEARCH ACTIVITIES
        private void txtSearchActivities_TextChanged(object sender, EventArgs e)
        {
            LoadAllActivities(txtSearchActivities.Text.Trim());
        }

        // COMMIT COMBOBOX CHANGES
        private void dgvAllActivities_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAllActivities.IsCurrentCellDirty)
            {
                dgvAllActivities.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // APPROVE OR REJECT REQUEST

        private void dgvAllActivities_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                dgvAllActivities.Columns[e.ColumnIndex].Name != "cmbAction")
                return;

            string referenceID = dgvAllActivities.Rows[e.RowIndex].Cells["ReferenceID"].Value?.ToString();
            string selectedAction = dgvAllActivities.Rows[e.RowIndex].Cells["cmbAction"].Value?.ToString();

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

            DialogResult confirmation = MessageBox.Show(
                "Are you sure you want to " + selectedAction.ToLower() + " request " + referenceID + "?",
                "Confirm Action",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                LoadAllActivities(txtSearchActivities.Text.Trim());
                return;
            }

            try
            {
                UpdateRequestStatus(referenceID, tableName, newStatus);

                MessageBox.Show(
                    "Request " + referenceID + " has been " + newStatus.ToLower() + " successfully.",
                    "Request Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadAllActivities(txtSearchActivities.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update request: " + ex.Message, "All Activities");
                LoadAllActivities(txtSearchActivities.Text.Trim());
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
                            string reservationQuery = @"
                        SELECT EquipmentID, Quantity, Status
                        FROM dbo.EquipmentReservations WITH (UPDLOCK, HOLDLOCK)
                        WHERE ReferenceID = @ReferenceID";

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
                                string quantityQuery = @"
                            UPDATE dbo.Equipment
                            SET AvailableQuantity = AvailableQuantity - @Quantity
                            WHERE EquipmentID = @EquipmentID
                            AND AvailableQuantity >= @Quantity";

                                using (SqlCommand command = new SqlCommand(quantityQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@EquipmentID", equipmentID);
                                    command.Parameters.AddWithValue("@Quantity", requestedQuantity);

                                    if (command.ExecuteNonQuery() == 0)
                                        throw new Exception("Not enough available equipment to approve this reservation.");
                                }
                            }
                        }

                        string updateQuery = "UPDATE " + tableName +
                            " SET Status = @Status WHERE ReferenceID = @ReferenceID AND Status = 'Pending'";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@Status", newStatus);
                            command.Parameters.AddWithValue("@ReferenceID", referenceID);

                            if (command.ExecuteNonQuery() == 0)
                                throw new Exception("The request could not be updated. It may have already been processed.");
                        }

                        string dashboardQuery = @"
                    UPDATE dbo.AllResidentRequests
                    SET Status = @Status
                    WHERE ReferenceID = @ReferenceID";

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


        // VIEW AND DELETE BUTTONS
        private void dgvAllActivities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string columnName = dgvAllActivities.Columns[e.ColumnIndex].Name;

            string referenceID = dgvAllActivities.Rows[e.RowIndex].Cells["ReferenceID"].Value?.ToString();

            if (string.IsNullOrEmpty(referenceID))
                return;

            // VIEW REQUEST DETAILS
            if (columnName == "btnView")
            {
                LoadActivityDetails(referenceID);
            }
            else if (columnName == "btnReturn")
            {
                string status = dgvAllActivities.Rows[e.RowIndex]
                    .Cells["Status"].Value?.ToString();

                if (referenceID.StartsWith("RSV-") && status == "Approved")
                {
                    ReturnEquipment(referenceID);
                }
            }

            // DELETE REQUEST
            else if (columnName == "btnDelete")
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to permanently delete request " + referenceID + "?","Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmation != DialogResult.Yes)
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

                try
                {
                    using (SqlConnection connection = DatabaseConnection.GetConnection())
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM " + tableName +" WHERE ReferenceID = @ReferenceID";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ReferenceID", referenceID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("The original request could not be found.");
                                return;
                            }
                        }

                        string dashboardQuery = @"DELETE FROM dbo.AllResidentRequests WHERE ReferenceID = @ReferenceID";

                        using (SqlCommand command = new SqlCommand(dashboardQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ReferenceID", referenceID);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Request " + referenceID + " has been deleted successfully.","Delete Successful",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllActivities(txtSearchActivities.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete request: " + ex.Message,"Delete Request",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void ReturnEquipment(string referenceID)
        {
            DialogResult confirmation = MessageBox.Show(
                "Are you sure you want to return the equipment for reservation " + referenceID + "?",
                "Confirm Equipment Return",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmation != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string reservationQuery = @"
                        SELECT EquipmentID, Quantity, Status
                        FROM dbo.EquipmentReservations WITH (UPDLOCK, HOLDLOCK)
                        WHERE ReferenceID = @ReferenceID";

                            int equipmentID;
                            int quantity;
                            string currentStatus;

                            using (SqlCommand command = new SqlCommand(reservationQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ReferenceID", referenceID);

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (!reader.Read())
                                        throw new Exception("Reservation not found.");

                                    equipmentID = Convert.ToInt32(reader["EquipmentID"]);
                                    quantity = Convert.ToInt32(reader["Quantity"]);
                                    currentStatus = reader["Status"].ToString();
                                }
                            }

                            if (currentStatus != "Approved")
                                throw new Exception("Only approved reservations can be returned.");

                            string equipmentQuery = @"
                        UPDATE dbo.Equipment
                        SET AvailableQuantity = AvailableQuantity + @Quantity
                        WHERE EquipmentID = @EquipmentID
                        AND AvailableQuantity + @Quantity <= TotalQuantity";

                            using (SqlCommand command = new SqlCommand(equipmentQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@EquipmentID", equipmentID);
                                command.Parameters.AddWithValue("@Quantity", quantity);

                                if (command.ExecuteNonQuery() == 0)
                                    throw new Exception("Unable to restore equipment quantity. Please check the inventory.");
                            }

                            string updateReservation = @"
                        UPDATE dbo.EquipmentReservations
                        SET Status = 'Returned'
                        WHERE ReferenceID = @ReferenceID
                        AND Status = 'Approved'";

                            using (SqlCommand command = new SqlCommand(updateReservation, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ReferenceID", referenceID);

                                if (command.ExecuteNonQuery() == 0)
                                    throw new Exception("Reservation status could not be updated.");
                            }

                            string updateDashboard = @"
                        UPDATE dbo.AllResidentRequests
                        SET Status = 'Returned'
                        WHERE ReferenceID = @ReferenceID";

                            using (SqlCommand command = new SqlCommand(updateDashboard, connection, transaction))
                            {
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

                MessageBox.Show(
                    "Equipment for reservation " + referenceID + " has been returned successfully.",
                    "Return Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadAllActivities(txtSearchActivities.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to return equipment: " + ex.Message,
                    "Equipment Return",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        // LOAD REQUEST DETAILS
        private void LoadActivityDetails(string referenceID)
        {
            string query;

            if (referenceID.StartsWith("CRT-"))
            {
                query = @"
                    SELECT C.ReferenceID, R.FullName, C.CertificateType,
                           C.Purpose, C.DateRequested, C.AdditionalRemarks
                    FROM dbo.CertificateRequests C
                    INNER JOIN dbo.Residents R ON C.ResidentID = R.ResidentID
                    WHERE C.ReferenceID = @ReferenceID";
            }
            else if (referenceID.StartsWith("CMP-"))
            {
                query = @"
                    SELECT C.ReferenceID, R.FullName, C.Category,
                           C.IncidentLocation, C.Description,
                           C.IncidentDate, C.DateSubmitted
                    FROM dbo.Complaints C
                    INNER JOIN dbo.Residents R ON C.ResidentID = R.ResidentID
                    WHERE C.ReferenceID = @ReferenceID";
            }

            else if (referenceID.StartsWith("RSV-"))
            {
                query = @"
        SELECT ER.ReferenceID, R.FullName, E.EquipmentName,
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
                                    string value = reader.IsDBNull(i)
                                        ? "N/A"
                                        : reader[i].ToString();

                                    if (!reader.IsDBNull(i) && reader[i] is DateTime)
                                    {
                                        value = Convert.ToDateTime(reader[i])
                                            .ToString("dd/MM/yyyy hh:mm tt");
                                    }

                                    details += reader.GetName(i) + ": " +
                                               value + Environment.NewLine;
                                }

                                MessageBox.Show(
                                    details,
                                    "Request Details - " + referenceID,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
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
                MessageBox.Show(
                    "Unable to load request details: " + ex.Message,
                    "Request Details");
            }
        }
        private void dgvAllActivities_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvAllActivities.Columns[e.ColumnIndex].Name != "btnReturn")
                return;

            string referenceID = dgvAllActivities.Rows[e.RowIndex]
                .Cells["ReferenceID"].Value?.ToString();

            string status = dgvAllActivities.Rows[e.RowIndex]
                .Cells["Status"].Value?.ToString();

            if (referenceID == null ||
                !referenceID.StartsWith("RSV-") ||
                status != "Approved")
            {
                e.PaintBackground(e.CellBounds, true);
                e.Handled = true;
            }
        }
    }
}
