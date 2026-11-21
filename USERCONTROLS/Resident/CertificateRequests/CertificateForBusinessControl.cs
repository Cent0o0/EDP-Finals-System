using System;
using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    public partial class CertificateForBusinessControl : UserControl
    {
        private string residentID;
        private bool isSubmitting;

        public CertificateForBusinessControl()
        {
            InitializeComponent();
        }

        public CertificateForBusinessControl(string resident) : this()
        {
            residentID = resident;
            LoadResidentInformation();
        }

        private void CertificateForBusinessControl_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(residentID) && !btnSubmitRequest.Enabled)
            {
                LoadResidentInformation();
            }
        }

        private void LoadResidentInformation()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT FullName, ContactNumber
                                     FROM dbo.Residents
                                     WHERE ResidentID = @ResidentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResidentID", residentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtBusinessOwner.Text = reader["FullName"].ToString();
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
                MessageBox.Show("Could not load your resident information: " + ex.Message, "Business Certificate Request");
            }
        }

        private void btnSubmitRequest_Click(object sender, System.EventArgs e)
        {
            string businessName = txtBusinessName.Text.Trim();
            string businessAddress = txtBusinessAddress.Text.Trim();
            string natureOfBusiness = txtNatureOfBusiness.Text.Trim();

            if (businessName.Length == 0)
            {
                MessageBox.Show("Please enter the business name.", "Business Name Required");
                txtBusinessName.Focus();
                return;
            }

            if (businessAddress.Length == 0)
            {
                MessageBox.Show("Please enter the business address.", "Business Address Required");
                txtBusinessAddress.Focus();
                return;
            }

            if (natureOfBusiness.Length == 0)
            {
                MessageBox.Show("Please enter the nature of the business.", "Nature of Business Required");
                txtNatureOfBusiness.Focus();
                return;
            }

            if (cmbBusinessType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the business type.", "Business Type Required");
                cmbBusinessType.Focus();
                return;
            }

            StringBuilder businessDetails = new StringBuilder();
            businessDetails.AppendLine("Business Name: " + businessName);
            businessDetails.AppendLine("Business Owner: " + txtBusinessOwner.Text.Trim());
            businessDetails.AppendLine("Business Address: " + businessAddress);
            businessDetails.AppendLine("Nature of Business: " + natureOfBusiness);
            businessDetails.AppendLine("Business Type: " + cmbBusinessType.Text.Trim());
            businessDetails.Append("Date Established: ");
            businessDetails.Append(dtpDateEstablished.Value.ToString("MMMM yyyy", CultureInfo.InvariantCulture));

            if (isSubmitting)
            {
                return;
            }

            isSubmitting = true;
            btnSubmitRequest.Enabled = false;
            DialogResult confirmation = MessageBox.Show(
                "Do you want to submit this Certificate for Business request?",
                "Confirm Submission",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                isSubmitting = false;
                btnSubmitRequest.Enabled = true;
                return;
            }

            try
            {
                int rowsAffected = 0;
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"INSERT INTO dbo.CertificateRequests
                                     (ResidentID, CertificateType, Purpose, AdditionalRemarks)
                                     VALUES (@ResidentID, @CertificateType, @Purpose, @AdditionalRemarks)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResidentID", residentID);
                        command.Parameters.AddWithValue("@CertificateType", "Certificate for Business");
                        command.Parameters.AddWithValue("@Purpose", "Business certification");
                        command.Parameters.AddWithValue("@AdditionalRemarks", businessDetails.ToString());
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }

                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Could not submit your business certificate request. Please try again.", "Business Certificate Request");
                    return;
                }

                MessageBox.Show("Your Certificate for Business request was submitted successfully.", "Request Submitted");
                Barangay_E_Service_System.MainForm mainForm = FindForm() as Barangay_E_Service_System.MainForm;
                if (mainForm != null)
                {
                    mainForm.ShowResidentDashboardContent(new Barangay_E_Service_System.USERCONTROLS.Resident.ResidentCertificateControl(residentID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not submit your business certificate request: " + ex.Message, "Business Certificate Request");
            }
            finally
            {
                isSubmitting = false;
                btnSubmitRequest.Enabled = true;
            }
        }
    }
}
