using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident.CertificateRequests
{
    partial class CertificateOfNoObjectionControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubjectActivity;
        private Guna.UI2.WinForms.Guna2TextBox txtSubjectActivity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private NumericUpDown nudQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLocation;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPurpose;
        private Guna.UI2.WinForms.Guna2TextBox txtPurpose;
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
            lblSubjectActivity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSubjectActivity = new Guna.UI2.WinForms.Guna2TextBox();
            lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            nudQuantity = new NumericUpDown();
            lblLocation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            lblPurpose = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtPurpose = new Guna.UI2.WinForms.Guna2TextBox();
            btnSubmitRequest = new Guna.UI2.WinForms.Guna2Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
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
            lblTitle.Size = new Size(440, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "No Objection Certification";

            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F);
            lblSubtitle.Location = new Point(22, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(460, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Review your account details and provide information about the activity.";

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
            txtFullName.TabIndex = 5;
            txtFullName.TabStop = false;

            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblAddress.Location = new Point(54, 184);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(118, 18);
            lblAddress.TabIndex = 6;
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
            txtAddress.TabIndex = 7;
            txtAddress.TabStop = false;

            lblSubjectActivity.BackColor = Color.Transparent;
            lblSubjectActivity.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblSubjectActivity.Location = new Point(54, 262);
            lblSubjectActivity.Name = "lblSubjectActivity";
            lblSubjectActivity.Size = new Size(118, 18);
            lblSubjectActivity.TabIndex = 8;
            lblSubjectActivity.Text = "Subject / Activity";

            txtSubjectActivity.BorderColor = Color.Black;
            txtSubjectActivity.BorderRadius = 5;
            txtSubjectActivity.DefaultText = "";
            txtSubjectActivity.Font = new Font("Arial", 10F);
            txtSubjectActivity.ForeColor = Color.Black;
            txtSubjectActivity.Location = new Point(57, 284);
            txtSubjectActivity.MaxLength = 200;
            txtSubjectActivity.Name = "txtSubjectActivity";
            txtSubjectActivity.PlaceholderText = "";
            txtSubjectActivity.SelectedText = "";
            txtSubjectActivity.Size = new Size(350, 36);
            txtSubjectActivity.TabIndex = 0;

            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblQuantity.Location = new Point(430, 262);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(103, 18);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity (if any)";

            nudQuantity.Font = new Font("Arial", 10F);
            nudQuantity.Location = new Point(433, 284);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(350, 23);
            nudQuantity.TabIndex = 1;
            nudQuantity.ThousandsSeparator = true;

            lblLocation.BackColor = Color.Transparent;
            lblLocation.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblLocation.Location = new Point(54, 330);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(118, 18);
            lblLocation.TabIndex = 12;
            lblLocation.Text = "Location of Activity";

            txtLocation.BorderColor = Color.Black;
            txtLocation.BorderRadius = 5;
            txtLocation.DefaultText = "";
            txtLocation.Font = new Font("Arial", 10F);
            txtLocation.ForeColor = Color.Black;
            txtLocation.Location = new Point(57, 352);
            txtLocation.MaxLength = 200;
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "";
            txtLocation.SelectedText = "";
            txtLocation.Size = new Size(756, 36);
            txtLocation.TabIndex = 2;

            lblPurpose.BackColor = Color.Transparent;
            lblPurpose.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblPurpose.Location = new Point(54, 398);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(117, 18);
            lblPurpose.TabIndex = 14;
            lblPurpose.Text = "Purpose of Request";

            txtPurpose.BorderColor = Color.Black;
            txtPurpose.BorderRadius = 5;
            txtPurpose.DefaultText = "";
            txtPurpose.Font = new Font("Arial", 10F);
            txtPurpose.ForeColor = Color.Black;
            txtPurpose.Location = new Point(57, 420);
            txtPurpose.MaxLength = 300;
            txtPurpose.Name = "txtPurpose";
            txtPurpose.PlaceholderText = "";
            txtPurpose.SelectedText = "";
            txtPurpose.Size = new Size(756, 36);
            txtPurpose.TabIndex = 3;

            btnSubmitRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitRequest.BorderRadius = 5;
            btnSubmitRequest.FillColor = Color.FromArgb(18, 52, 86);
            btnSubmitRequest.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnSubmitRequest.ForeColor = Color.White;
            btnSubmitRequest.Location = new Point(592, 490);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(225, 42);
            btnSubmitRequest.TabIndex = 4;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.Click += btnSubmitRequest_Click;

            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblSubjectActivity);
            Controls.Add(txtSubjectActivity);
            Controls.Add(lblQuantity);
            Controls.Add(nudQuantity);
            Controls.Add(lblLocation);
            Controls.Add(txtLocation);
            Controls.Add(lblPurpose);
            Controls.Add(txtPurpose);
            Controls.Add(btnSubmitRequest);
            Controls.Add(pnlHeader);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 550);
            BackColor = Color.White;
            Name = "CertificateOfNoObjectionControl";
            Size = new Size(871, 590);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
