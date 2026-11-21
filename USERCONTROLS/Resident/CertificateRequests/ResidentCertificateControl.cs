using System;
using System.Windows.Forms;
using Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    public partial class ResidentCertificateControl : UserControl
    {
        private string residentID;
        public ResidentCertificateControl(string resident)
        {
            InitializeComponent();
            this.residentID = resident;
        }

        private void btnRequestClearance_Click(object sender, EventArgs e)
        {
            Barangay_E_Service_System.MainForm mainForm = this.FindForm() as Barangay_E_Service_System.MainForm;

            if (mainForm != null)
            {
                mainForm.ShowResidentDashboardContent(
                    new BarangayClearanceControl(residentID)
                );
            }
        }

        private void btnRequestResidency_Click(object sender, EventArgs e)
        {
            Barangay_E_Service_System.MainForm mainForm = this.FindForm() as Barangay_E_Service_System.MainForm;

            if (mainForm != null)
            {
                mainForm.ShowResidentDashboardContent(
                    new CertificateOfResidencyControl(residentID)
                );
            }
        }

        private void btnRequestIndigency_Click(object sender, EventArgs e)
        {
            Barangay_E_Service_System.MainForm mainForm = this.FindForm() as Barangay_E_Service_System.MainForm;

            if (mainForm != null)
            {
                mainForm.ShowResidentDashboardContent(
                    new CertificateOfIndigencyControl(residentID)
                );
            }
        }

        private void btnRequestGoodMoral_Click(object sender, EventArgs e)
        {
            Barangay_E_Service_System.MainForm mainForm = this.FindForm() as Barangay_E_Service_System.MainForm;

            if (mainForm != null)
            {
                mainForm.ShowResidentDashboardContent(
                    new CertificateOfGoodMoralCharacterControl(residentID)
                );
            }
        }

        private void btnRequestBusiness_Click(object sender, EventArgs e)
        {
            Barangay_E_Service_System.MainForm mainForm = this.FindForm() as Barangay_E_Service_System.MainForm;

            if (mainForm != null)
            {
                mainForm.ShowResidentDashboardContent(
                    new CertificateForBusinessControl(residentID)
                );
            }
        }

        private void btnRequestNoObjection_Click(object sender, EventArgs e)
        {
            Barangay_E_Service_System.MainForm mainForm = this.FindForm() as Barangay_E_Service_System.MainForm;

            if (mainForm != null)
            {
                mainForm.ShowResidentDashboardContent(
                    new CertificateOfNoObjectionControl(residentID)
                );
            }
        }
    }
}
