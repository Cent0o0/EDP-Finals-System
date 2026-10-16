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
        public ResidentDashboardControl()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlDashboardContent.Controls.Clear();
        }
    }
}
