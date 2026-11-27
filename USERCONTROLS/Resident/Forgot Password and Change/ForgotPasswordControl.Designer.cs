using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    partial class ForgotPasswordControl
    {
        private IContainer components = null!;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlLeft = null!;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlCard = null!;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle = null!;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle = null!;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername = null!;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContactNumber = null!;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername = null!;
        private Guna.UI2.WinForms.Guna2TextBox txtContactNumber = null!;
        private Guna.UI2.WinForms.Guna2Button btnContinue = null!;
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
            lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            lblContactNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            btnContinue = new Guna.UI2.WinForms.Guna2Button();
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
            pnlCard.Controls.Add(lblUsername);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblContactNumber);
            pnlCard.Controls.Add(txtContactNumber);
            pnlCard.Controls.Add(btnContinue);
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
            lblTitle.Size = new Size(228, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Forgot Password";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F);
            lblSubtitle.Location = new Point(52, 123);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(315, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Enter your username and contact number to continue.";
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(52, 182);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(70, 17);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderColor = Color.Black;
            txtUsername.BorderRadius = 5;
            txtUsername.CustomizableEdges = customizableEdges3;
            txtUsername.DefaultText = "";
            txtUsername.Font = new Font("Arial", 9.75F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(52, 207);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUsername.Size = new Size(412, 38);
            txtUsername.TabIndex = 3;
            // 
            // lblContactNumber
            // 
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactNumber.Location = new Point(52, 267);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(110, 17);
            lblContactNumber.TabIndex = 4;
            lblContactNumber.Text = "Contact Number";
            // 
            // txtContactNumber
            // 
            txtContactNumber.BorderColor = Color.Black;
            txtContactNumber.BorderRadius = 5;
            txtContactNumber.CustomizableEdges = customizableEdges5;
            txtContactNumber.DefaultText = "";
            txtContactNumber.Font = new Font("Arial", 9.75F);
            txtContactNumber.ForeColor = Color.Black;
            txtContactNumber.Location = new Point(52, 292);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PlaceholderText = "Enter your registered contact number";
            txtContactNumber.SelectedText = "";
            txtContactNumber.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtContactNumber.Size = new Size(412, 38);
            txtContactNumber.TabIndex = 5;
            // 
            // btnContinue
            // 
            btnContinue.BorderRadius = 5;
            btnContinue.CustomizableEdges = customizableEdges7;
            btnContinue.FillColor = Color.FromArgb(18, 52, 86);
            btnContinue.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(52, 360);
            btnContinue.Name = "btnContinue";
            btnContinue.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnContinue.Size = new Size(412, 45);
            btnContinue.TabIndex = 6;
            btnContinue.Text = "Continue";
            btnContinue.Click += btnContinue_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.Transparent;
            btnBackToLogin.BorderRadius = 5;
            btnBackToLogin.CustomizableEdges = customizableEdges9;
            btnBackToLogin.FillColor = Color.Transparent;
            btnBackToLogin.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // ForgotPasswordControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(1100, 650);
            BackColor = Color.White;
            Controls.Add(pnlLeft);
            Controls.Add(pnlCard);
            Name = "ForgotPasswordControl";
            Size = new Size(1100, 650);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }
    }
}
