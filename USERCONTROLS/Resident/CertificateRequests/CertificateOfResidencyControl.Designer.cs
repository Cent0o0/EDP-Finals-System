using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    partial class CertificateOfResidencyControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateStartedResiding;
        private DateTimePicker dtpDateStartedResiding;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPurpose;
        private ComboBox cmbPurpose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOtherPurpose;
        private Guna.UI2.WinForms.Guna2TextBox txtOtherPurpose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAdditionalRemarks;
        private Guna.UI2.WinForms.Guna2TextBox txtAdditionalRemarks;
        private Guna.UI2.WinForms.Guna2Button btnSubmitRequest;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Panel();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblFullName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            lblDateStartedResiding = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtpDateStartedResiding = new DateTimePicker();
            lblPurpose = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbPurpose = new ComboBox();
            lblOtherPurpose = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtOtherPurpose = new Guna.UI2.WinForms.Guna2TextBox();
            lblAdditionalRemarks = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtAdditionalRemarks = new Guna.UI2.WinForms.Guna2TextBox();
            btnSubmitRequest = new Guna.UI2.WinForms.Guna2Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(234, 245, 245);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(871, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(316, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Certificate of Residency";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F);
            lblSubtitle.Location = new Point(22, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(365, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Review your name and complete the residency request details.";
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblFullName.Location = new Point(54, 108);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(68, 17);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.BorderColor = Color.Black;
            txtFullName.BorderRadius = 5;
            txtFullName.CustomizableEdges = customizableEdges1;
            txtFullName.DefaultText = "";
            txtFullName.FillColor = Color.FromArgb(245, 245, 245);
            txtFullName.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtFullName.ForeColor = Color.Black;
            txtFullName.Location = new Point(57, 130);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "";
            txtFullName.ReadOnly = true;
            txtFullName.SelectedText = "";
            txtFullName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtFullName.Size = new Size(756, 36);
            txtFullName.TabIndex = 2;
            txtFullName.TabStop = false;
            // 
            // lblDateStartedResiding
            // 
            lblDateStartedResiding.BackColor = Color.Transparent;
            lblDateStartedResiding.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblDateStartedResiding.Location = new Point(54, 184);
            lblDateStartedResiding.Name = "lblDateStartedResiding";
            lblDateStartedResiding.Size = new Size(145, 17);
            lblDateStartedResiding.TabIndex = 3;
            lblDateStartedResiding.Text = "Date Started Residing";
            // 
            // dtpDateStartedResiding
            // 
            dtpDateStartedResiding.Checked = false;
            dtpDateStartedResiding.Font = new Font("Arial Rounded MT Bold", 9.75F);
            dtpDateStartedResiding.Format = DateTimePickerFormat.Short;
            dtpDateStartedResiding.Location = new Point(57, 206);
            dtpDateStartedResiding.MaxDate = new DateTime(2026, 11, 26, 0, 0, 0, 0);
            dtpDateStartedResiding.Name = "dtpDateStartedResiding";
            dtpDateStartedResiding.ShowCheckBox = true;
            dtpDateStartedResiding.Size = new Size(350, 23);
            dtpDateStartedResiding.TabIndex = 0;
            dtpDateStartedResiding.Value = new DateTime(2026, 11, 26, 0, 0, 0, 0);
            // 
            // lblPurpose
            // 
            lblPurpose.BackColor = Color.Transparent;
            lblPurpose.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblPurpose.Location = new Point(54, 252);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(128, 17);
            lblPurpose.TabIndex = 4;
            lblPurpose.Text = "Purpose of Request";
            // 
            // cmbPurpose
            // 
            cmbPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPurpose.Font = new Font("Arial Rounded MT Bold", 9.75F);
            cmbPurpose.FormattingEnabled = true;
            cmbPurpose.Items.AddRange(new object[] { "Employment", "Pre-employment", "Bank Account Opening", "Loan Application", "Scholarship Application", "Police Clearance Requirement", "BIR Requirement", "Business Requirement", "Utility Connection", "Legal Purposes", "Government Transaction", "Personal Use", "Other" });
            cmbPurpose.Location = new Point(57, 274);
            cmbPurpose.Name = "cmbPurpose";
            cmbPurpose.Size = new Size(350, 23);
            cmbPurpose.TabIndex = 1;
            cmbPurpose.SelectedIndexChanged += cmbPurpose_SelectedIndexChanged;
            // 
            // lblOtherPurpose
            // 
            lblOtherPurpose.BackColor = Color.Transparent;
            lblOtherPurpose.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblOtherPurpose.Location = new Point(54, 320);
            lblOtherPurpose.Name = "lblOtherPurpose";
            lblOtherPurpose.Size = new Size(97, 17);
            lblOtherPurpose.TabIndex = 5;
            lblOtherPurpose.Text = "Other Purpose";
            lblOtherPurpose.Visible = false;
            // 
            // txtOtherPurpose
            // 
            txtOtherPurpose.BorderColor = Color.Black;
            txtOtherPurpose.BorderRadius = 5;
            txtOtherPurpose.CustomizableEdges = customizableEdges3;
            txtOtherPurpose.DefaultText = "";
            txtOtherPurpose.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtOtherPurpose.ForeColor = Color.Black;
            txtOtherPurpose.Location = new Point(57, 342);
            txtOtherPurpose.MaxLength = 200;
            txtOtherPurpose.Name = "txtOtherPurpose";
            txtOtherPurpose.PlaceholderText = "";
            txtOtherPurpose.SelectedText = "";
            txtOtherPurpose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtOtherPurpose.Size = new Size(350, 36);
            txtOtherPurpose.TabIndex = 2;
            txtOtherPurpose.Visible = false;
            // 
            // lblAdditionalRemarks
            // 
            lblAdditionalRemarks.BackColor = Color.Transparent;
            lblAdditionalRemarks.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblAdditionalRemarks.Location = new Point(54, 396);
            lblAdditionalRemarks.Name = "lblAdditionalRemarks";
            lblAdditionalRemarks.Size = new Size(129, 17);
            lblAdditionalRemarks.TabIndex = 6;
            lblAdditionalRemarks.Text = "Additional Remarks";
            // 
            // txtAdditionalRemarks
            // 
            txtAdditionalRemarks.BorderColor = Color.Black;
            txtAdditionalRemarks.BorderRadius = 5;
            txtAdditionalRemarks.CustomizableEdges = customizableEdges5;
            txtAdditionalRemarks.DefaultText = "";
            txtAdditionalRemarks.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtAdditionalRemarks.ForeColor = Color.Black;
            txtAdditionalRemarks.Location = new Point(57, 418);
            txtAdditionalRemarks.MaxLength = 1000;
            txtAdditionalRemarks.Multiline = true;
            txtAdditionalRemarks.Name = "txtAdditionalRemarks";
            txtAdditionalRemarks.PlaceholderText = "";
            txtAdditionalRemarks.SelectedText = "";
            txtAdditionalRemarks.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtAdditionalRemarks.Size = new Size(756, 80);
            txtAdditionalRemarks.TabIndex = 3;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitRequest.BorderRadius = 5;
            btnSubmitRequest.CustomizableEdges = customizableEdges7;
            btnSubmitRequest.FillColor = Color.FromArgb(18, 52, 86);
            btnSubmitRequest.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnSubmitRequest.ForeColor = Color.White;
            btnSubmitRequest.Location = new Point(592, 560);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSubmitRequest.Size = new Size(225, 42);
            btnSubmitRequest.TabIndex = 4;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // CertificateOfResidencyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 590);
            BackColor = Color.White;
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblDateStartedResiding);
            Controls.Add(dtpDateStartedResiding);
            Controls.Add(lblPurpose);
            Controls.Add(cmbPurpose);
            Controls.Add(lblOtherPurpose);
            Controls.Add(txtOtherPurpose);
            Controls.Add(lblAdditionalRemarks);
            Controls.Add(txtAdditionalRemarks);
            Controls.Add(btnSubmitRequest);
            Controls.Add(pnlHeader);
            Name = "CertificateOfResidencyControl";
            Size = new Size(871, 650);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
