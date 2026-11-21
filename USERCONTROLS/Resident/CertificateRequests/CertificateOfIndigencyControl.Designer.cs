using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    partial class CertificateOfIndigencyControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
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
            pnlHeader = new Panel();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblFullName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            lblPurpose = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbPurpose = new ComboBox();
            lblOtherPurpose = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtOtherPurpose = new Guna.UI2.WinForms.Guna2TextBox();
            lblAdditionalRemarks = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtAdditionalRemarks = new Guna.UI2.WinForms.Guna2TextBox();
            btnSubmitRequest = new Guna.UI2.WinForms.Guna2Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();

            pnlHeader.BackColor = Color.FromArgb(234, 245, 245);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(871, 80);
            pnlHeader.TabIndex = 0;

            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Certificate of Indigency";

            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F);
            lblSubtitle.Location = new Point(22, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(440, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Review your information and complete the request details.";

            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblFullName.Location = new Point(54, 108);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(75, 18);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";

            txtFullName.BorderColor = Color.Black;
            txtFullName.BorderRadius = 5;
            txtFullName.DefaultText = "";
            txtFullName.FillColor = Color.FromArgb(245, 245, 245);
            txtFullName.Font = new Font("Arial", 10F);
            txtFullName.ForeColor = Color.Black;
            txtFullName.Location = new Point(57, 130);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "";
            txtFullName.ReadOnly = true;
            txtFullName.SelectedText = "";
            txtFullName.Size = new Size(756, 36);
            txtFullName.TabIndex = 2;
            txtFullName.TabStop = false;

            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblAddress.Location = new Point(54, 184);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(118, 18);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Complete Address";

            txtAddress.BorderColor = Color.Black;
            txtAddress.BorderRadius = 5;
            txtAddress.DefaultText = "";
            txtAddress.FillColor = Color.FromArgb(245, 245, 245);
            txtAddress.Font = new Font("Arial", 10F);
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(57, 206);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "";
            txtAddress.ReadOnly = true;
            txtAddress.SelectedText = "";
            txtAddress.Size = new Size(756, 36);
            txtAddress.TabIndex = 4;
            txtAddress.TabStop = false;

            lblPurpose.BackColor = Color.Transparent;
            lblPurpose.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblPurpose.Location = new Point(54, 262);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(117, 18);
            lblPurpose.TabIndex = 5;
            lblPurpose.Text = "Purpose of Request";

            cmbPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPurpose.Font = new Font("Arial", 10F);
            cmbPurpose.FormattingEnabled = true;
            cmbPurpose.Items.AddRange(new object[]
            {
                "Scholarship Application",
                "Educational Assistance",
                "Medical Assistance",
                "Financial Assistance",
                "DSWD Assistance",
                "DOST Scholarship",
                "Government Assistance",
                "Other"
            });
            cmbPurpose.Location = new Point(57, 284);
            cmbPurpose.Name = "cmbPurpose";
            cmbPurpose.Size = new Size(350, 24);
            cmbPurpose.TabIndex = 0;
            cmbPurpose.SelectedIndexChanged += cmbPurpose_SelectedIndexChanged;

            lblOtherPurpose.BackColor = Color.Transparent;
            lblOtherPurpose.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblOtherPurpose.Location = new Point(54, 330);
            lblOtherPurpose.Name = "lblOtherPurpose";
            lblOtherPurpose.Size = new Size(83, 18);
            lblOtherPurpose.TabIndex = 6;
            lblOtherPurpose.Text = "Other Purpose";
            lblOtherPurpose.Visible = false;

            txtOtherPurpose.BorderColor = Color.Black;
            txtOtherPurpose.BorderRadius = 5;
            txtOtherPurpose.DefaultText = "";
            txtOtherPurpose.Font = new Font("Arial", 10F);
            txtOtherPurpose.ForeColor = Color.Black;
            txtOtherPurpose.Location = new Point(57, 352);
            txtOtherPurpose.MaxLength = 200;
            txtOtherPurpose.Name = "txtOtherPurpose";
            txtOtherPurpose.PlaceholderText = "";
            txtOtherPurpose.SelectedText = "";
            txtOtherPurpose.Size = new Size(350, 36);
            txtOtherPurpose.TabIndex = 1;
            txtOtherPurpose.Visible = false;

            lblAdditionalRemarks.BackColor = Color.Transparent;
            lblAdditionalRemarks.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblAdditionalRemarks.Location = new Point(54, 406);
            lblAdditionalRemarks.Name = "lblAdditionalRemarks";
            lblAdditionalRemarks.Size = new Size(117, 18);
            lblAdditionalRemarks.TabIndex = 7;
            lblAdditionalRemarks.Text = "Additional Remarks";

            txtAdditionalRemarks.BorderColor = Color.Black;
            txtAdditionalRemarks.BorderRadius = 5;
            txtAdditionalRemarks.DefaultText = "";
            txtAdditionalRemarks.Font = new Font("Arial", 10F);
            txtAdditionalRemarks.ForeColor = Color.Black;
            txtAdditionalRemarks.Location = new Point(57, 428);
            txtAdditionalRemarks.MaxLength = 1000;
            txtAdditionalRemarks.Multiline = true;
            txtAdditionalRemarks.Name = "txtAdditionalRemarks";
            txtAdditionalRemarks.PlaceholderText = "";
            txtAdditionalRemarks.ScrollBars = ScrollBars.None;
            txtAdditionalRemarks.SelectedText = "";
            txtAdditionalRemarks.Size = new Size(756, 80);
            txtAdditionalRemarks.TabIndex = 2;

            btnSubmitRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitRequest.BorderRadius = 5;
            btnSubmitRequest.FillColor = Color.FromArgb(18, 52, 86);
            btnSubmitRequest.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnSubmitRequest.ForeColor = Color.White;
            btnSubmitRequest.Location = new Point(592, 540);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(225, 42);
            btnSubmitRequest.TabIndex = 3;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.Click += btnSubmitRequest_Click;

            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblPurpose);
            Controls.Add(cmbPurpose);
            Controls.Add(lblOtherPurpose);
            Controls.Add(txtOtherPurpose);
            Controls.Add(lblAdditionalRemarks);
            Controls.Add(txtAdditionalRemarks);
            Controls.Add(btnSubmitRequest);
            Controls.Add(pnlHeader);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 600);
            BackColor = Color.White;
            Name = "CertificateOfIndigencyControl";
            Size = new Size(871, 620);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
