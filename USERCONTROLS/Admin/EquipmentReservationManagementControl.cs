using System;
using System.Data;
using System.Windows.Forms;
using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;

namespace Barangay_E_Service_System.USERCONTROLS.Admin
{
    public partial class EquipmentReservationManagementControl : UserControl
    {
        int selectedEquipmentID = 0;

        public EquipmentReservationManagementControl()
        {
            InitializeComponent();
            dgvEquipment.AutoGenerateColumns = false;
            LoadEquipment();
        }


        private void LoadEquipment()
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT
                    EquipmentID,
                    EquipmentName,
                    TotalQuantity,
                    AvailableQuantity,
                    IsActive,
                    CASE
                        WHEN IsActive = 1 THEN 'Available'
                        ELSE 'Not Available'
                    END AS Status
                FROM dbo.Equipment
                ORDER BY EquipmentName";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvEquipment.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load equipment: " + ex.Message);
            }
        }

        private void btnAddEquipment_Click_1(object sender, EventArgs e)
        {
            selectedEquipmentID = 0;

            txtEquipmentName.Clear();
            txtTotalQuantity.Clear();
            cmbStatus.SelectedIndex = -1;

            lblEquipmentFormTitle.Text = "Add Equipment";
            btnSaveEquipment.Text = "Save Equipment";

            pnlEquipmentForm.Visible = true;
            pnlEquipmentForm.BringToFront();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel? Any unsaved changes will be lost.", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                txtEquipmentName.Clear();
                txtTotalQuantity.Clear();
                cmbStatus.SelectedIndex = -1;

                selectedEquipmentID = 0;
                pnlEquipmentForm.Visible = false;
            }
        }
        private void btnSaveEquipment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipmentName.Text))
            {
                MessageBox.Show("Please enter the equipment name.");
                txtEquipmentName.Focus();
                return;
            }

            int totalQuantity;

            if (!int.TryParse(txtTotalQuantity.Text, out totalQuantity) || totalQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                txtTotalQuantity.Focus();
                return;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the equipment availability.");
                cmbStatus.Focus();
                return;
            }

            bool isActive = cmbStatus.SelectedItem.ToString() == "Available";
            bool isAdding = selectedEquipmentID == 0;

            DialogResult result = MessageBox.Show(
                isAdding ? "Are you sure you want to add this equipment?" : "Are you sure you want to update this equipment?",
                "Confirm Equipment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    if (isAdding)
                    {
                        string query = @"
                    INSERT INTO dbo.Equipment
                    (EquipmentName, TotalQuantity, AvailableQuantity, IsActive)
                    VALUES
                    (@EquipmentName, @TotalQuantity, @AvailableQuantity, @IsActive)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EquipmentName", txtEquipmentName.Text.Trim());
                            command.Parameters.AddWithValue("@TotalQuantity", totalQuantity);
                            command.Parameters.AddWithValue("@AvailableQuantity", totalQuantity);
                            command.Parameters.AddWithValue("@IsActive", isActive);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Equipment added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = @"
    UPDATE dbo.Equipment
    SET EquipmentName = @EquipmentName,
        AvailableQuantity = AvailableQuantity + (@TotalQuantity - TotalQuantity),
        TotalQuantity = @TotalQuantity,
        IsActive = @IsActive
    WHERE EquipmentID = @EquipmentID
    AND @TotalQuantity >= TotalQuantity - AvailableQuantity";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EquipmentName", txtEquipmentName.Text.Trim());
                            command.Parameters.AddWithValue("@TotalQuantity", totalQuantity);
                            command.Parameters.AddWithValue("@IsActive", isActive);
                            command.Parameters.AddWithValue("@EquipmentID", selectedEquipmentID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Unable to update equipment. The new total quantity cannot be lower than the quantity already reserved.","Update Equipment",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        MessageBox.Show("Equipment updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                txtEquipmentName.Clear();
                txtTotalQuantity.Clear();
                cmbStatus.SelectedIndex = -1;

                selectedEquipmentID = 0;
                pnlEquipmentForm.Visible = false;

                LoadEquipment();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save equipment: " + ex.Message,"Equipment Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearchEquipment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT EquipmentID,EquipmentName, TotalQuantity,AvailableQuantity, IsActive,CASE WHEN IsActive = 1 THEN 'Available' ELSE 'Not Available' END AS Status FROM dbo.Equipment WHERE EquipmentName LIKE @Search ORDER BY EquipmentName";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Search", "%" + txtSearchEquipment.Text.Trim() + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    dgvEquipment.DataSource = dt;

                    dgvEquipment.Columns["EquipmentID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to search equipment: " + ex.Message);
            }
        }



        private void dgvEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvEquipment.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                DataGridViewRow row = dgvEquipment.Rows[e.RowIndex];

                selectedEquipmentID = Convert.ToInt32(row.Cells["EquipmentID"].Value);

                txtEquipmentName.Text = row.Cells["EquipmentName"].Value.ToString();
                txtTotalQuantity.Text = row.Cells["TotalQuantity"].Value.ToString();

                cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();

                lblEquipmentFormTitle.Text = "Edit Equipment";
                btnSaveEquipment.Text = "Update Equipment";

                pnlEquipmentForm.Visible = true;
                pnlEquipmentForm.BringToFront();
            }
            else if (dgvEquipment.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                int equipmentID = Convert.ToInt32(
                    dgvEquipment.Rows[e.RowIndex].Cells["EquipmentID"].Value);

                string equipmentName = dgvEquipment.Rows[e.RowIndex]
                    .Cells["EquipmentName"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete " + equipmentName + "?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result != DialogResult.Yes)
                    return;

                try
                {
                    using (SqlConnection connection = DatabaseConnection.GetConnection())
                    {
                        connection.Open();

                        string query = @"
                    DELETE FROM dbo.Equipment
                    WHERE EquipmentID = @EquipmentID
                    AND NOT EXISTS (
                        SELECT 1
                        FROM dbo.EquipmentReservations
                        WHERE EquipmentID = @EquipmentID
                    )";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EquipmentID", equipmentID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected == 0)
                            {
                                MessageBox.Show(
                                    "This equipment cannot be deleted because it has existing reservation records.",
                                    "Delete Equipment",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    if (selectedEquipmentID == equipmentID)
                    {
                        selectedEquipmentID = 0;
                        pnlEquipmentForm.Visible = false;
                    }

                    MessageBox.Show("Equipment deleted successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadEquipment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete equipment: " + ex.Message,"Delete Equipment",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

    }

}
