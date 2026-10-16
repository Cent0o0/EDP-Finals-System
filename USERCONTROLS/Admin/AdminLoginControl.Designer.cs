namespace Barangay_E_Service_System.USERCONTROLS.Admin
{
    partial class AdminLoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
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
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            lblusername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblpassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BorderColor = Color.Black;
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(292, 284);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderForeColor = Color.Transparent;
            txtUsername.PlaceholderText = "";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(366, 36);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.Black;
            txtPassword.CustomizableEdges = customizableEdges3;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(292, 349);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderForeColor = Color.Transparent;
            txtPassword.PlaceholderText = "";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPassword.Size = new Size(366, 36);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 5;
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.Font = new Font("Segoe UI", 9F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(292, 391);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(180, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            // 
            // btnBack
            // 
            btnBack.BorderRadius = 5;
            btnBack.CustomizableEdges = customizableEdges7;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(478, 391);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnBack.Size = new Size(180, 45);
            btnBack.TabIndex = 5;
            btnBack.Text = "BACK";
            btnBack.Click += btnBack_Click;
            // 
            // lblusername
            // 
            lblusername.BackColor = Color.Transparent;
            lblusername.Location = new Point(292, 261);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(56, 17);
            lblusername.TabIndex = 6;
            lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            lblpassword.BackColor = Color.Transparent;
            lblpassword.Location = new Point(292, 326);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(53, 17);
            lblpassword.TabIndex = 7;
            lblpassword.Text = "Password";
            // 
            // AdminLoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(btnBack);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "AdminLoginControl";
            Size = new Size(950, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblusername;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblpassword;
    }
}
