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
            Guna.UI2.WinForms.Suite.CustomizableEdges edges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges edges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges edges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges edges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges edges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges edges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlLeft = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            pnlCard = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblContactNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            btnContinue = new Guna.UI2.WinForms.Guna2Button();
            btnBackToLogin = new Guna.UI2.WinForms.Guna2Button();
            pnlCard.SuspendLayout();
            SuspendLayout();
            //
            // pnlLeft
            //
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.FillColor = Color.FromArgb(18, 52, 86);
            pnlLeft.FillColor2 = Color.FromArgb(18, 52, 86);
            pnlLeft.FillColor3 = Color.FromArgb(18, 52, 86);
            pnlLeft.FillColor4 = Color.FromArgb(18, 52, 86);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
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
            pnlCard.FillColor = SystemColors.ActiveCaption;
            pnlCard.Location = new Point(471, 50);
            pnlCard.Name = "pnlCard";
            pnlCard.ShadowDecoration.CustomizableEdges = edges1;
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
            lblTitle.Size = new Size(195, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Forgot Password";
            //
            // lblSubtitle
            //
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F);
            lblSubtitle.Location = new Point(52, 123);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(392, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Enter your username and contact number to continue.";
            //
            // lblUsername
            //
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblUsername.Location = new Point(52, 182);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(67, 18);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            //
            // txtUsername
            //
            txtUsername.BorderColor = Color.Black;
            txtUsername.BorderRadius = 5;
            txtUsername.CustomizableEdges = edges2;
            txtUsername.Font = new Font("Arial", 9.75F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(52, 207);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = edges3;
            txtUsername.Size = new Size(412, 38);
            txtUsername.TabIndex = 3;
            //
            // lblContactNumber
            //
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblContactNumber.Location = new Point(52, 267);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(105, 18);
            lblContactNumber.TabIndex = 4;
            lblContactNumber.Text = "Contact Number";
            //
            // txtContactNumber
            //
            txtContactNumber.BorderColor = Color.Black;
            txtContactNumber.BorderRadius = 5;
            txtContactNumber.CustomizableEdges = edges4;
            txtContactNumber.Font = new Font("Arial", 9.75F);
            txtContactNumber.ForeColor = Color.Black;
            txtContactNumber.Location = new Point(52, 292);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PlaceholderText = "Enter your registered contact number";
            txtContactNumber.SelectedText = "";
            txtContactNumber.ShadowDecoration.CustomizableEdges = edges5;
            txtContactNumber.Size = new Size(412, 38);
            txtContactNumber.TabIndex = 5;
            //
            // btnContinue
            //
            btnContinue.BorderRadius = 5;
            btnContinue.CustomizableEdges = edges6;
            btnContinue.FillColor = Color.FromArgb(18, 52, 86);
            btnContinue.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(52, 360);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(412, 45);
            btnContinue.TabIndex = 6;
            btnContinue.Text = "Continue";
            btnContinue.Click += btnContinue_Click;
            //
            // btnBackToLogin
            //
            btnBackToLogin.BackColor = Color.Transparent;
            btnBackToLogin.BorderRadius = 5;
            btnBackToLogin.FillColor = Color.Transparent;
            btnBackToLogin.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnBackToLogin.ForeColor = Color.FromArgb(18, 52, 86);
            btnBackToLogin.Location = new Point(170, 427);
            btnBackToLogin.Name = "btnBackToLogin";
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
