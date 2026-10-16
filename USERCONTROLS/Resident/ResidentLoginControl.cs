using Barangay_E_Service_System;
using Barangay_E_Service_System.DATA;
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
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.ShowResidentDashboardControl();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.ShowRoleSelection();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            MainForm main = (MainForm)this.FindForm();
            main.ShowResidentRegisterControl();
        }
    }
}