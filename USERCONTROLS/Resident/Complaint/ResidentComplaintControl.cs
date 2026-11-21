using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    public partial class ResidentComplaintControl : UserControl
    {
        private string residentID;

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

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"INSERT INTO dbo.Complaints
                                     (ResidentID, Category, IncidentLocation, Description, IncidentDate)
                                     VALUES (@ResidentID, @Category, @IncidentLocation, @Description, @IncidentDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResidentID", residentID);
                        command.Parameters.AddWithValue("@Category", cmbCategory.Text.Trim());
                        command.Parameters.AddWithValue("@IncidentLocation", incidentLocation);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@IncidentDate", dtpIncidentDate.Value.Date);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Your complaint was submitted successfully.", "Complaint Submitted");
                cmbCategory.SelectedIndex = -1;
                txtIncidentLocation.Clear();
                txtDescription.Clear();
                dtpIncidentDate.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not submit your complaint: " + ex.Message, "Complaint Submission");
            }
        }
    }
}
