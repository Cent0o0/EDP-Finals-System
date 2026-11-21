using Barangay_E_Service_System.DATA;
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
    }
}
