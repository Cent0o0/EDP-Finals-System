using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    public partial class ResidentEditProfileControl : UserControl
    {
        private string residentID;
        private ResidentDashboardControl? dashboardControl;
        private bool profileLoaded;
        private string originalFirstName = "";
        private string originalLastName = "";
        private string originalMiddleInitial = "";
        private string originalSuffix = "";
        private string originalAddress = "";
        private string originalContactNumber = "";
        private string originalUsername = "";

        public ResidentEditProfileControl()
        {
            InitializeComponent();
        }

        public ResidentEditProfileControl(string residentID, ResidentDashboardControl dashboardControl)
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
                                txtFirstName.Text = reader["FirstName"].ToString();
                                txtLastName.Text = reader["LastName"].ToString();
                                txtMiddleInitial.Text = reader["MiddleInitial"].ToString();
                                string suffix = reader["Suffix"].ToString();
                                if (!cmbSuffix.Items.Contains(suffix))
                                {
                                    cmbSuffix.Items.Add(suffix);
                                }
                                cmbSuffix.SelectedItem = suffix;
                                txtAddress.Text = reader["Address"].ToString();
                                txtContactNumber.Text = reader["ContactNumber"].ToString();
                                txtUsername.Text = reader["Username"].ToString();

                                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                                    string.IsNullOrWhiteSpace(txtLastName.Text))
                                {
                                    string fullName = "";
                                    int fullNameColumn = reader.GetOrdinal("FullName");
                                    if (!reader.IsDBNull(fullNameColumn))
                                    {
                                        fullName = reader.GetString(fullNameColumn);
                                    }
                                    LoadNameFromFullName(fullName);
                                }

                                StoreOriginalProfileValues();
                                profileLoaded = true;
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

            if (nameParts.Length > 0 && string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                txtFirstName.Text = nameParts[0];
            }

            if (nameParts.Length > 1 && string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                txtLastName.Text = nameParts[nameParts.Length - 1];
            }
        }

        private void StoreOriginalProfileValues()
        {
            originalFirstName = txtFirstName.Text.Trim();
            originalLastName = txtLastName.Text.Trim();
            originalMiddleInitial = txtMiddleInitial.Text.Trim();
            originalSuffix = cmbSuffix.Text.Trim();
            originalAddress = txtAddress.Text.Trim();
            originalContactNumber = txtContactNumber.Text.Trim();
            originalUsername = txtUsername.Text.Trim();
        }

        private bool HasProfileChanged()
        {
            if (txtFirstName.Text.Trim() != originalFirstName ||
                txtLastName.Text.Trim() != originalLastName ||
                txtMiddleInitial.Text.Trim() != originalMiddleInitial ||
                cmbSuffix.Text.Trim() != originalSuffix ||
                txtAddress.Text.Trim() != originalAddress ||
                txtContactNumber.Text.Trim() != originalContactNumber ||
                txtUsername.Text.Trim() != originalUsername)
            {
                return true;
            }

            return false;
        }

        private void btnSaveChanges_Click(object? sender, EventArgs e)
        {
            if (!profileLoaded)
            {
                MessageBox.Show("Your profile information has not loaded. Please return and try again.");
                return;
            }

            if (!HasProfileChanged())
            {
                MessageBox.Show("No profile changes were made.", "No Changes");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtContactNumber.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please fill in your first name, last name, address, contact number, and username.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text.Trim(), @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("First name must contain letters only.");
                txtFirstName.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text.Trim(), @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Last name must contain letters only.");
                txtLastName.Focus();
                return;
            }

            if (txtUsername.Text.Trim().Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters.");
                txtUsername.Focus();
                return;
            }

            if (txtFirstName.Text.Trim().Length > 50 || txtLastName.Text.Trim().Length > 50)
            {
                MessageBox.Show("First name and last name must be 50 characters or fewer.");
                return;
            }
            if (txtContactNumber.Text.Trim().Length > 20)
            {
                MessageBox.Show("Contact number must be 20 characters or fewer.");
                txtContactNumber.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length > 200)
            {
                MessageBox.Show("Address must be 200 characters or fewer.");
                txtAddress.Focus();
                return;
            }
            if (txtUsername.Text.Trim().Length > 50)
            {
                MessageBox.Show("Username must be 50 characters or fewer.");
                txtUsername.Focus();
                return;
            }

            string middleInitial = txtMiddleInitial.Text.Trim();
            if (middleInitial.Length > 0 &&
                !System.Text.RegularExpressions.Regex.IsMatch(middleInitial, @"^[a-zA-Z]$"))
            {
                MessageBox.Show("Middle initial must be one letter.");
                txtMiddleInitial.Focus();
                return;
            }
            string suffix = cmbSuffix.Text.Trim();
            if (suffix.Length > 0 &&
                !System.Text.RegularExpressions.Regex.IsMatch(suffix, @"^[a-zA-Z0-9. ]+$"))
            {
                MessageBox.Show("Suffix may contain letters, numbers, spaces, and periods only.");
                cmbSuffix.Focus();
                return;
            }
            if (suffix.Length > 10)
            {
                MessageBox.Show("Suffix must be 10 characters or fewer.");
                cmbSuffix.Focus();
                return;
            }

            DialogResult confirmation = MessageBox.Show("Save these changes to your profile?", "Confirm Profile Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM dbo.Residents WHERE Username = @Username AND ResidentID <> @ResidentID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        checkCommand.Parameters.AddWithValue("@ResidentID", residentID);

                        int usernameCount = (int)checkCommand.ExecuteScalar();
                        if (usernameCount > 0)
                        {
                            MessageBox.Show("That username is already in use.");
                            txtUsername.Focus();
                            return;
                        }
                    }

                    string contactCheckQuery = "SELECT COUNT(*) FROM dbo.Residents WHERE LTRIM(RTRIM(ContactNumber)) = @ContactNumber AND ResidentID <> @ResidentID";
                    using (SqlCommand contactCheckCommand = new SqlCommand(contactCheckQuery, connection))
                    {
                        contactCheckCommand.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim());
                        contactCheckCommand.Parameters.AddWithValue("@ResidentID", residentID);

                        int contactCount = (int)contactCheckCommand.ExecuteScalar();
                        if (contactCount > 0)
                        {
                            MessageBox.Show("That contact number is already in use.");
                            txtContactNumber.Focus();
                            return;
                        }
                    }

                    string fullName = txtFirstName.Text.Trim() + " ";
                    if (middleInitial.Length > 0)
                    {
                        fullName = fullName + middleInitial + ". ";
                    }
                    fullName = fullName + txtLastName.Text.Trim();
                    if (suffix.Length > 0)
                    {
                        fullName = fullName + " " + suffix;
                    }

                    if (fullName.Length > 100)
                    {
                        MessageBox.Show("The combined full name must be 100 characters or fewer.");
                        return;
                    }

                    string updateQuery = "UPDATE dbo.Residents SET FirstName = @FirstName, LastName = @LastName, MiddleInitial = @MiddleInitial, Suffix = @Suffix, FullName = @FullName, Address = @Address, ContactNumber = @ContactNumber, Username = @Username WHERE ResidentID = @ResidentID";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        updateCommand.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        updateCommand.Parameters.AddWithValue("@MiddleInitial", middleInitial);
                        updateCommand.Parameters.AddWithValue("@Suffix", suffix);
                        updateCommand.Parameters.AddWithValue("@FullName", fullName);
                        updateCommand.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        updateCommand.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim());
                        updateCommand.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        updateCommand.Parameters.AddWithValue("@ResidentID", residentID);
                        updateCommand.ExecuteNonQuery();
                    }

                    if (dashboardControl != null)
                    {
                        dashboardControl.UpdateResidentInformation(fullName, txtUsername.Text.Trim());
                    }
                }

                MessageBox.Show("Profile updated successfully.");
                if (dashboardControl != null)
                {
                    dashboardControl.ShowProfileControl();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update your profile: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (HasProfileChanged())
            {
                DialogResult result = MessageBox.Show("Discard your unsaved changes?","Cancel Editing", MessageBoxButtons.YesNo,MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            if (dashboardControl != null)
            {
                dashboardControl.ShowProfileControl();
            }
        }
    }
}
