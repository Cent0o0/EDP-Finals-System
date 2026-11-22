using Barangay_E_Service_System.DATA;
using Barangay_E_Service_System;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    public partial class ResidentProfileControl : UserControl
    {
        private string residentID;
        private ResidentDashboardControl? dashboardControl;

        public ResidentProfileControl()
        {
            InitializeComponent();
        }

        public ResidentProfileControl(string residentID, ResidentDashboardControl dashboardControl)
        {
            InitializeComponent();
            this.residentID = residentID;
            this.dashboardControl = dashboardControl;
            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT FirstName, LastName, MiddleInitial, Suffix, Address, ContactNumber, Username, FullName FROM dbo.Residents WHERE ResidentID = @ResidentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResidentID", residentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblFirstNameValue.Text = reader["FirstName"].ToString();
                                lblLastNameValue.Text = reader["LastName"].ToString();
                                lblMiddleInitialValue.Text = reader["MiddleInitial"].ToString();
                                lblSuffixValue.Text = reader["Suffix"].ToString();
                                lblAddressValue.Text = reader["Address"].ToString();
                                lblContactNumberValue.Text = reader["ContactNumber"].ToString();
                                lblUsernameValue.Text = reader["Username"].ToString();

                                if (string.IsNullOrWhiteSpace(lblFirstNameValue.Text) ||
                                    string.IsNullOrWhiteSpace(lblLastNameValue.Text))
                                {
                                    string fullName = "";
                                    int fullNameColumn = reader.GetOrdinal("FullName");
                                    if (!reader.IsDBNull(fullNameColumn))
                                    {
                                        fullName = reader.GetString(fullNameColumn);
                                    }
                                    LoadNameFromFullName(fullName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load your profile: " + ex.Message);
            }
        }

        private void LoadNameFromFullName(string fullName)
        {
            string[] nameParts = fullName.Split(' ');

            if (nameParts.Length > 0 && string.IsNullOrWhiteSpace(lblFirstNameValue.Text))
            {
                lblFirstNameValue.Text = nameParts[0];
            }

            if (nameParts.Length > 1 && string.IsNullOrWhiteSpace(lblLastNameValue.Text))
            {
                lblLastNameValue.Text = nameParts[nameParts.Length - 1];
            }
        }

        private void btnSaveChanges_Click(object? sender, EventArgs e)
        {
            if (dashboardControl != null)
            {
                dashboardControl.ShowEditProfileControl();
            }
        }

        private void lblUsernameValue_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show(
                "Delete your account and all related certificate requests, complaints, and equipment reservations? This action cannot be undone.",
                "Confirm Account Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string deleteRequestsQuery = "DELETE FROM dbo.CertificateRequests WHERE ResidentID = @ResidentID";
                            using (SqlCommand command = new SqlCommand(deleteRequestsQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ResidentID", residentID);
                                command.ExecuteNonQuery();
                            }

                            string deleteComplaintsQuery = "DELETE FROM dbo.Complaints WHERE ResidentID = @ResidentID";
                            using (SqlCommand command = new SqlCommand(deleteComplaintsQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ResidentID", residentID);
                                command.ExecuteNonQuery();
                            }

                            string deleteReservationsQuery = "DELETE FROM dbo.EquipmentReservations WHERE ResidentID = @ResidentID";
                            using (SqlCommand command = new SqlCommand(deleteReservationsQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ResidentID", residentID);
                                command.ExecuteNonQuery();
                            }

                            string deleteResidentQuery = "DELETE FROM dbo.Residents WHERE ResidentID = @ResidentID";
                            using (SqlCommand command = new SqlCommand(deleteResidentQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ResidentID", residentID);
                                int deletedResidents = command.ExecuteNonQuery();

                                if (deletedResidents != 1)
                                {
                                    throw new InvalidOperationException("The resident account could not be found.");
                                }
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show("Your account and related records have been deleted.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = this.FindForm() as MainForm;
                if (mainForm != null)
                {
                    mainForm.ShowResidentLoginControl();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete your account: " + ex.Message, "Account Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
