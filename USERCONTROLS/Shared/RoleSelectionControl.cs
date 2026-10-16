using Barangay_E_Service_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Shared
{
    public partial class RoleSelectionControl : UserControl
    {
        public RoleSelectionControl()
        {
            InitializeComponent();
        }

        private void RoleSelectionControl_Load(object sender, EventArgs e)
        {

        }
        private void btnResident_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is MainForm main)
            {
                main.ShowResidentLogin();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is MainForm main)
            {
                main.ShowAdminLogin();
            }
        }
    }
}
