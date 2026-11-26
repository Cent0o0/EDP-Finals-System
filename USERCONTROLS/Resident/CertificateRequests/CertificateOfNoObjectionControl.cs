using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Text;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    public partial class CertificateOfNoObjectionControl : UserControl
    {
        private string residentID;
        private bool isSubmitting;

        public CertificateOfNoObjectionControl()
        {
            InitializeComponent();
            btnSubmitRequest.Enabled = false;
        }

        public CertificateOfNoObjectionControl(string resident) : this()
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
                MessageBox.Show("Could not load your resident information: " + ex.Message, "No Objection Certification");
            }
        }


        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Trim().Length == 0 || txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Your account must have a full name and complete address before you can submit this request.", "Resident Information Required");
                return;
            }

            string subjectActivity = txtSubjectActivity.Text.Trim();

            if (subjectActivity.Length == 0)
            {
                MessageBox.Show("Please enter the subject or activity for this request.", "Subject or Activity Required");
                txtSubjectActivity.Focus();
                return;
            }

            string location = txtLocation.Text.Trim();

            if (location.Length == 0)
            {
                MessageBox.Show("Please enter the location of the activity.", "Activity Location Required");
                txtLocation.Focus();
                return;
            }

            string purpose = txtPurpose.Text.Trim();

            if (purpose.Length == 0)
            {
                MessageBox.Show("Please enter the purpose of the request.", "Purpose Required");
                txtPurpose.Focus();
                return;
            }

            StringBuilder requestDetails = new StringBuilder();
            requestDetails.AppendLine("Subject / Activity: " + subjectActivity);

            if (nudQuantity.Value > 0)
            {
                requestDetails.AppendLine("Quantity: " + nudQuantity.Value.ToString());
            }

            requestDetails.Append("Location of Activity: ");
            requestDetails.Append(location);

            if (requestDetails.Length > 1000 || purpose.Length > 200)
            {
                MessageBox.Show("Please shorten the purpose or activity details. The request details must fit the certificate request fields.", "Request Details Too Long");
                return;
            }

            if (isSubmitting)
                return;

            isSubmitting = true;
            btnSubmitRequest.Enabled = false;

            try
            {
                DialogResult confirmation = MessageBox.Show("Do you want to submit this No Objection Certification request?", "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

                    // Save the No Objection Certification request
                    string query = @"
                INSERT INTO dbo.CertificateRequests
                (ReferenceID, ResidentID, CertificateType, Purpose, AdditionalRemarks)
                VALUES
                (@ReferenceID, @ResidentID, @CertificateType, @Purpose, @AdditionalRemarks)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReferenceID", referenceID);
                        command.Parameters.AddWithValue("@ResidentID", residentID);
                        command.Parameters.AddWithValue("@CertificateType", "Certificate of No Objection");
                        command.Parameters.AddWithValue("@Purpose", purpose);
                        command.Parameters.AddWithValue("@AdditionalRemarks", requestDetails.ToString());

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
                    "Your No Objection Certification request was submitted successfully.\n\n" +
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
                MessageBox.Show("Could not submit your No Objection Certification request: " + ex.Message, "No Objection Certification");
            }
            finally
            {
                isSubmitting = false;
                btnSubmitRequest.Enabled = true;
            }
        }

    }
}
