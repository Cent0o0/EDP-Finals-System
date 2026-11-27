using Barangay_E_Service_System.DATA;
using Barangay_E_Service_System.DATA.Barangay_E_Service_System.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Admin
{
    public partial class AdminDashboardControl : UserControl
    {
        public AdminDashboardControl()
        {
            InitializeComponent();
            ShowDashboardContent();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardContent();
        }
        private void ShowDashboardContent()
        {
            pnlDashboardContent.Controls.Clear();
            AdminHomeContentControl homeP = new AdminHomeContentControl();
            homeP.Dock = DockStyle.Fill;
            pnlDashboardContent.Controls.Add(homeP);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                UserSession.ClearSession();

                MainForm main = (MainForm)this.FindForm();
                main.ShowResidentLoginControl();
            }
        }


        private void btnResident_Click(object sender, EventArgs e)
        {
            ShowResidentManagementControl();
        }
        private void ShowResidentManagementControl()
        {
            pnlDashboardContent.Controls.Clear();
            ResidentManagementControl residentManagement = new ResidentManagementControl();
            residentManagement.Dock = DockStyle.Fill;
            pnlDashboardContent.Controls.Add(residentManagement);
        }

        private void btnCertificate_Click(object sender, EventArgs e)
        {
            ShowCertificateManagementControl();
        }
        private void ShowCertificateManagementControl()
        {
            pnlDashboardContent.Controls.Clear();
            AdminAllActivitiesControl certificateManagement = new AdminAllActivitiesControl();
            certificateManagement.Dock = DockStyle.Fill;
            pnlDashboardContent.Controls.Add(certificateManagement);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ShowReservationManagementControl();
        }
        private void ShowReservationManagementControl()
        {
            pnlDashboardContent.Controls.Clear();
            EquipmentReservationManagementControl reservationManagement = new EquipmentReservationManagementControl();
            reservationManagement.Dock = DockStyle.Fill;
            pnlDashboardContent.Controls.Add(reservationManagement);
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
