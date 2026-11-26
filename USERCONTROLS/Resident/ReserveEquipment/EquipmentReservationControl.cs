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
            dtpReturnDate.MinDate = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today.AddDays(1);
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
            if (dtpReturnDate.Value.Date <= dtpEventDate.Value.Date)
            {
                MessageBox.Show("Return date must be after the event date.");
                dtpReturnDate.Focus();
                return;
            }

            if (isSubmitting)
                return;

            isSubmitting = true;
            btnSubmit.Enabled = false;

            try
            {
                DialogResult confirmation = MessageBox.Show("Do you want to submit this equipment reservation?", "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation != DialogResult.Yes)
                    return;

                string referenceID;

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Generate Reference ID
                    string referenceQuery = @"SELECT NEXT VALUE FOR dbo.ReservationReferenceSequence";

                    int nextNumber;

                    using (SqlCommand referenceCommand =
                        new SqlCommand(referenceQuery, conn))
                    {
                        nextNumber = Convert.ToInt32(referenceCommand.ExecuteScalar());
                    }

                    referenceID = "RSV-" + nextNumber.ToString("D3");

                    // Save reservation
                    string query = @"INSERT INTO dbo.EquipmentReservations (ReferenceID, ResidentID, EquipmentID, Quantity, EventName, EventDate, ReturnDate, Purpose, Status) VALUES (@ReferenceID, @ResidentID, @EquipmentID, @Quantity, @EventName, @EventDate, @ReturnDate, @Purpose, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReferenceID", referenceID);
                        cmd.Parameters.AddWithValue("@ResidentID", residentID);
                        cmd.Parameters.AddWithValue("@EquipmentID", equipmentID);
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(numQuantity.Value));
                        cmd.Parameters.AddWithValue("@EventName", eventName);
                        cmd.Parameters.AddWithValue("@EventDate", dtpEventDate.Value.Date);
                        cmd.Parameters.AddWithValue("@ReturnDate", dtpReturnDate.Value.Date);
                        cmd.Parameters.AddWithValue("@Purpose", purpose);
                        cmd.Parameters.AddWithValue("@Status", "Pending");

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string dashboardQuery = @"INSERT INTO dbo.AllResidentRequests (ReferenceID, RequestType, DateSubmitted, Status) SELECT ReferenceID, 'Equipment: ' + EventName, DateRequested, Status FROM dbo.EquipmentReservations WHERE ReferenceID = @ReferenceID";

                            using (SqlCommand dashboardCommand = new SqlCommand(dashboardQuery, conn))
                            {
                                dashboardCommand.Parameters.AddWithValue("@ReferenceID", referenceID);
                                dashboardCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Your equipment reservation has been submitted successfully.\n\n" + "Reference ID: " + referenceID, "Reservation Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save the reservation: " + ex.Message,"Reservation Submission");
            }
            finally
            {
                isSubmitting = false;
                btnSubmit.Enabled = true;
            }
        }
    }
}
