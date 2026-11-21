using Barangay_E_Service_System.USERCONTROLS.Resident;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Font = new Font("Arial", 9.75F);
            ShowResidentLoginControl();
        }
        public void ShowResidentLogin()
        {
            ShowResidentLoginControl();
        }
        public void ShowResidentLoginControl()
        {
            pnlContent.Controls.Clear();

            ResidentLoginControl login = new ResidentLoginControl();
            login.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(login);
        }
        public void ShowResidentDashboardControl(string residentID, string fullName, string username)
        {
            pnlContent.Controls.Clear();

            ResidentDashboardControl residentDashboard = new ResidentDashboardControl(residentID, fullName, username);
            residentDashboard.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(residentDashboard);
        }
        public void ShowResidentRegisterControl()
        {
            pnlContent.Controls.Clear();

            ResidentRegisterControl residentRegister = new ResidentRegisterControl();
            residentRegister.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(residentRegister);
        }
        public void ShowControl(UserControl control)
        {
            pnlContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(control);
        }

        public void ShowResidentDashboardContent(UserControl control)
        {
            if (pnlContent.Controls.Count > 0 && pnlContent.Controls[0] is ResidentDashboardControl residentDashboard)
            {
                residentDashboard.ShowDashboardControl(control);
            }
            else
            {
                ShowControl(control);
            }
        }

    }
}

