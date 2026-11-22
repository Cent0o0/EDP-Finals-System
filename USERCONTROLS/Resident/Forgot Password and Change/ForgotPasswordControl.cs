using Barangay_E_Service_System;
using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    public partial class ForgotPasswordControl : UserControl
    {
        public ForgotPasswordControl()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(contactNumber))
            {
                MessageBox.Show("Enter your username and contact number.", "Missing Information");
                return;
            }

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT ResidentID FROM dbo.Residents WHERE Username = @Username AND ContactNumber = @ContactNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);

                        object residentIDValue = command.ExecuteScalar();
                        if (residentIDValue == null || residentIDValue == DBNull.Value)
                        {
                            MessageBox.Show("The username or contact number does not match our records.", "Account Not Found");
                            return;
                        }

                        string residentID = Convert.ToInt32(residentIDValue).ToString();
                        MainForm main = (MainForm)this.FindForm();
                        main.ShowResidentChangePasswordControl(residentID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not verify your account. " + ex.Message, "Password Recovery");
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.ShowResidentLoginControl();
        }
    }
}
