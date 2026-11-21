using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    public partial class EquipmentReservationControl : UserControl
    {
        private string residentID;
        private int equipmentID;
        private bool isSubmitting;
        public EquipmentReservationControl(string residentID, int equipmentID)
        {
            InitializeComponent();

            this.residentID = residentID;
            this.equipmentID = equipmentID;

            dtpEventDate.MinDate = DateTime.Today;
            LoadEquipmentDetails();
        }
        private void LoadEquipmentDetails()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string  query = @"SELECT EquipmentName, AvailableQuantity FROM dbo.Equipment WHERE EquipmentID = @EquipmentID AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EquipmentID", equipmentID);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string equipmentName = reader["EquipmentName"].ToString();
                            int availableQuantity = Convert.ToInt32(reader["AvailableQuantity"]);

                            lblEquipmentName.Text = equipmentName;
                            lblAvailableQuantity.Text = "Available quantity: " + availableQuantity;

                            numQuantity.Minimum = 0;
                            btnSubmit.Enabled = false;

                            if (availableQuantity > 0)
                            {
                                numQuantity.Minimum = 1;
                                numQuantity.Maximum = availableQuantity;
                                numQuantity.Value = 1;

                                numQuantity.Enabled = true;
                                btnSubmit.Enabled = true;
                            }
                            else
                            {
                                numQuantity.Value = 0;
                                numQuantity.Enabled = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Equipment not found.");
                        }
                    }

                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text.Trim();
            string purpose = txtPurpose.Text.Trim();

            if (eventName == "")
            {
                MessageBox.Show("Please enter the event name.");
                txtEventName.Focus();
                return;
            }

            if (purpose == "")
            {
                MessageBox.Show("Please enter the purpose of the reservation.");
                txtPurpose.Focus();
                return;
            }

            if (numQuantity.Value < 1)
            {
                MessageBox.Show("Please select a quantity greater than zero.");
                numQuantity.Focus();
                return;
            }

            if (dtpEventDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Please select today or a future event date.");
                return;
            }

            if (isSubmitting)
            {
                return;
            }

            isSubmitting = true;
            btnSubmit.Enabled = false;
            DialogResult confirmation = MessageBox.Show(
                "Do you want to submit this equipment reservation?",
                "Confirm Submission",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                isSubmitting = false;
                btnSubmit.Enabled = true;
                return;
            }

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string tableName = FindEquipmentReservationTable(conn);
                    if (tableName.Length == 0)
                    {
                        MessageBox.Show("The equipment reservation table was not found. Check its name in SSMS before submitting.", "Reservation Table Not Found");
                        return;
                    }

                    string safeTableName = "dbo.[" + tableName.Replace("]", "]]" ) + "]";
                    string query = "INSERT INTO " + safeTableName + @"
                                    (ResidentID, EquipmentID, Quantity, EventName, EventDate, Purpose, Status)
                                    VALUES
                                    (@ResidentID, @EquipmentID, @Quantity, @EventName, @EventDate, @Purpose, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ResidentID", residentID);
                        cmd.Parameters.AddWithValue("@EquipmentID", equipmentID);
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(numQuantity.Value));
                        cmd.Parameters.AddWithValue("@EventName", eventName);
                        cmd.Parameters.AddWithValue("@EventDate", dtpEventDate.Value.Date);
                        cmd.Parameters.AddWithValue("@Purpose", purpose);
                        cmd.Parameters.AddWithValue("@Status", "Pending");

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your equipment reservation has been submitted.");

                            MainForm mainForm = FindForm() as MainForm;
                            if (mainForm != null)
                            {
                                ResidentReservationControl reservationPage = new ResidentReservationControl(residentID);
                                mainForm.ShowResidentDashboardContent(reservationPage);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The reservation could not be submitted. Please try again.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Unable to save the reservation. Please check the equipment reservation table and try again.\n\n" + ex.Message);
                }
                finally
                {
                    isSubmitting = false;
                    btnSubmit.Enabled = true;
                }
            }
        }

        private string FindEquipmentReservationTable(SqlConnection connection)
        {
            string query = @"SELECT TOP (1) TABLE_NAME
                             FROM INFORMATION_SCHEMA.TABLES
                             WHERE TABLE_SCHEMA = 'dbo'
                               AND TABLE_NAME IN ('EquipmentReservation', 'EquipmentReservations')
                             ORDER BY CASE TABLE_NAME
                                 WHEN 'EquipmentReservation' THEN 0
                                 WHEN 'EquipmentReservations' THEN 1
                                 ELSE 2
                             END";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                {
                    return "";
                }

                return (string)result;
            }
        }

    }
}
