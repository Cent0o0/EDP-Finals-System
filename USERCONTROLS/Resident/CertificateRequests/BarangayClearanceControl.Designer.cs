using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    partial class BarangayClearanceControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblApplicantInformation;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContactNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtContactNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRequestDetails;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Panel();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblApplicantInformation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblFullName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            lblContactNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            lblRequestDetails = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            pnlHeader.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(267, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Barangay Clearance";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F);
            lblSubtitle.Location = new Point(22, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(344, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Review your information and provide the clearance purpose.";
            // 
            // lblApplicantInformation
            // 
            lblApplicantInformation.BackColor = Color.Transparent;
            lblApplicantInformation.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblApplicantInformation.ForeColor = Color.Black;
            lblApplicantInformation.Location = new Point(30, 100);
            lblApplicantInformation.Name = "lblApplicantInformation";
            lblApplicantInformation.Size = new Size(166, 21);
            lblApplicantInformation.TabIndex = 1;
            lblApplicantInformation.Text = "Applicant Information";
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblFullName.Location = new Point(54, 136);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(75, 18);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.BorderColor = Color.Black;
            txtFullName.BorderRadius = 5;
            txtFullName.CustomizableEdges = customizableEdges1;
            txtFullName.DefaultText = "";
            txtFullName.FillColor = Color.FromArgb(245, 245, 245);
            txtFullName.Font = new Font("Arial", 10F);
            txtFullName.ForeColor = Color.Black;
            txtFullName.Location = new Point(57, 158);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "";
            txtFullName.ReadOnly = true;
            txtFullName.SelectedText = "";
            txtFullName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtFullName.Size = new Size(756, 36);
            txtFullName.TabIndex = 1;
            txtFullName.TabStop = false;
            // 
            // lblAddress
            // 
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(54, 204);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(118, 18);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Complete Address";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.BorderColor = Color.Black;
            txtAddress.BorderRadius = 5;
            txtAddress.CustomizableEdges = customizableEdges9;
            txtAddress.DefaultText = "";
            txtAddress.FillColor = Color.FromArgb(245, 245, 245);
            txtAddress.Font = new Font("Arial", 10F);
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(57, 226);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "";
            txtAddress.ReadOnly = true;
            txtAddress.SelectedText = "";
            txtAddress.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtAddress.Size = new Size(756, 36);
            txtAddress.TabIndex = 9;
            txtAddress.TabStop = false;
            // 
            // lblContactNumber
            // 
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactNumber.Location = new Point(54, 272);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(105, 18);
            lblContactNumber.TabIndex = 10;
            lblContactNumber.Text = "Contact Number";
            // 
            // txtContactNumber
            // 
            txtContactNumber.BorderColor = Color.Black;
            txtContactNumber.BorderRadius = 5;
            txtContactNumber.CustomizableEdges = customizableEdges11;
            txtContactNumber.DefaultText = "";
            txtContactNumber.FillColor = Color.FromArgb(245, 245, 245);
            txtContactNumber.Font = new Font("Arial", 10F);
            txtContactNumber.ForeColor = Color.Black;
            txtContactNumber.Location = new Point(57, 294);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PlaceholderText = "";
            txtContactNumber.ReadOnly = true;
            txtContactNumber.SelectedText = "";
            txtContactNumber.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtContactNumber.Size = new Size(350, 36);
            txtContactNumber.TabIndex = 11;
            txtContactNumber.TabStop = false;
            // 
            // lblRequestDetails
            // 
            lblRequestDetails.BackColor = Color.Transparent;
            lblRequestDetails.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblRequestDetails.ForeColor = Color.Black;
            lblRequestDetails.Location = new Point(30, 350);
            lblRequestDetails.Name = "lblRequestDetails";
            lblRequestDetails.Size = new Size(148, 21);
            lblRequestDetails.TabIndex = 12;
            lblRequestDetails.Text = "Clearance Request";
            // 
            // lblPurpose
            // 
            lblPurpose.BackColor = Color.Transparent;
            lblPurpose.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPurpose.Location = new Point(54, 386);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(140, 18);
            lblPurpose.TabIndex = 0;
            lblPurpose.Text = "Purpose of Clearance ";
            // 
            // cmbPurpose
            // 
            cmbPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPurpose.Font = new Font("Arial", 10F);
            cmbPurpose.FormattingEnabled = true;
            cmbPurpose.Items.AddRange(new object[] { "Employment", "Pre-employment", "Bank Account Opening", "Loan Application", "Scholarship Application", "Police Clearance Requirement", "BIR Requirement", "Business Requirement", "Utility Connection", "Legal Purposes", "Government Transaction", "Personal Use", "Other" });
            cmbPurpose.Location = new Point(57, 408);
            cmbPurpose.Name = "cmbPurpose";
            cmbPurpose.Size = new Size(350, 24);
            cmbPurpose.TabIndex = 1;
            cmbPurpose.SelectedIndexChanged += cmbPurpose_SelectedIndexChanged;

            lblOtherPurpose.BackColor = Color.Transparent;
            lblOtherPurpose.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblOtherPurpose.Location = new Point(54, 454);
            lblOtherPurpose.Name = "lblOtherPurpose";
            lblOtherPurpose.Size = new Size(83, 18);
            lblOtherPurpose.TabIndex = 2;
            lblOtherPurpose.Text = "Other Purpose";
            lblOtherPurpose.Visible = false;

            txtOtherPurpose.BorderColor = Color.Black;
            txtOtherPurpose.BorderRadius = 5;
            txtOtherPurpose.DefaultText = "";
            txtOtherPurpose.Font = new Font("Arial", 10F);
            txtOtherPurpose.ForeColor = Color.Black;
            txtOtherPurpose.Location = new Point(57, 476);
            txtOtherPurpose.MaxLength = 200;
            txtOtherPurpose.Name = "txtOtherPurpose";
            txtOtherPurpose.PlaceholderText = "";
            txtOtherPurpose.SelectedText = "";
            txtOtherPurpose.Size = new Size(350, 36);
            txtOtherPurpose.TabIndex = 3;
            txtOtherPurpose.Visible = false;
            // 
            // lblAdditionalRemarks
            // 
            lblAdditionalRemarks.BackColor = Color.Transparent;
            lblAdditionalRemarks.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdditionalRemarks.Location = new Point(54, 522);
            lblAdditionalRemarks.Name = "lblAdditionalRemarks";
            lblAdditionalRemarks.Size = new Size(127, 18);
            lblAdditionalRemarks.TabIndex = 4;
            lblAdditionalRemarks.Text = "Additional Remarks ";
            // 
            // txtAdditionalRemarks
            // 
            txtAdditionalRemarks.BorderColor = Color.Black;
            txtAdditionalRemarks.BorderRadius = 5;
            txtAdditionalRemarks.CustomizableEdges = customizableEdges13;
            txtAdditionalRemarks.DefaultText = "";
            txtAdditionalRemarks.Font = new Font("Arial", 10F);
            txtAdditionalRemarks.ForeColor = Color.Black;
            txtAdditionalRemarks.Location = new Point(57, 544);
            txtAdditionalRemarks.MaxLength = 1000;
            txtAdditionalRemarks.Multiline = true;
            txtAdditionalRemarks.Name = "txtAdditionalRemarks";
            txtAdditionalRemarks.PlaceholderText = "";
            txtAdditionalRemarks.SelectedText = "";
            txtAdditionalRemarks.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtAdditionalRemarks.Size = new Size(756, 90);
            txtAdditionalRemarks.TabIndex = 3;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubmitRequest.BackColor = Color.Transparent;
            btnSubmitRequest.BorderRadius = 5;
            btnSubmitRequest.CustomizableEdges = customizableEdges15;
            btnSubmitRequest.DisabledState.BorderColor = Color.DarkGray;
            btnSubmitRequest.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSubmitRequest.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSubmitRequest.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSubmitRequest.Enabled = false;
            btnSubmitRequest.FillColor = Color.FromArgb(18, 52, 86);
            btnSubmitRequest.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSubmitRequest.ForeColor = Color.White;
            btnSubmitRequest.Location = new Point(592, 685);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnSubmitRequest.Size = new Size(225, 42);
            btnSubmitRequest.TabIndex = 0;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // BarangayClearanceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 750);
            BackColor = Color.White;
            Controls.Add(btnSubmitRequest);
            Controls.Add(lblApplicantInformation);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblContactNumber);
            Controls.Add(txtContactNumber);
            Controls.Add(lblRequestDetails);
            Controls.Add(lblPurpose);
            Controls.Add(cmbPurpose);
            Controls.Add(lblOtherPurpose);
            Controls.Add(txtOtherPurpose);
            Controls.Add(lblAdditionalRemarks);
            Controls.Add(txtAdditionalRemarks);
            Controls.Add(pnlHeader);
            Name = "BarangayClearanceControl";
            Size = new Size(820, 599);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
