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
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtContactNumber.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
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
                MessageBox.Show("Password must contain at least one symbol"); txtPassword.Focus();
                return;
            }
            // Check passwords
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            string username = txtUsername.Text.Trim();

            if (firstName.Length > 50 || lastName.Length > 50)
            {
                MessageBox.Show("First name and last name must be 50 characters or fewer.");
                return;
            }
            if (contactNumber.Length > 20)
            {
                MessageBox.Show("Contact number must be 20 characters or fewer.");
                txtContactNumber.Focus();
                return;
            }
            if (address.Length > 200)
            {
                MessageBox.Show("Address must be 200 characters or fewer.");
                txtAddress.Focus();
                return;
            }
            if (username.Length > 50)
            {
                MessageBox.Show("Username must be 50 characters or fewer.");
                txtUsername.Focus();
                return;
            }
            if (suffix.Length > 10)
            {
                MessageBox.Show("Suffix must be 10 characters or fewer.");
                cmbSuffix.Focus();
                return;
            }

            string fullName = firstName + " ";
            if (middleInitial.Length > 0)
            {
                fullName = fullName + middleInitial + ". ";
            }
            fullName = fullName + lastName;
            if (suffix.Length > 0)
            {
                fullName = fullName + " " + suffix;
            }
            if (fullName.Length > 100)
            {
                MessageBox.Show("The combined full name must be 100 characters or fewer.");
                return;
            }
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Check if username already exists
                    string checkQuery = "SELECT COUNT(*) FROM dbo.Residents WHERE Username = @Username";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists.");
                            return;
                        }
                    }
                    // Save the account
                    string insertQuery = @"SET XACT_ABORT ON;
                                           BEGIN TRANSACTION;

                                           DECLARE @NextResidentNumber INT;
                                           SELECT @NextResidentNumber = ISNULL(MAX(TRY_CONVERT(INT, SUBSTRING(ResidentID, 9, 20))), 0) + 1
                                           FROM dbo.Residents WITH (UPDLOCK, HOLDLOCK);

                                           DECLARE @ResidentID NVARCHAR(20);
                                           SET @ResidentID = N'BRG-RES-' + RIGHT(N'00' + CONVERT(NVARCHAR(20), @NextResidentNumber), 2);

                                           INSERT INTO dbo.Residents (ResidentID, FullName, FirstName, LastName, MiddleInitial, Suffix, Address, ContactNumber, Username, PasswordHash)
                                           VALUES (@ResidentID, @FullName, @FirstName, @LastName, @MiddleInitial, @Suffix, @Address, @ContactNumber, @Username, @PasswordHash);

                                           COMMIT TRANSACTION;";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@MiddleInitial", middleInitial);
                        cmd.Parameters.AddWithValue("@Suffix", suffix);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Username", username);
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

        private void ResidentRegisterControl_Load(object sender, EventArgs e)
        {

        }
    }
}
