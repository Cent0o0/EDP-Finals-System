using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    public partial class BarangayClearanceControl : UserControl
    {
        private string residentID;
        private bool isSubmitting;

        public BarangayClearanceControl(string resident)
        {
            InitializeComponent();
            residentID = resident;
            LoadResidentInformation();
        }

        private void LoadResidentInformation()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT FullName, Address, ContactNumber FROM dbo.Residents WHERE ResidentID = @ResidentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResidentID", residentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader["FullName"].ToString();
                                txtAddress.Text = reader["Address"].ToString();
                                txtContactNumber.Text = reader["ContactNumber"].ToString();
                                btnSubmitRequest.Enabled = true;
                                return;
                            }
                        }
                    }
                }

                MessageBox.Show("Your resident information could not be found. Please sign in again or contact the barangay office.", "Resident Information Not Found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load your resident information: " + ex.Message, "Clearance Request");
            }
        }



        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (cmbPurpose.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a purpose for the clearance.", "Purpose Required");
                cmbPurpose.Focus();
                return;
            }

            string purpose = cmbPurpose.Text.Trim();
            string otherPurpose = txtOtherPurpose.Text.Trim();

            if (purpose == "Other" && otherPurpose.Length == 0)
            {
                MessageBox.Show("Please specify the other purpose for the clearance.", "Other Purpose Required");
                txtOtherPurpose.Focus();
                return;
            }

            string remarks = txtAdditionalRemarks.Text.Trim();

            if (purpose == "Other")
            {
                remarks = remarks.Length > 0
                    ? "Other Purpose: " + otherPurpose + Environment.NewLine +
                      "Additional Remarks: " + remarks
                    : "Other Purpose: " + otherPurpose;
            }   
            if (remarks.Length > 1000)
            {
                MessageBox.Show("The purpose details and additional remarks must be 1000 characters or fewer.", "Request Details");
                txtAdditionalRemarks.Focus();
                return;
            }

            if (isSubmitting)
                return;

            isSubmitting = true;
            btnSubmitRequest.Enabled = false;

            try
            {
                DialogResult confirmation = MessageBox.Show("Do you want to submit this Barangay Clearance request?", "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation != DialogResult.Yes)
                    return;

                string referenceID;

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Generate the next Reference ID

                    string referenceQuery = @"SELECT NEXT VALUE FOR dbo.CertificateReferenceSequence";

                    int nextNumber;

                    using (SqlCommand referenceCommand =
                        new SqlCommand(referenceQuery, connection))
                    {
                        nextNumber = Convert.ToInt32(referenceCommand.ExecuteScalar());
                    }

                    referenceID = "CRT-" + nextNumber.ToString("D3");


                    // Insert the clearance request
                    string query = @"INSERT INTO dbo.CertificateRequests (ReferenceID, ResidentID, CertificateType, Purpose, AdditionalRemarks)VALUES (@ReferenceID, @ResidentID, @CertificateType, @Purpose, @AdditionalRemarks)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReferenceID", referenceID);
                        command.Parameters.AddWithValue("@ResidentID", residentID);
                        command.Parameters.AddWithValue("@CertificateType", "Barangay Clearance");
                        command.Parameters.AddWithValue("@Purpose", purpose);
                        command.Parameters.AddWithValue("@AdditionalRemarks", remarks);

                        command.ExecuteNonQuery();
                    }
                    string dashboardQuery = @"INSERT INTO dbo.AllResidentRequests (ReferenceID, RequestType, DateSubmitted, Status) SELECT ReferenceID, CertificateType, DateRequested, Status FROM dbo.CertificateRequests WHERE ReferenceID = @ReferenceID";

                    using (SqlCommand dashboardCommand = new SqlCommand(dashboardQuery, connection))
                    {
                        dashboardCommand.Parameters.AddWithValue("@ReferenceID", referenceID);
                        dashboardCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Your Barangay Clearance request was submitted successfully.\n\n" + "Reference ID: " + referenceID,"Request Submitted",MessageBoxButtons.OK, MessageBoxIcon.Information);

                Barangay_E_Service_System.MainForm mainForm = FindForm() as Barangay_E_Service_System.MainForm;

                if (mainForm != null)
                {
                    mainForm.ShowResidentDashboardContent(new Barangay_E_Service_System.USERCONTROLS.Resident.ResidentCertificateControl(residentID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not submit your clearance request: " + ex.Message,"Clearance Request");
            }
            finally
            {
                isSubmitting = false;
                btnSubmitRequest.Enabled = true;
            }
        }



        private void cmbPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isOtherPurpose = cmbPurpose.Text == "Other";
            lblOtherPurpose.Visible = isOtherPurpose;
            txtOtherPurpose.Visible = isOtherPurpose;

            if (!isOtherPurpose)
            {
                txtOtherPurpose.Clear();
            }
        }
    }
}
