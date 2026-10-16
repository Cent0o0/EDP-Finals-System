using Barangay_E_Service_System.USERCONTROLS.Admin;
using Barangay_E_Service_System.USERCONTROLS.Resident;
using Barangay_E_Service_System.USERCONTROLS.Shared;
using System;
using System.Windows.Forms;

namespace Barangay_E_Service_System
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowRoleSelection();
        }
        public void ShowRoleSelection()
        {
            pnlContent.Controls.Clear();

            RoleSelectionControl roleControl = new RoleSelectionControl();
            roleControl.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(roleControl);
        }
        public void ShowResidentLogin()
        {
            pnlContent.Controls.Clear();

            ResidentLoginControl residentLogin = new ResidentLoginControl();
            residentLogin.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(residentLogin);
        }
        public void ShowAdminLogin()
        {
            pnlContent.Controls.Clear();

            AdminLoginControl adminLogin = new AdminLoginControl();
            adminLogin.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(adminLogin);
        }
        public void ShowResidentLoginControl()
        {
            pnlContent.Controls.Clear();

            ResidentLoginControl login = new ResidentLoginControl();
            login.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(login);
        }
        public void ShowResidentDashboardControl()
        {
            pnlContent.Controls.Clear();

            ResidentDashboardControl residentDashboard = new ResidentDashboardControl();
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
    }
}

