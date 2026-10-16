using Barangay_E_Service_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Admin
{
    public partial class AdminLoginControl : UserControl
    {
        public AdminLoginControl()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.FindForm();
            main.ShowRoleSelection();
        }
    }
}
