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
    public partial class ResidentDashboardControl : UserControl
    {
        private string residentID;
        public ResidentDashboardControl(string residentID, string fullName, string username)
        {
            InitializeComponent();
            this.residentID = residentID;
            ShowDashboardContent();
            lblResidentName.Text = fullName;
            lblResidentUsername.Text = "@" + username;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlDashboardContent.Controls.Clear();
            ResidentHomeContentControl homepage = new ResidentHomeContentControl(residentID);

            homepage.Dock = DockStyle.Fill;
            pnlDashboardContent.Controls.Add(homepage);
        }

        private void btnCertificate_Click(object sender, EventArgs e)
        {
            ResidentCertificateControl certificatePage = new ResidentCertificateControl(residentID);
            certificatePage.Dock = DockStyle.Fill;

            pnlDashboardContent.Controls.Clear();
            pnlDashboardContent.Controls.Add(certificatePage);

        }

        private void ShowDashboardContent()
        {
            pnlDashboardContent.Controls.Clear();
            ResidentHomeContentControl homeP = new ResidentHomeContentControl(residentID);

            homeP.Dock = DockStyle.Fill;
            pnlDashboardContent.Controls.Add(homeP);
        }

        public void ShowDashboardControl(UserControl control)
        {
            pnlDashboardContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlDashboardContent.Controls.Add(control);
        }

        public void UpdateResidentInformation(string fullName, string username)
        {
            lblResidentName.Text = fullName;
            lblResidentUsername.Text = "@" + username;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowProfileControl();
        }

        public void ShowProfileControl()
        {
            ResidentProfileControl profilePage = new ResidentProfileControl(residentID, this);
            ShowDashboardControl(profilePage);
        }

        public void ShowEditProfileControl()
        {
            ResidentEditProfileControl editProfilePage = new ResidentEditProfileControl(residentID, this);
            ShowDashboardControl(editProfilePage);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            pnlDashboardContent.Controls.Clear();

            ResidentReservationControl reservationPage =
                new ResidentReservationControl(residentID);

            reservationPage.Dock = DockStyle.Fill;
            pnlDashboardContent.Controls.Add(reservationPage);
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            pnlDashboardContent.Controls.Clear();
            ResidentComplaintControl residentComplaintControl = new ResidentComplaintControl(residentID);

            residentComplaintControl.Dock = DockStyle.Fill;
            pnlDashboardContent.Controls.Add(residentComplaintControl);
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

    }
}
