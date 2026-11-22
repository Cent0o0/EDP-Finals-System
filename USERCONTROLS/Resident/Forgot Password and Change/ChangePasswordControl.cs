using Barangay_E_Service_System;
using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    public partial class ChangePasswordControl : UserControl
    {
        private string residentID = "";

        public ChangePasswordControl()
        {
            InitializeComponent();
        }

        public ChangePasswordControl(string residentID)
        {
            InitializeComponent();
            this.residentID = residentID;
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Enter and confirm your new password.", "Missing Information");
                return;
            }

            if (newPassword.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Invalid Password");
                txtNewPassword.Focus();
                return;
            }

            if (!Regex.IsMatch(newPassword, "[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Password must contain at least one symbol.", "Invalid Password");
                txtNewPassword.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Password Mismatch");
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "UPDATE dbo.Residents SET PasswordHash = @PasswordHash WHERE ResidentID = @ResidentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PasswordHash", newPassword);
                        command.Parameters.AddWithValue("@ResidentID", residentID);
                        int updatedResidents = command.ExecuteNonQuery();

                        if (updatedResidents != 1)
                        {
                            MessageBox.Show("The account could not be found. Please start password recovery again.", "Account Not Found");
                            return;
                        }
                    }
                }

                MessageBox.Show("Your password has been changed. You can now log in with your new password.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm main = (MainForm)this.FindForm();
                main.ShowResidentLoginControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not change your password. " + ex.Message, "Password Change");
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.ShowResidentLoginControl();
        }
    }
}
