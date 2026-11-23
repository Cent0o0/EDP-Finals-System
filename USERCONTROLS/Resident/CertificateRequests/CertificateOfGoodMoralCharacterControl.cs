using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    public partial class CertificateOfGoodMoralCharacterControl : UserControl
    {
        private string residentID;
        private bool isSubmitting;

        public CertificateOfGoodMoralCharacterControl()
        {
            InitializeComponent();
            btnSubmitRequest.Enabled = false;
        }

        public CertificateOfGoodMoralCharacterControl(string resident) : this()
        {
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
                    string query = @"SELECT FullName, Address, ContactNumber
                                     FROM dbo.Residents
                                     WHERE ResidentID = @ResidentID";

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
                MessageBox.Show("Could not load your resident information: " + ex.Message, "Good Moral Certificate Request");
            }
        }


        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (cmbPurpose.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a purpose for the certificate.", "Purpose Required");
                cmbPurpose.Focus();
                return;
            }

            string purpose = cmbPurpose.Text.Trim();
            string otherPurpose = txtOtherPurpose.Text.Trim();

            if (purpose == "Other" && otherPurpose.Length == 0)
            {
                MessageBox.Show("Please specify the other purpose for the certificate.", "Other Purpose Required");
                txtOtherPurpose.Focus();
                return;
            }

            string additionalRemarks = txtAdditionalRemarks.Text.Trim();

            if (purpose == "Other")
            {
                if (additionalRemarks.Length > 0)
                {
                    additionalRemarks = "Other Purpose: " + otherPurpose +
                        Environment.NewLine + "Additional Remarks: " + additionalRemarks;
                }
                else
                {
                    additionalRemarks = "Other Purpose: " + otherPurpose;
                }
            }

            if (additionalRemarks.Length > 1000)
            {
                MessageBox.Show("Combined request details must be 1000 characters or fewer.", "Request Details Too Long");
                txtAdditionalRemarks.Focus();
                return;
            }

            if (isSubmitting)
                return;

            isSubmitting = true;
            btnSubmitRequest.Enabled = false;

            try
            {
                DialogResult confirmation = MessageBox.Show(
                    "Do you want to submit this Good Moral Character certificate request?",
                    "Confirm Submission",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmation != DialogResult.Yes)
                    return;

                string referenceID;

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Generate the next shared Certificate Reference ID
                    string referenceQuery = @"
                SELECT NEXT VALUE FOR dbo.CertificateReferenceSequence";

                    int nextNumber;

                    using (SqlCommand referenceCommand =
                        new SqlCommand(referenceQuery, connection))
                    {
                        nextNumber = Convert.ToInt32(referenceCommand.ExecuteScalar());
                    }

                    referenceID = "CRT-" + nextNumber.ToString("D3");

                    // Save the certificate request
                    string query = @"
                INSERT INTO dbo.CertificateRequests
                (ReferenceID, ResidentID, CertificateType, Purpose, AdditionalRemarks)
                VALUES
                (@ReferenceID, @ResidentID, @CertificateType, @Purpose, @AdditionalRemarks)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReferenceID", referenceID);
                        command.Parameters.AddWithValue("@ResidentID", residentID);
                        command.Parameters.AddWithValue("@CertificateType", "Certificate of Good Moral Character");
                        command.Parameters.AddWithValue("@Purpose", purpose);
                        command.Parameters.AddWithValue("@AdditionalRemarks", additionalRemarks);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Your Good Moral Character Certificate request was submitted successfully.\n\n" +
                    "Reference ID: " + referenceID,
                    "Request Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Barangay_E_Service_System.MainForm mainForm =
                    FindForm() as Barangay_E_Service_System.MainForm;

                if (mainForm != null)
                {
                    mainForm.ShowResidentDashboardContent(
                        new Barangay_E_Service_System.USERCONTROLS.Resident.ResidentCertificateControl(residentID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not submit your certificate request: " + ex.Message,
                    "Good Moral Certificate Request");
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
