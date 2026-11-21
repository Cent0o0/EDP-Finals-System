using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    partial class ResidentProfileControl
    {
        private IContainer components = null!;
        private Panel pnlHeader = null!;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle = null!;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle = null!;

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
            pnlHeader = new Panel();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblContactNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblMiddleInitial = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSuffix = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblLastName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblFirstName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSaveChanges = new Guna.UI2.WinForms.Guna2Button();
            lblUsernameValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblContactNumberValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblAddressValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblMiddleInitialValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSuffixValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblLastNameValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblFirstNameValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            lblTitle.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(18, 52, 86);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(89, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Profile";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(22, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View your personal information. Select Edit Profile to make changes.";
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(36, 344);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(67, 18);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username";
            // 
            // lblContactNumber
            // 
            lblContactNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblContactNumber.Location = new Point(443, 188);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(105, 18);
            lblContactNumber.TabIndex = 6;
            lblContactNumber.Text = "Contact Number";
            // 
            // lblAddress
            // 
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(36, 266);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(53, 18);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address";
            // 
            // lblMiddleInitial
            // 
            lblMiddleInitial.BackColor = Color.Transparent;
            lblMiddleInitial.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblMiddleInitial.Location = new Point(36, 188);
            lblMiddleInitial.Name = "lblMiddleInitial";
            lblMiddleInitial.Size = new Size(22, 18);
            lblMiddleInitial.TabIndex = 4;
            lblMiddleInitial.Text = "M.I";
            // 
            // lblSuffix
            // 
            lblSuffix.BackColor = Color.Transparent;
            lblSuffix.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblSuffix.Location = new Point(210, 188);
            lblSuffix.Name = "lblSuffix";
            lblSuffix.Size = new Size(40, 18);
            lblSuffix.TabIndex = 11;
            lblSuffix.Text = "Suffix";
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblLastName.Location = new Point(443, 110);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(70, 18);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblFirstName.Location = new Point(36, 110);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(71, 18);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveChanges.BackColor = Color.Transparent;
            btnSaveChanges.BorderRadius = 5;
            btnSaveChanges.CustomizableEdges = customizableEdges1;
            btnSaveChanges.DisabledState.BorderColor = Color.DarkGray;
            btnSaveChanges.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSaveChanges.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSaveChanges.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSaveChanges.FillColor = Color.FromArgb(18, 52, 86);
            btnSaveChanges.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(564, 425);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSaveChanges.Size = new Size(225, 45);
            btnSaveChanges.TabIndex = 10;
            btnSaveChanges.Text = "Edit Profile";
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // lblUsernameValue
            // 
            lblUsernameValue.AutoSize = false;
            lblUsernameValue.BackColor = Color.Transparent;
            lblUsernameValue.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblUsernameValue.ForeColor = Color.Red;
            lblUsernameValue.Location = new Point(36, 366);
            lblUsernameValue.Name = "lblUsernameValue";
            lblUsernameValue.Size = new Size(350, 36);
            lblUsernameValue.TabIndex = 9;
            lblUsernameValue.Text = null;
            lblUsernameValue.TextAlignment = ContentAlignment.MiddleLeft;
            lblUsernameValue.Click += lblUsernameValue_Click;
            // 
            // lblContactNumberValue
            // 
            lblContactNumberValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblContactNumberValue.AutoSize = false;
            lblContactNumberValue.BackColor = Color.Transparent;
            lblContactNumberValue.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactNumberValue.ForeColor = Color.Red;
            lblContactNumberValue.Location = new Point(443, 210);
            lblContactNumberValue.Name = "lblContactNumberValue";
            lblContactNumberValue.Size = new Size(350, 36);
            lblContactNumberValue.TabIndex = 7;
            lblContactNumberValue.Text = null;
            lblContactNumberValue.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblAddressValue
            // 
            lblAddressValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAddressValue.AutoSize = false;
            lblAddressValue.BackColor = Color.Transparent;
            lblAddressValue.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblAddressValue.ForeColor = Color.Red;
            lblAddressValue.Location = new Point(36, 288);
            lblAddressValue.Name = "lblAddressValue";
            lblAddressValue.Size = new Size(756, 36);
            lblAddressValue.TabIndex = 8;
            lblAddressValue.Text = null;
            lblAddressValue.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblMiddleInitialValue
            // 
            lblMiddleInitialValue.AutoSize = false;
            lblMiddleInitialValue.BackColor = Color.Transparent;
            lblMiddleInitialValue.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblMiddleInitialValue.ForeColor = Color.Red;
            lblMiddleInitialValue.Location = new Point(36, 210);
            lblMiddleInitialValue.Name = "lblMiddleInitialValue";
            lblMiddleInitialValue.Size = new Size(160, 36);
            lblMiddleInitialValue.TabIndex = 5;
            lblMiddleInitialValue.Text = null;
            lblMiddleInitialValue.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblSuffixValue
            // 
            lblSuffixValue.AutoSize = false;
            lblSuffixValue.BackColor = Color.Transparent;
            lblSuffixValue.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuffixValue.ForeColor = Color.Red;
            lblSuffixValue.Location = new Point(210, 210);
            lblSuffixValue.Name = "lblSuffixValue";
            lblSuffixValue.Size = new Size(160, 36);
            lblSuffixValue.TabIndex = 6;
            lblSuffixValue.Text = null;
            lblSuffixValue.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblLastNameValue
            // 
            lblLastNameValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLastNameValue.AutoSize = false;
            lblLastNameValue.BackColor = Color.Transparent;
            lblLastNameValue.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastNameValue.ForeColor = Color.Red;
            lblLastNameValue.Location = new Point(443, 132);
            lblLastNameValue.Name = "lblLastNameValue";
            lblLastNameValue.Size = new Size(350, 36);
            lblLastNameValue.TabIndex = 3;
            lblLastNameValue.Text = null;
            lblLastNameValue.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblFirstNameValue
            // 
            lblFirstNameValue.AutoSize = false;
            lblFirstNameValue.BackColor = Color.Transparent;
            lblFirstNameValue.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblFirstNameValue.ForeColor = Color.Red;
            lblFirstNameValue.Location = new Point(36, 132);
            lblFirstNameValue.Name = "lblFirstNameValue";
            lblFirstNameValue.Size = new Size(350, 36);
            lblFirstNameValue.TabIndex = 1;
            lblFirstNameValue.Text = null;
            lblFirstNameValue.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // ResidentProfileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 650);
            BackColor = Color.White;
            Controls.Add(lblFirstNameValue);
            Controls.Add(lblLastNameValue);
            Controls.Add(lblMiddleInitialValue);
            Controls.Add(lblSuffixValue);
            Controls.Add(pnlHeader);
            Controls.Add(lblContactNumberValue);
            Controls.Add(lblAddress);
            Controls.Add(lblAddressValue);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblMiddleInitial);
            Controls.Add(lblSuffix);
            Controls.Add(lblContactNumber);
            Controls.Add(lblUsername);
            Controls.Add(btnSaveChanges);
            Controls.Add(lblUsernameValue);
            Name = "ResidentProfileControl";
            Size = new Size(871, 650);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContactNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMiddleInitial;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSuffix;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFirstName;
        private Guna.UI2.WinForms.Guna2Button btnSaveChanges;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsernameValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContactNumberValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddressValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMiddleInitialValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSuffixValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLastNameValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFirstNameValue;
    }
}
