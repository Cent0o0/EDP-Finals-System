using Barangay_E_Service_System;
using Barangay_E_Service_System.DATA;
using Barangay_E_Service_System.DATA.Barangay_E_Service_System.DATA;
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
    public partial class ResidentLoginControl : UserControl
    {
        public ResidentLoginControl()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '●';
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validate empty fields users
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your username and password.", "Missing Information");
                return;
            }
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();


                    // Check Admin account first
                    string adminQuery = @"SELECT AdminID, Username FROM dbo.Admins WHERE Username = @Username AND PasswordHash = @Password AND IsActive = 1";
                    bool isAdmin;
                    int adminID = 0;
                    string adminUsername = "";

                    using (SqlCommand adminCmd = new SqlCommand(adminQuery, conn))
                    {
                        adminCmd.Parameters.AddWithValue("@Username", username);
                        adminCmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader adminReader = adminCmd.ExecuteReader())
                        {
                            isAdmin = adminReader.Read();

                            if (isAdmin)
                            {
                                adminID = Convert.ToInt32(adminReader["AdminID"]);
                                adminUsername = adminReader["Username"].ToString();
                            }
                        }
                    }

                    if (isAdmin)
                    {
                        UserSession.SetSession(adminID, adminUsername, "Administrator", UserRole.Admin);

                        MessageBox.Show("Admin login successful!");

                        MainForm main = (MainForm)this.FindForm();
                        main.ShowAdminDashboardControl();

                        return;
                    }

                    string query = "SELECT ResidentID, FullName, Username FROM dbo.Residents WHERE [Username] = @Username AND [PasswordHash] = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string residentID = Convert.ToInt32(reader["ResidentID"]).ToString();
                                string fullName = reader["FullName"].ToString();
                                string loggedInUsername = reader["Username"].ToString();
                                UserSession.SetSession(Convert.ToInt32(residentID), loggedInUsername, fullName, UserRole.Resident);

                                MessageBox.Show("Login successful!");
                                MainForm main = (MainForm)this.FindForm();
                                main.ShowResidentDashboardControl(residentID, fullName, loggedInUsername);
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password.", "Login Failed");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to log in. " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.ShowResidentLoginControl();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            MainForm main = (MainForm)this.FindForm();
            main.ShowResidentRegisterControl();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.ShowResidentForgotPasswordControl();
        }

        private void ResidentLoginControl_Load(object sender, EventArgs e)
        {

        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.ShowResidentForgotPasswordControl();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }
    }
}
