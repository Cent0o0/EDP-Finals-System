using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    public partial class CertificateOfResidencyControl : UserControl
    {
        private string residentID;
        private bool isSubmitting;

        public CertificateOfResidencyControl()
        {
            InitializeComponent();
            btnSubmitRequest.Enabled = false;
        }

        public CertificateOfResidencyControl(string resident) : this()
        {
            residentID = resident;
            LoadResidentName();
        }

        private void LoadResidentName()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT FullName FROM dbo.Residents WHERE ResidentID = @ResidentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResidentID", residentID);

                        object fullName = command.ExecuteScalar();
                        if (fullName != null && fullName != DBNull.Value)
                        {
                            txtFullName.Text = fullName.ToString();
                            btnSubmitRequest.Enabled = true;
                            return;
                        }
                    }
                }

                MessageBox.Show("Your resident information could not be found. Please sign in again or contact the barangay office.", "Resident Information Not Found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load your resident name: " + ex.Message, "Certificate of Residency");
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


        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (!dtpDateStartedResiding.Checked)
            {
                MessageBox.Show("Please select the date you started residing in the barangay.", "Date Started Residing Required");
                dtpDateStartedResiding.Focus();
                return;
            }

            if (cmbPurpose.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a purpose for the residency certificate.", "Purpose Required");
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

            string requestDetails = "Date Started Residing: " +
                dtpDateStartedResiding.Value.ToString("MMMM d, yyyy");

            if (purpose == "Other")
            {
                requestDetails = requestDetails +
                    Environment.NewLine + "Other Purpose: " + otherPurpose;
            }

            string remarks = txtAdditionalRemarks.Text.Trim();

            if (remarks.Length > 0)
            {
                requestDetails = requestDetails +
                    Environment.NewLine + "Additional Remarks: " + remarks;
            }

            if (requestDetails.Length > 1000)
            {
                MessageBox.Show("The request details must be 1000 characters or fewer.", "Request Details Too Long");
                txtAdditionalRemarks.Focus();
                return;
            }

            if (isSubmitting)
                return;

            isSubmitting = true;
            btnSubmitRequest.Enabled = false;

            try
            {
                DialogResult confirmation = MessageBox.Show("Do you want to submit this Certificate of Residency request?", "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation != DialogResult.Yes)
                    return;

                string referenceID;

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Generate the next shared Certificate Reference ID
                    string referenceQuery = @"SELECT NEXT VALUE FOR dbo.CertificateReferenceSequence";

                    int nextNumber;

                    using (SqlCommand referenceCommand =
                        new SqlCommand(referenceQuery, connection))
                    {
                        nextNumber = Convert.ToInt32(referenceCommand.ExecuteScalar());
                    }

                    referenceID = "CRT-" + nextNumber.ToString("D3");

                    // Insert the Certificate of Residency request
                    string query = @"
                INSERT INTO dbo.CertificateRequests
                (ReferenceID, ResidentID, CertificateType, Purpose, AdditionalRemarks)
                VALUES
                (@ReferenceID, @ResidentID, @CertificateType, @Purpose, @AdditionalRemarks)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReferenceID", referenceID);
                        command.Parameters.AddWithValue("@ResidentID", residentID);
                        command.Parameters.AddWithValue("@CertificateType", "Certificate of Residency");
                        command.Parameters.AddWithValue("@Purpose", purpose);
                        command.Parameters.AddWithValue("@AdditionalRemarks", requestDetails);

                        command.ExecuteNonQuery();
                    }
                    string dashboardQuery = @"INSERT INTO dbo.AllResidentRequests (ReferenceID, RequestType, DateSubmitted, Status) SELECT ReferenceID, CertificateType, DateRequested, Status FROM dbo.CertificateRequests WHERE ReferenceID = @ReferenceID";

                    using (SqlCommand dashboardCommand = new SqlCommand(dashboardQuery, connection))
                    {
                        dashboardCommand.Parameters.AddWithValue("@ReferenceID", referenceID);
                        dashboardCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Your Certificate of Residency request was submitted successfully.\n\n" +
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
                MessageBox.Show("Could not submit your residency certificate request: " + ex.Message, "Certificate of Residency");
            }
            finally
            {
                isSubmitting = false;
                btnSubmitRequest.Enabled = true;
            }
        }

    }
}
