using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Barangay_E_Service_System.USERCONTROLS.Resident;
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
        private void LoadEquipment()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT EquipmentID, EquipmentName, AvailableQuantity FROM dbo.Equipment WHERE IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["EquipmentID"]);
                            string name = reader["EquipmentName"].ToString();
                            int available = Convert.ToInt32(reader["AvailableQuantity"]);

                            if (id == 1)
                            {
                                lblChairsAvailable.Text = available.ToString();
                            }
                            else if (id == 2)
                            {
                                lblTableAvailable.Text = available.ToString();
                            }
                            else if (id == 3)
                            {
                                lblTentAvailable.Text = available.ToString();
                            }
                        }
                    }
                }
            }
        }

        private void btnReserveChairs_Click(object sender, EventArgs e)
        {
            OpenReservationForm(1);
        }

        private void btnReserveTable_Click(object sender, EventArgs e)
        {
            OpenReservationForm(2);
        }

        private void btnReserveTent_Click(object sender, EventArgs e)
        {
            OpenReservationForm(3);
        }

        private void OpenReservationForm(int equipmentID)
        {
            EquipmentReservationControl reservationForm = new EquipmentReservationControl(residentID, equipmentID);
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
