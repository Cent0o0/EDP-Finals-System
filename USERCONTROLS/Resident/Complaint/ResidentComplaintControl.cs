using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    public partial class ResidentComplaintControl : UserControl
    {
        private string residentID;
        private bool isSubmitting;

        public ResidentComplaintControl()
        {
            InitializeComponent();
        }

        public ResidentComplaintControl(string resident) : this()
        {
            residentID = resident;
        }
        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(residentID))
            {
                MessageBox.Show("Your resident account could not be identified. Please sign in again.", "Complaint Submission");
                return;
            }

            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a complaint category.", "Category Required");
                cmbCategory.Focus();
                return;
            }

            string incidentLocation = txtIncidentLocation.Text.Trim();

            if (incidentLocation.Length == 0)
            {
                MessageBox.Show("Please enter the incident location.", "Incident Location Required");
                txtIncidentLocation.Focus();
                return;
            }

            string description = txtDescription.Text.Trim();

            if (description.Length == 0)
            {
                MessageBox.Show("Please describe the complaint.", "Description Required");
                txtDescription.Focus();
                return;
            }

            if (isSubmitting)
                return;

            isSubmitting = true;
            btnSubmitComplaint.Enabled = false;

            try
            {
                DialogResult confirmation = MessageBox.Show("Do you want to submit this complaint report?", "Confirm Submission",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation != DialogResult.Yes)
                    return;

                string referenceID;

                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Generate the next Complaint Reference ID
                    string referenceQuery = @"SELECT NEXT VALUE FOR dbo.ComplaintReferenceSequence";

                    int nextNumber;

                    using (SqlCommand referenceCommand =
                        new SqlCommand(referenceQuery, connection))
                    {
                        nextNumber = Convert.ToInt32(referenceCommand.ExecuteScalar());
                    }

                    referenceID = "CMP-" + nextNumber.ToString("D3");

                    // Insert the complaint with its Reference ID
                    string query = @" INSERT INTO dbo.Complaints (ReferenceID, ResidentID, Category, IncidentLocation, Description, IncidentDate) VALUES (@ReferenceID, @ResidentID, @Category, @IncidentLocation, @Description, @IncidentDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReferenceID", referenceID);
                        command.Parameters.AddWithValue("@ResidentID", residentID);
                        command.Parameters.AddWithValue("@Category", cmbCategory.Text.Trim());
                        command.Parameters.AddWithValue("@IncidentLocation", incidentLocation);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@IncidentDate", dtpIncidentDate.Value.Date);

                        command.ExecuteNonQuery();
                    }
                    string dashboardQuery = @"INSERT INTO dbo.AllResidentRequests(ReferenceID, RequestType, DateSubmitted, Status) SELECT ReferenceID, 'Complaint: ' + Category, DateSubmitted, Status FROM dbo.Complaints WHERE ReferenceID = @ReferenceID";

                    using (SqlCommand dashboardCommand = new SqlCommand(dashboardQuery, connection))
                    {
                        dashboardCommand.Parameters.AddWithValue("@ReferenceID", referenceID);
                        dashboardCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Your complaint was submitted successfully.\n\n" +"Reference ID: " + referenceID,"Complaint Submitted", MessageBoxButtons.OK,MessageBoxIcon.Information);

                cmbCategory.SelectedIndex = -1;
                txtIncidentLocation.Clear();
                txtDescription.Clear();
                dtpIncidentDate.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not submit your complaint: " + ex.Message,"Complaint Submission");
            }
            finally
            {
                isSubmitting = false;
                btnSubmitComplaint.Enabled = true;
            }
        }

    }
}

