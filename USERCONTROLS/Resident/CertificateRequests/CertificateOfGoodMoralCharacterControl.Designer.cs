using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    partial class CertificateOfGoodMoralCharacterControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContactNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtContactNumber;
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
            pnlHeader = new Panel();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblFullName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            lblContactNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
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
            lblTitle.Size = new Size(433, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Good Moral Character Certificate";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F);
            lblSubtitle.Location = new Point(22, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(373, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Review your information and complete the request details below.";
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblFullName.Location = new Point(54, 136);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(68, 17);
            lblFullName.TabIndex = 2;
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
            txtFullName.Location = new Point(65, 148);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "";
            txtFullName.ReadOnly = true;
            txtFullName.SelectedText = "";
            txtFullName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtFullName.Size = new Size(400, 37);
            txtFullName.TabIndex = 3;
            txtFullName.TabStop = false;
            // 
            // lblAddress
            // 
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblAddress.Location = new Point(54, 204);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(122, 17);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Complete Address";
            // 
            // txtAddress
            // 
            txtAddress.BorderColor = Color.Black;
            txtAddress.BorderRadius = 5;
            txtAddress.CustomizableEdges = customizableEdges3;
            txtAddress.DefaultText = "";
            txtAddress.FillColor = Color.FromArgb(245, 245, 245);
            txtAddress.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(57, 212);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "";
            txtAddress.ReadOnly = true;
            txtAddress.SelectedText = "";
            txtAddress.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtAddress.Size = new Size(756, 36);
            txtAddress.TabIndex = 5;
            txtAddress.TabStop = false;
            // 
            // lblContactNumber
            // 
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblContactNumber.Location = new Point(54, 272);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(110, 17);
            lblContactNumber.TabIndex = 6;
            lblContactNumber.Text = "Contact Number";
            // 
            // txtContactNumber
            // 
            txtContactNumber.BorderColor = Color.Black;
            txtContactNumber.BorderRadius = 5;
            txtContactNumber.CustomizableEdges = customizableEdges5;
            txtContactNumber.DefaultText = "";
            txtContactNumber.FillColor = Color.FromArgb(245, 245, 245);
            txtContactNumber.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtContactNumber.ForeColor = Color.Black;
            txtContactNumber.Location = new Point(65, 276);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PlaceholderText = "";
            txtContactNumber.ReadOnly = true;
            txtContactNumber.SelectedText = "";
            txtContactNumber.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtContactNumber.Size = new Size(400, 37);
            txtContactNumber.TabIndex = 7;
            txtContactNumber.TabStop = false;
            // 
            // lblPurpose
            // 
            lblPurpose.BackColor = Color.Transparent;
            lblPurpose.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblPurpose.Location = new Point(54, 386);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(128, 17);
            lblPurpose.TabIndex = 9;
            lblPurpose.Text = "Purpose of Request";
            // 
            // cmbPurpose
            // 
            cmbPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPurpose.Font = new Font("Arial Rounded MT Bold", 9.75F);
            cmbPurpose.FormattingEnabled = true;
            cmbPurpose.Items.AddRange(new object[] { "School Admission", "Scholarship Application", "Employment", "Job Application", "Internship / OJT", "Government Requirement", "Personal Requirement", "Other" });
            cmbPurpose.Location = new Point(57, 408);
            cmbPurpose.Name = "cmbPurpose";
            cmbPurpose.Size = new Size(350, 23);
            cmbPurpose.TabIndex = 0;
            cmbPurpose.SelectedIndexChanged += cmbPurpose_SelectedIndexChanged;
            // 
            // lblOtherPurpose
            // 
            lblOtherPurpose.BackColor = Color.Transparent;
            lblOtherPurpose.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblOtherPurpose.Location = new Point(54, 454);
            lblOtherPurpose.Name = "lblOtherPurpose";
            lblOtherPurpose.Size = new Size(97, 17);
            lblOtherPurpose.TabIndex = 10;
            lblOtherPurpose.Text = "Other Purpose";
            lblOtherPurpose.Visible = false;
            // 
            // txtOtherPurpose
            // 
            txtOtherPurpose.BorderColor = Color.Black;
            txtOtherPurpose.BorderRadius = 5;
            txtOtherPurpose.CustomizableEdges = customizableEdges7;
            txtOtherPurpose.DefaultText = "";
            txtOtherPurpose.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtOtherPurpose.ForeColor = Color.Black;
            txtOtherPurpose.Location = new Point(65, 476);
            txtOtherPurpose.MaxLength = 200;
            txtOtherPurpose.Name = "txtOtherPurpose";
            txtOtherPurpose.PlaceholderText = "";
            txtOtherPurpose.SelectedText = "";
            txtOtherPurpose.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtOtherPurpose.Size = new Size(400, 36);
            txtOtherPurpose.TabIndex = 1;
            txtOtherPurpose.Visible = false;
            // 
            // lblAdditionalRemarks
            // 
            lblAdditionalRemarks.BackColor = Color.Transparent;
            lblAdditionalRemarks.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblAdditionalRemarks.Location = new Point(54, 522);
            lblAdditionalRemarks.Name = "lblAdditionalRemarks";
            lblAdditionalRemarks.Size = new Size(129, 17);
            lblAdditionalRemarks.TabIndex = 14;
            lblAdditionalRemarks.Text = "Additional Remarks";
            // 
            // txtAdditionalRemarks
            // 
            txtAdditionalRemarks.BorderColor = Color.Black;
            txtAdditionalRemarks.BorderRadius = 5;
            txtAdditionalRemarks.CustomizableEdges = customizableEdges9;
            txtAdditionalRemarks.DefaultText = "";
            txtAdditionalRemarks.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtAdditionalRemarks.ForeColor = Color.Black;
            txtAdditionalRemarks.Location = new Point(57, 544);
            txtAdditionalRemarks.MaxLength = 1000;
            txtAdditionalRemarks.Multiline = true;
            txtAdditionalRemarks.Name = "txtAdditionalRemarks";
            txtAdditionalRemarks.PlaceholderText = "";
            txtAdditionalRemarks.SelectedText = "";
            txtAdditionalRemarks.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtAdditionalRemarks.Size = new Size(756, 56);
            txtAdditionalRemarks.TabIndex = 1;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitRequest.BorderRadius = 5;
            btnSubmitRequest.CustomizableEdges = customizableEdges11;
            btnSubmitRequest.FillColor = Color.FromArgb(18, 52, 86);
            btnSubmitRequest.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnSubmitRequest.ForeColor = Color.White;
            btnSubmitRequest.Location = new Point(592, 600);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSubmitRequest.Size = new Size(225, 42);
            btnSubmitRequest.TabIndex = 4;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // CertificateOfGoodMoralCharacterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 650);
            BackColor = Color.White;
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblContactNumber);
            Controls.Add(txtContactNumber);
            Controls.Add(lblPurpose);
            Controls.Add(cmbPurpose);
            Controls.Add(lblOtherPurpose);
            Controls.Add(txtOtherPurpose);
            Controls.Add(lblAdditionalRemarks);
            Controls.Add(txtAdditionalRemarks);
            Controls.Add(btnSubmitRequest);
            Controls.Add(pnlHeader);
            Name = "CertificateOfGoodMoralCharacterControl";
            Size = new Size(871, 650);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
