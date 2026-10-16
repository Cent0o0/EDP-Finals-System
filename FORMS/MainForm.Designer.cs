namespace Barangay_E_Service_System
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            pnlContent = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.CustomizableEdges = customizableEdges1;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.FillColor = Color.DarkGray;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlContent.Size = new Size(934, 611);
            pnlContent.TabIndex = 0;
            // 
            // MainForm
            // 
            ClientSize = new Size(934, 611);
            Controls.Add(pnlContent);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            // Designer-generated control setup
        }

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlContent;
    }
}