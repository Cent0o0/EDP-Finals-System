using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    public partial class BarangayClearanceControl : UserControl
    {
        private string residentID;

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
                if (remarks.Length > 0)
                {
                    remarks = "Other Purpose: " + otherPurpose + Environment.NewLine + "Additional Remarks: " + remarks;
                }
                else
                {
                    remarks = "Other Purpose: " + otherPurpose;
                }
            }

            if (remarks.Length > 1000)
            {
                MessageBox.Show("The purpose details and additional remarks must be 1000 characters or fewer.", "Request Details");
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
                        command.Parameters.AddWithValue("@CertificateType", "Barangay Clearance");
                        command.Parameters.AddWithValue("@Purpose", purpose);
                        command.Parameters.AddWithValue("@AdditionalRemarks", remarks);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Your Barangay Clearance request was submitted successfully.", "Request Submitted");
                cmbPurpose.SelectedIndex = -1;
                txtOtherPurpose.Clear();
                txtAdditionalRemarks.Clear();
                lblOtherPurpose.Visible = false;
                txtOtherPurpose.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not submit your clearance request: " + ex.Message, "Clearance Request");
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
