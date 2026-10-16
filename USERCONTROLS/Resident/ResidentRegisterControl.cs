using Barangay_E_Service_System;
using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    public partial class ResidentRegisterControl : UserControl
    {
        public ResidentRegisterControl()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.ShowResidentLoginControl();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check required fields
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text)  ||
                string.IsNullOrWhiteSpace(txtContact.Text)  ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtFullName.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Full name must contain letters only.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter your address."); txtAddress.Focus();
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtContact.Text, @"^09[0-9]{9}$"))
            {
                MessageBox.Show("Contact number must be 11 digits and start with 09."); txtContact.Focus();
                return;
            }
            if (txtUsername.Text.Trim().Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters."); txtUsername.Focus();
                return;
            }
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.");
                txtPassword.Focus();
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, @"[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Password must contain at least one symbol");txtPassword.Focus();
                return;
            }
            // Check passwords
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Check if username already exists
                    string checkQuery = "SELECT COUNT(*) FROM Residents WHERE Username = @Username";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists.");
                            return;
                        }
                    }
                    // Save the account
                    string insertQuery = @"INSERT INTO Residents(FullName, Address, ContactNumber, Username, PasswordHash)
                                         VALUES (@FullName, @Address, @ContactNumber, @Username, @PasswordHash)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@PasswordHash", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Account created successfully!");
                MainForm main = (MainForm)this.FindForm();
                main.ShowResidentLoginControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed: " + ex.Message);
            }
        }
    }
}
