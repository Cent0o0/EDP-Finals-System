using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;
using Barangay_E_Service_System.DATA;
using System;

namespace Barangay_E_Service_System.USERCONTROLS.Admin
{
    public partial class ResidentManagementControl : UserControl
    {
        public ResidentManagementControl()
        {
            InitializeComponent();
            LoadResidents();
        }
        private void LoadResidents(string searchTerm = "")
        {
            try
            {

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT ResidentID,FullName,Username, ContactNumber, Address, CreatedAt AS RegistrationDate FROM dbo.Residents WHERE CAST(ResidentID AS VARCHAR(50)) LIKE @SearchTerm OR FullName LIKE @SearchTerm OR Username LIKE @SearchTerm OR ContactNumber LIKE @SearchTerm ORDER BY CreatedAt DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            adapter.Fill(dt);

                            dgvResidents.DataSource = dt;
                            lblNoResults.Visible = dt.Rows.Count == 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load resident records.\n" + ex.Message,
                    "Resident Management",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvResidents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvResidents.Columns[e.ColumnIndex].Name == "btnView")
            {
                string residentID = dgvResidents.Rows[e.RowIndex].Cells["ResidentID"].Value?.ToString();

                string fullName = dgvResidents.Rows[e.RowIndex].Cells["FullName"].Value?.ToString();

                string username = dgvResidents.Rows[e.RowIndex].Cells["Username"].Value?.ToString();

                string contact = dgvResidents.Rows[e.RowIndex].Cells["ContactNumber"].Value?.ToString();

                string address = dgvResidents.Rows[e.RowIndex].Cells["Address"].Value?.ToString();

                string dateRegistered = dgvResidents.Rows[e.RowIndex].Cells["RegistrationDate"].Value?.ToString();

                MessageBox.Show($"Resident ID: {residentID}\n" + $"Full Name: {fullName}\n" + $"Username: {username}\n" + $"Contact Number: {contact}\n" + $"Address: {address}\n" + $"Date Registered: {dateRegistered}", "Resident Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadResidents();
        }

        private void txtSearchResident_TextChanged(object sender, EventArgs e)
        {
            LoadResidents(txtSearchResident.Text.Trim());
        }
    }
}
