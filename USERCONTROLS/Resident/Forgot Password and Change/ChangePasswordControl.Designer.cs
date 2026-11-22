using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    partial class ChangePasswordControl
    {
        private IContainer components = null!;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlLeft = null!;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlCard = null!;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle = null!;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle = null!;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNewPassword = null!;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblConfirmPassword = null!;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword = null!;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword = null!;
        private Guna.UI2.WinForms.Guna2Button btnSavePassword = null!;
        private Guna.UI2.WinForms.Guna2Button btnBackToLogin = null!;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlLeft = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            pnlCard = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNewPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            lblConfirmPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnSavePassword = new Guna.UI2.WinForms.Guna2Button();
            btnBackToLogin = new Guna.UI2.WinForms.Guna2Button();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.CustomizableEdges = customizableEdges1;
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.FillColor = Color.FromArgb(18, 52, 86);
            pnlLeft.FillColor2 = Color.FromArgb(18, 52, 86);
            pnlLeft.FillColor3 = Color.FromArgb(18, 52, 86);
            pnlLeft.FillColor4 = Color.FromArgb(18, 52, 86);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlLeft.Size = new Size(350, 650);
            pnlLeft.TabIndex = 0;
            // 
            // pnlCard
            // 
            pnlCard.BorderColor = Color.Black;
            pnlCard.BorderRadius = 10;
            pnlCard.BorderThickness = 1;
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblNewPassword);
            pnlCard.Controls.Add(txtNewPassword);
            pnlCard.Controls.Add(lblConfirmPassword);
            pnlCard.Controls.Add(txtConfirmPassword);
            pnlCard.Controls.Add(btnSavePassword);
            pnlCard.Controls.Add(btnBackToLogin);
            pnlCard.CustomizableEdges = customizableEdges11;
            pnlCard.FillColor2 = SystemColors.ActiveCaption;
            pnlCard.Location = new Point(471, 50);
            pnlCard.Name = "pnlCard";
            pnlCard.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pnlCard.Size = new Size(516, 546);
            pnlCard.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(18, 52, 86);
            lblTitle.Location = new Point(50, 82);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(241, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Change Password";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F);
            lblSubtitle.Location = new Point(52, 123);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(295, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Choose a new password for your resident account.";
            // 
            // lblNewPassword
            // 
            lblNewPassword.BackColor = Color.Transparent;
            lblNewPassword.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblNewPassword.Location = new Point(52, 182);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(96, 18);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderColor = Color.Black;
            txtNewPassword.BorderRadius = 5;
            txtNewPassword.CustomizableEdges = customizableEdges3;
            txtNewPassword.DefaultText = "";
            txtNewPassword.Font = new Font("Arial", 9.75F);
            txtNewPassword.ForeColor = Color.Black;
            txtNewPassword.Location = new Point(52, 207);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.PlaceholderText = "Enter a new password";
            txtNewPassword.SelectedText = "";
            txtNewPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtNewPassword.Size = new Size(412, 38);
            txtNewPassword.TabIndex = 3;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblConfirmPassword.Location = new Point(52, 267);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(118, 18);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderColor = Color.Black;
            txtConfirmPassword.BorderRadius = 5;
            txtConfirmPassword.CustomizableEdges = customizableEdges5;
            txtConfirmPassword.DefaultText = "";
            txtConfirmPassword.Font = new Font("Arial", 9.75F);
            txtConfirmPassword.ForeColor = Color.Black;
            txtConfirmPassword.Location = new Point(52, 292);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.PlaceholderText = "Re-enter your new password";
            txtConfirmPassword.SelectedText = "";
            txtConfirmPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtConfirmPassword.Size = new Size(412, 38);
            txtConfirmPassword.TabIndex = 5;
            // 
            // btnSavePassword
            // 
            btnSavePassword.BorderRadius = 5;
            btnSavePassword.CustomizableEdges = customizableEdges7;
            btnSavePassword.FillColor = Color.FromArgb(18, 52, 86);
            btnSavePassword.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnSavePassword.ForeColor = Color.White;
            btnSavePassword.Location = new Point(52, 360);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSavePassword.Size = new Size(412, 45);
            btnSavePassword.TabIndex = 6;
            btnSavePassword.Text = "Change Password";
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.Transparent;
            btnBackToLogin.BorderRadius = 5;
            btnBackToLogin.CustomizableEdges = customizableEdges9;
            btnBackToLogin.FillColor = Color.Transparent;
            btnBackToLogin.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnBackToLogin.ForeColor = Color.FromArgb(18, 52, 86);
            btnBackToLogin.Location = new Point(170, 427);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnBackToLogin.Size = new Size(176, 30);
            btnBackToLogin.TabIndex = 7;
            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.UseTransparentBackground = true;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // ChangePasswordControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(1100, 650);
            BackColor = Color.White;
            Controls.Add(pnlLeft);
            Controls.Add(pnlCard);
            Name = "ChangePasswordControl";
            Size = new Size(1100, 650);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }
    }
}
