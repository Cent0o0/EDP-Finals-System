using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    partial class ResidentEditProfileControl
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
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            txtMiddleInitial = new Guna.UI2.WinForms.Guna2TextBox();
            cmbSuffix = new ComboBox();
            txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
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
            lblTitle.Size = new Size(149, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit Profile";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(22, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(179, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Edit your personal information. ";
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(38, 344);
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
            lblContactNumber.Location = new Point(451, 188);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(105, 18);
            lblContactNumber.TabIndex = 6;
            lblContactNumber.Text = "Contact Number";
            // 
            // lblAddress
            // 
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(37, 266);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(53, 18);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address";
            // 
            // lblMiddleInitial
            // 
            lblMiddleInitial.BackColor = Color.Transparent;
            lblMiddleInitial.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblMiddleInitial.Location = new Point(39, 188);
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
            lblLastName.Location = new Point(453, 110);
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
            btnSaveChanges.Location = new Point(576, 490);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSaveChanges.Size = new Size(225, 45);
            btnSaveChanges.TabIndex = 10;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderColor = Color.Black;
            txtUsername.BorderRadius = 5;
            txtUsername.CustomizableEdges = customizableEdges3;
            txtUsername.DefaultText = "";
            txtUsername.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(34, 366);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUsername.Size = new Size(350, 36);
            txtUsername.TabIndex = 9;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtContactNumber.BorderColor = Color.Black;
            txtContactNumber.BorderRadius = 5;
            txtContactNumber.CustomizableEdges = customizableEdges5;
            txtContactNumber.DefaultText = "";
            txtContactNumber.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNumber.ForeColor = Color.Black;
            txtContactNumber.Location = new Point(451, 210);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PlaceholderText = "";
            txtContactNumber.SelectedText = "";
            txtContactNumber.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtContactNumber.Size = new Size(350, 36);
            txtContactNumber.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.BorderColor = Color.Black;
            txtAddress.BorderRadius = 5;
            txtAddress.CustomizableEdges = customizableEdges7;
            txtAddress.DefaultText = "";
            txtAddress.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(34, 288);
            txtAddress.MaxLength = 200;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "";
            txtAddress.SelectedText = "";
            txtAddress.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtAddress.Size = new Size(604, 36);
            txtAddress.TabIndex = 8;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.BorderColor = Color.Black;
            txtMiddleInitial.BorderRadius = 5;
            txtMiddleInitial.CustomizableEdges = customizableEdges9;
            txtMiddleInitial.DefaultText = "";
            txtMiddleInitial.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleInitial.ForeColor = Color.Black;
            txtMiddleInitial.Location = new Point(34, 210);
            txtMiddleInitial.MaxLength = 1;
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.PlaceholderText = "";
            txtMiddleInitial.SelectedText = "";
            txtMiddleInitial.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtMiddleInitial.Size = new Size(160, 36);
            txtMiddleInitial.TabIndex = 5;
            // 
            // cmbSuffix
            // 
            cmbSuffix.BackColor = SystemColors.InactiveCaptionText;
            cmbSuffix.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuffix.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSuffix.FormattingEnabled = true;
            cmbSuffix.Items.AddRange(new object[] { "", "Jr.", "Sr.", "II", "III", "IV" });
            cmbSuffix.Location = new Point(210, 216);
            cmbSuffix.Name = "cmbSuffix";
            cmbSuffix.Size = new Size(160, 24);
            cmbSuffix.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLastName.BorderColor = Color.Black;
            txtLastName.BorderRadius = 5;
            txtLastName.CustomizableEdges = customizableEdges11;
            txtLastName.DefaultText = "";
            txtLastName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(452, 132);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "";
            txtLastName.SelectedText = "";
            txtLastName.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtLastName.Size = new Size(350, 36);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderColor = Color.Black;
            txtFirstName.BorderRadius = 5;
            txtFirstName.CustomizableEdges = customizableEdges13;
            txtFirstName.DefaultText = "";
            txtFirstName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(34, 132);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "";
            txtFirstName.SelectedText = "";
            txtFirstName.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtFirstName.Size = new Size(350, 36);
            txtFirstName.TabIndex = 1;
            // 
            // ResidentEditProfileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 650);
            BackColor = Color.White;
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleInitial);
            Controls.Add(cmbSuffix);
            Controls.Add(pnlHeader);
            Controls.Add(txtContactNumber);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblMiddleInitial);
            Controls.Add(lblSuffix);
            Controls.Add(lblContactNumber);
            Controls.Add(lblUsername);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtUsername);
            Name = "ResidentEditProfileControl";
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
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtContactNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtMiddleInitial;
        private ComboBox cmbSuffix;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
    }
}
