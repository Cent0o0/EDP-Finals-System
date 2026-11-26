
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    public partial class ResidentReservationControl : UserControl
    {
        private string residentID;

        public ResidentReservationControl(string residentID)
        {
            InitializeComponent();

            this.residentID = residentID;

            LoadEquipment();
        }

        // LOAD EQUIPMENT FROM DATABASE
        private void LoadEquipment()
        {
            try
            {
                flpEquipmentContainer.Controls.Clear();

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT EquipmentID, EquipmentName, AvailableQuantity
                 FROM dbo.Equipment
                 WHERE IsActive = 1
                 ORDER BY EquipmentName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["EquipmentID"]);
                                string name = reader["EquipmentName"].ToString();
                                int available = Convert.ToInt32(reader["AvailableQuantity"]);

                                AddEquipmentCard(id, name, available);
                            }
                        }
                    }
                }

                if (flpEquipmentContainer.Controls.Count == 0)
                {
                    Label lblEmpty = new Label();
                    lblEmpty.Text = "No equipment is currently available.";
                    lblEmpty.AutoSize = true;
                    lblEmpty.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                    lblEmpty.ForeColor = Color.Gray;
                    lblEmpty.Padding = new Padding(10);

                    flpEquipmentContainer.Controls.Add(lblEmpty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load equipment: " + ex.Message);
            }
        }

        // CREATE EQUIPMENT CARD
        private void AddEquipmentCard(int equipmentID, string equipmentName, int available)
        {
            Panel card = new Panel();

            card.Width = 230;
            card.Height = 190;
            card.BackColor = Color.Gainsboro;
            card.Margin = new Padding(15);
            card.Padding = new Padding(5);

            Label lblName = new Label();
            lblName.Text = equipmentName;
            lblName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Dock = DockStyle.Top;
            lblName.Height = 40;

            Label lblQuantity = new Label();
            lblQuantity.Text = available.ToString();
            lblQuantity.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            lblQuantity.Dock = DockStyle.Top;
            lblQuantity.Height = 45;

            Label lblDescription = new Label();
            lblDescription.Text = "Available";
            lblDescription.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            lblDescription.Dock = DockStyle.Top;
            lblDescription.Height = 30;

            Button btnReserve = new Button();
            btnReserve.Text = "Reserve";
            btnReserve.BackColor = Color.FromArgb(22, 57, 89);
            btnReserve.ForeColor = Color.White;
            btnReserve.FlatStyle = FlatStyle.Flat;
            btnReserve.FlatAppearance.BorderSize = 0;
            btnReserve.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            btnReserve.Width = 160;
            btnReserve.Height = 30;
            btnReserve.Left = (card.Width - btnReserve.Width) / 2;
            btnReserve.Top = 135;

            btnReserve.Click += (sender, e) =>
            {
                OpenReservationForm(equipmentID);
            };

            card.Controls.Add(btnReserve);
            card.Controls.Add(lblDescription);
            card.Controls.Add(lblQuantity);
            card.Controls.Add(lblName);

            flpEquipmentContainer.Controls.Add(card);
        }

        // OPEN RESERVATION FORM
        private void OpenReservationForm(int equipmentID)
        {
            EquipmentReservationControl reservationForm =
                new EquipmentReservationControl(residentID, equipmentID);

            MainForm mainForm = FindForm() as MainForm;

            if (mainForm != null)
            {
                mainForm.ShowResidentDashboardContent(reservationForm);
            }
            else if (Parent != null)
            {
                reservationForm.Dock = DockStyle.Fill;
                Parent.Controls.Clear();
                Parent.Controls.Add(reservationForm);
            }
            else
            {
                MessageBox.Show("Unable to open the equipment reservation form.");
            }
        }
    }
}
