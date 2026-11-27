using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    partial class CertificateForBusinessControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContactNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtContactNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBusinessInformation;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBusinessName;
        private Guna.UI2.WinForms.Guna2TextBox txtBusinessName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBusinessOwner;
        private Guna.UI2.WinForms.Guna2TextBox txtBusinessOwner;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBusinessAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtBusinessAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNatureOfBusiness;
        private Guna.UI2.WinForms.Guna2TextBox txtNatureOfBusiness;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBusinessType;
        private ComboBox cmbBusinessType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateEstablished;
        private DateTimePicker dtpDateEstablished;
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
            lblContactNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            lblBusinessInformation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblBusinessName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtBusinessName = new Guna.UI2.WinForms.Guna2TextBox();
            lblBusinessOwner = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtBusinessOwner = new Guna.UI2.WinForms.Guna2TextBox();
            lblBusinessAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtBusinessAddress = new Guna.UI2.WinForms.Guna2TextBox();
            lblNatureOfBusiness = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtNatureOfBusiness = new Guna.UI2.WinForms.Guna2TextBox();
            lblBusinessType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbBusinessType = new ComboBox();
            lblDateEstablished = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtpDateEstablished = new DateTimePicker();
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
            lblTitle.ForeColor = Color.FromArgb(18, 52, 86);
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(312, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Certificate for Business";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F);
            lblSubtitle.Location = new Point(22, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(339, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Review your information and provide your business details.";
            // 
            // lblContactNumber
            // 
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblContactNumber.Location = new Point(437, 139);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(110, 17);
            lblContactNumber.TabIndex = 9;
            lblContactNumber.Text = "Contact Number";
            // 
            // txtContactNumber
            // 
            txtContactNumber.BorderColor = Color.Black;
            txtContactNumber.BorderRadius = 5;
            txtContactNumber.CustomizableEdges = customizableEdges1;
            txtContactNumber.DefaultText = "";
            txtContactNumber.FillColor = Color.FromArgb(245, 245, 245);
            txtContactNumber.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtContactNumber.ForeColor = Color.Black;
            txtContactNumber.Location = new Point(437, 161);
            txtContactNumber.Margin = new Padding(3, 2, 3, 2);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PlaceholderText = "";
            txtContactNumber.ReadOnly = true;
            txtContactNumber.SelectedText = "";
            txtContactNumber.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtContactNumber.Size = new Size(348, 36);
            txtContactNumber.TabIndex = 10;
            txtContactNumber.TabStop = false;
            // 
            // lblBusinessInformation
            // 
            lblBusinessInformation.BackColor = Color.Transparent;
            lblBusinessInformation.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblBusinessInformation.ForeColor = Color.Black;
            lblBusinessInformation.Location = new Point(30, 100);
            lblBusinessInformation.Name = "lblBusinessInformation";
            lblBusinessInformation.Size = new Size(139, 17);
            lblBusinessInformation.TabIndex = 1;
            lblBusinessInformation.Text = "Business Information";
            // 
            // lblBusinessName
            // 
            lblBusinessName.BackColor = Color.Transparent;
            lblBusinessName.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblBusinessName.Location = new Point(31, 139);
            lblBusinessName.Name = "lblBusinessName";
            lblBusinessName.Size = new Size(102, 17);
            lblBusinessName.TabIndex = 9;
            lblBusinessName.Text = "Business Name";
            // 
            // txtBusinessName
            // 
            txtBusinessName.BorderColor = Color.Black;
            txtBusinessName.BorderRadius = 5;
            txtBusinessName.CustomizableEdges = customizableEdges3;
            txtBusinessName.DefaultText = "";
            txtBusinessName.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtBusinessName.ForeColor = Color.Black;
            txtBusinessName.Location = new Point(31, 161);
            txtBusinessName.Margin = new Padding(3, 2, 3, 2);
            txtBusinessName.MaxLength = 150;
            txtBusinessName.Name = "txtBusinessName";
            txtBusinessName.PlaceholderText = "";
            txtBusinessName.SelectedText = "";
            txtBusinessName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtBusinessName.Size = new Size(380, 36);
            txtBusinessName.TabIndex = 0;
            // 
            // lblBusinessOwner
            // 
            lblBusinessOwner.BackColor = Color.Transparent;
            lblBusinessOwner.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblBusinessOwner.Location = new Point(31, 207);
            lblBusinessOwner.Name = "lblBusinessOwner";
            lblBusinessOwner.Size = new Size(107, 17);
            lblBusinessOwner.TabIndex = 10;
            lblBusinessOwner.Text = "Business Owner";
            // 
            // txtBusinessOwner
            // 
            txtBusinessOwner.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBusinessOwner.BorderColor = Color.Black;
            txtBusinessOwner.BorderRadius = 5;
            txtBusinessOwner.CustomizableEdges = customizableEdges5;
            txtBusinessOwner.DefaultText = "";
            txtBusinessOwner.FillColor = Color.FromArgb(245, 245, 245);
            txtBusinessOwner.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtBusinessOwner.ForeColor = Color.Black;
            txtBusinessOwner.Location = new Point(31, 229);
            txtBusinessOwner.Margin = new Padding(3, 2, 3, 2);
            txtBusinessOwner.MaxLength = 100;
            txtBusinessOwner.Name = "txtBusinessOwner";
            txtBusinessOwner.PlaceholderText = "";
            txtBusinessOwner.ReadOnly = true;
            txtBusinessOwner.SelectedText = "";
            txtBusinessOwner.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtBusinessOwner.Size = new Size(380, 36);
            txtBusinessOwner.TabIndex = 11;
            txtBusinessOwner.TabStop = false;
            // 
            // lblBusinessAddress
            // 
            lblBusinessAddress.BackColor = Color.Transparent;
            lblBusinessAddress.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblBusinessAddress.Location = new Point(31, 343);
            lblBusinessAddress.Name = "lblBusinessAddress";
            lblBusinessAddress.Size = new Size(117, 17);
            lblBusinessAddress.TabIndex = 12;
            lblBusinessAddress.Text = "Business Address";
            // 
            // txtBusinessAddress
            // 
            txtBusinessAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusinessAddress.BorderColor = Color.Black;
            txtBusinessAddress.BorderRadius = 5;
            txtBusinessAddress.CustomizableEdges = customizableEdges7;
            txtBusinessAddress.DefaultText = "";
            txtBusinessAddress.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtBusinessAddress.ForeColor = Color.Black;
            txtBusinessAddress.Location = new Point(40, 365);
            txtBusinessAddress.Margin = new Padding(3, 2, 3, 2);
            txtBusinessAddress.MaxLength = 200;
            txtBusinessAddress.Name = "txtBusinessAddress";
            txtBusinessAddress.PlaceholderText = "";
            txtBusinessAddress.SelectedText = "";
            txtBusinessAddress.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtBusinessAddress.Size = new Size(721, 36);
            txtBusinessAddress.TabIndex = 1;
            // 
            // lblNatureOfBusiness
            // 
            lblNatureOfBusiness.BackColor = Color.Transparent;
            lblNatureOfBusiness.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblNatureOfBusiness.Location = new Point(31, 277);
            lblNatureOfBusiness.Name = "lblNatureOfBusiness";
            lblNatureOfBusiness.Size = new Size(124, 17);
            lblNatureOfBusiness.TabIndex = 13;
            lblNatureOfBusiness.Text = "Nature of Business";
            // 
            // txtNatureOfBusiness
            // 
            txtNatureOfBusiness.BorderColor = Color.Black;
            txtNatureOfBusiness.BorderRadius = 5;
            txtNatureOfBusiness.CustomizableEdges = customizableEdges9;
            txtNatureOfBusiness.DefaultText = "";
            txtNatureOfBusiness.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtNatureOfBusiness.ForeColor = Color.Black;
            txtNatureOfBusiness.Location = new Point(31, 299);
            txtNatureOfBusiness.Margin = new Padding(3, 2, 3, 2);
            txtNatureOfBusiness.MaxLength = 150;
            txtNatureOfBusiness.Name = "txtNatureOfBusiness";
            txtNatureOfBusiness.PlaceholderText = "";
            txtNatureOfBusiness.SelectedText = "";
            txtNatureOfBusiness.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtNatureOfBusiness.Size = new Size(376, 36);
            txtNatureOfBusiness.TabIndex = 2;
            // 
            // lblBusinessType
            // 
            lblBusinessType.BackColor = Color.Transparent;
            lblBusinessType.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblBusinessType.Location = new Point(437, 221);
            lblBusinessType.Name = "lblBusinessType";
            lblBusinessType.Size = new Size(95, 17);
            lblBusinessType.TabIndex = 14;
            lblBusinessType.Text = "Business Type";
            // 
            // cmbBusinessType
            // 
            cmbBusinessType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBusinessType.Font = new Font("Arial Rounded MT Bold", 9.75F);
            cmbBusinessType.FormattingEnabled = true;
            cmbBusinessType.Items.AddRange(new object[] { "Sole Proprietorship", "Partnership", "Corporation", "Cooperative" });
            cmbBusinessType.Location = new Point(437, 243);
            cmbBusinessType.Name = "cmbBusinessType";
            cmbBusinessType.Size = new Size(348, 23);
            cmbBusinessType.TabIndex = 3;
            // 
            // lblDateEstablished
            // 
            lblDateEstablished.BackColor = Color.Transparent;
            lblDateEstablished.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblDateEstablished.Location = new Point(31, 407);
            lblDateEstablished.Name = "lblDateEstablished";
            lblDateEstablished.Size = new Size(113, 17);
            lblDateEstablished.TabIndex = 15;
            lblDateEstablished.Text = "Date Established";
            // 
            // dtpDateEstablished
            // 
            dtpDateEstablished.CustomFormat = "MMMM yyyy";
            dtpDateEstablished.Font = new Font("Arial Rounded MT Bold", 9.75F);
            dtpDateEstablished.Format = DateTimePickerFormat.Custom;
            dtpDateEstablished.Location = new Point(31, 429);
            dtpDateEstablished.Name = "dtpDateEstablished";
            dtpDateEstablished.Size = new Size(350, 23);
            dtpDateEstablished.TabIndex = 4;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitRequest.BorderRadius = 5;
            btnSubmitRequest.CustomizableEdges = customizableEdges11;
            btnSubmitRequest.FillColor = Color.FromArgb(18, 52, 86);
            btnSubmitRequest.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnSubmitRequest.ForeColor = Color.White;
            btnSubmitRequest.Location = new Point(586, 577);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSubmitRequest.Size = new Size(225, 42);
            btnSubmitRequest.TabIndex = 5;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // CertificateForBusinessControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 570);
            BackColor = Color.White;
            Controls.Add(lblContactNumber);
            Controls.Add(txtContactNumber);
            Controls.Add(lblBusinessInformation);
            Controls.Add(lblBusinessName);
            Controls.Add(txtBusinessName);
            Controls.Add(lblBusinessOwner);
            Controls.Add(txtBusinessOwner);
            Controls.Add(lblBusinessAddress);
            Controls.Add(txtBusinessAddress);
            Controls.Add(lblNatureOfBusiness);
            Controls.Add(txtNatureOfBusiness);
            Controls.Add(lblBusinessType);
            Controls.Add(cmbBusinessType);
            Controls.Add(lblDateEstablished);
            Controls.Add(dtpDateEstablished);
            Controls.Add(btnSubmitRequest);
            Controls.Add(pnlHeader);
            Name = "CertificateForBusinessControl";
            Size = new Size(871, 650);
            Load += CertificateForBusinessControl_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
