namespace Barangay_E_Service_System.USERCONTROLS.Shared
{
    partial class RoleSelectionControl
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
            btnResident = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnResident
            // 
            btnResident.Anchor = AnchorStyles.None;
            btnResident.BorderRadius = 5;
            btnResident.CustomizableEdges = customizableEdges1;
            btnResident.DisabledState.BorderColor = Color.DarkGray;
            btnResident.DisabledState.CustomBorderColor = Color.DarkGray;
            btnResident.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnResident.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnResident.Font = new Font("Segoe UI", 9F);
            btnResident.ForeColor = Color.White;
            btnResident.Location = new Point(241, 340);
            btnResident.Name = "btnResident";
            btnResident.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnResident.Size = new Size(180, 93);
            btnResident.TabIndex = 0;
            btnResident.Text = "RESIDENT";
            btnResident.Click += btnResident_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(506, 346);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(0, 0);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "guna2Button2";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Location = new Point(363, 208);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 17);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "BARANGAY E-SERVICE SYSTEM";
            lblTitle.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Anchor = AnchorStyles.Top;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Location = new Point(376, 242);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(142, 17);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Choose your account type";
            lblSubtitle.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnAdmin
            // 
            btnAdmin.Anchor = AnchorStyles.None;
            btnAdmin.BorderRadius = 5;
            btnAdmin.CustomizableEdges = customizableEdges5;
            btnAdmin.DisabledState.BorderColor = Color.DarkGray;
            btnAdmin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdmin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdmin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdmin.Font = new Font("Segoe UI", 9F);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(461, 340);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAdmin.Size = new Size(180, 93);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "ADMIN";
            btnAdmin.Click += btnAdmin_Click;
            // 
            // RoleSelectionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdmin);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(guna2Button2);
            Controls.Add(btnResident);
            Name = "RoleSelectionControl";
            Size = new Size(950, 650);
            Load += RoleSelectionControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnResident;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
    }
}
