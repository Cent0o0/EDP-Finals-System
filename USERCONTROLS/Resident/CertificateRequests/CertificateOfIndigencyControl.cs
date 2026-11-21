using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    public partial class CertificateOfIndigencyControl : UserControl
    {
        private string residentID;

        public CertificateOfIndigencyControl()
        {
            InitializeComponent();
            btnSubmitRequest.Enabled = false;
        }

        public CertificateOfIndigencyControl(string resident) : this()
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
                    string query = "SELECT FullName, Address FROM dbo.Residents WHERE ResidentID = @ResidentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResidentID", residentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader["FullName"].ToString();
                                txtAddress.Text = reader["Address"].ToString();

                                if (txtFullName.Text.Trim().Length > 0 && txtAddress.Text.Trim().Length > 0)
                                {
                                    btnSubmitRequest.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Your account must have a full name and complete address before you can submit this request.", "Resident Information Required");
                                }

                                return;
                            }
                        }
                    }
                }

                MessageBox.Show("Your resident information could not be found. Please sign in again or contact the barangay office.", "Resident Information Not Found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load your resident information: " + ex.Message, "Certificate of Indigency");
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
            if (txtFullName.Text.Trim().Length == 0 || txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Your account must have a full name and complete address before you can submit this request.", "Resident Information Required");
                return;
            }

            if (cmbPurpose.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a purpose for the indigency certificate.", "Purpose Required");
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
                    additionalRemarks = "Other Purpose: " + otherPurpose + Environment.NewLine + "Additional Remarks: " + additionalRemarks;
                }
                else
                {
                    additionalRemarks = "Other Purpose: " + otherPurpose;
                }
            }

            if (additionalRemarks.Length > 1000)
            {
                MessageBox.Show("The purpose details and remarks must be 1000 characters or fewer.", "Request Details Too Long");
                txtAdditionalRemarks.Focus();
                return;
            }

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"INSERT INTO dbo.CertificateRequests
                                     (ResidentID, CertificateType, Purpose, AdditionalRemarks)
                                     VALUES (@ResidentID, @CertificateType, @Purpose, @AdditionalRemarks)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResidentID", residentID);
                        command.Parameters.AddWithValue("@CertificateType", "Certificate of Indigency");
                        command.Parameters.AddWithValue("@Purpose", purpose);
                        command.Parameters.AddWithValue("@AdditionalRemarks", additionalRemarks);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Your Certificate of Indigency request was submitted successfully.", "Request Submitted");
                cmbPurpose.SelectedIndex = -1;
                txtOtherPurpose.Clear();
                txtAdditionalRemarks.Clear();
                lblOtherPurpose.Visible = false;
                txtOtherPurpose.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not submit your indigency certificate request: " + ex.Message, "Certificate of Indigency");
            }
        }
    }
}
