namespace Barangay_E_Service_System.USERCONTROLS.Admin
{
    partial class EquipmentReservationManagementControl
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
            pnlWelcome = new Panel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // pnlWelcome
            // 
            pnlWelcome.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlWelcome.BackColor = Color.FromArgb(234, 245, 245);
            pnlWelcome.Controls.Add(lblSubtitle);
            pnlWelcome.Controls.Add(lblWelcome);
            pnlWelcome.Location = new Point(0, 0);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(871, 80);
            pnlWelcome.TabIndex = 14;
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(22, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(333, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View barangay requests and account activity at a glance.";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(18, 52, 86);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(396, 34);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to the Admin Portal!";
            // 
            // EquipmentReservationManagementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlWelcome);
            Name = "EquipmentReservationManagementControl";
            Size = new Size(871, 650);
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
    }
}
