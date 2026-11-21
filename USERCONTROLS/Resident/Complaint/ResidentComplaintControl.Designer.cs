namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    partial class ResidentComplaintControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlWelcome = new Panel();
            lblComplaintSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSubmitComplaint = new Guna.UI2.WinForms.Guna2Button();
            dtpIncidentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lblIncidentDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            lblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtIncidentLocation = new Guna.UI2.WinForms.Guna2TextBox();
            lblIncidentLocation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            lblCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // pnlWelcome
            // 
            pnlWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlWelcome.BackColor = Color.FromArgb(234, 245, 245);
            pnlWelcome.Controls.Add(lblComplaintSubtitle);
            pnlWelcome.Controls.Add(lblWelcome);
            pnlWelcome.Location = new Point(0, 0);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(871, 80);
            pnlWelcome.TabIndex = 9;
            // 
            // lblComplaintSubtitle
            // 
            lblComplaintSubtitle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblComplaintSubtitle.BackColor = Color.Transparent;
            lblComplaintSubtitle.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComplaintSubtitle.Location = new Point(22, 54);
            lblComplaintSubtitle.Name = "lblComplaintSubtitle";
            lblComplaintSubtitle.Size = new Size(500, 18);
            lblComplaintSubtitle.TabIndex = 3;
            lblComplaintSubtitle.Text = "Report a community concern to your barangay officials";
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(800, 34);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Submit a Complaint";
            // 
            // btnSubmitComplaint
            // 
            btnSubmitComplaint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmitComplaint.BorderRadius = 5;
            btnSubmitComplaint.CustomizableEdges = customizableEdges1;
            btnSubmitComplaint.DisabledState.BorderColor = Color.DarkGray;
            btnSubmitComplaint.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSubmitComplaint.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSubmitComplaint.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSubmitComplaint.FillColor = Color.FromArgb(18, 52, 86);
            btnSubmitComplaint.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnSubmitComplaint.ForeColor = Color.White;
            btnSubmitComplaint.Location = new Point(592, 530);
            btnSubmitComplaint.Name = "btnSubmitComplaint";
            btnSubmitComplaint.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSubmitComplaint.Size = new Size(225, 42);
            btnSubmitComplaint.TabIndex = 12;
            btnSubmitComplaint.Text = "Submit Complaint";
            btnSubmitComplaint.Click += btnSubmitComplaint_Click;
            // 
            // dtpIncidentDate
            // 
            dtpIncidentDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            dtpIncidentDate.Checked = true;
            dtpIncidentDate.BorderRadius = 5;
            dtpIncidentDate.BorderThickness = 1;
            dtpIncidentDate.BorderColor = Color.Black;
            dtpIncidentDate.CustomizableEdges = customizableEdges3;
            dtpIncidentDate.FillColor = Color.White;
            dtpIncidentDate.Font = new Font("Arial", 10F);
            dtpIncidentDate.Format = DateTimePickerFormat.Long;
            dtpIncidentDate.Location = new Point(57, 446);
            dtpIncidentDate.MaxDate = DateTime.Today;
            dtpIncidentDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpIncidentDate.Name = "dtpIncidentDate";
            dtpIncidentDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpIncidentDate.Size = new Size(350, 36);
            dtpIncidentDate.TabIndex = 11;
            dtpIncidentDate.Value = DateTime.Today;
            // 
            // lblIncidentDate
            // 
            lblIncidentDate.BackColor = Color.Transparent;
            lblIncidentDate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncidentDate.Location = new Point(54, 424);
            lblIncidentDate.Name = "lblIncidentDate";
            lblIncidentDate.Size = new Size(122, 21);
            lblIncidentDate.TabIndex = 10;
            lblIncidentDate.Text = "Date of Incident";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.BorderColor = Color.Black;
            txtDescription.BorderRadius = 5;
            txtDescription.CustomizableEdges = customizableEdges5;
            txtDescription.DefaultText = "";
            txtDescription.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescription.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescription.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescription.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescription.Font = new Font("Arial", 10F);
            txtDescription.ForeColor = Color.Black;
            txtDescription.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescription.Location = new Point(57, 284);
            txtDescription.Multiline = true;
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.MaxLength = 1000;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "";
            txtDescription.SelectedText = "";
            txtDescription.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtDescription.Size = new Size(756, 120);
            txtDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(54, 262);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(168, 21);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Complain Description";
            // 
            // txtIncidentLocation
            // 
            txtIncidentLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIncidentLocation.BorderColor = Color.Black;
            txtIncidentLocation.BorderRadius = 5;
            txtIncidentLocation.CustomizableEdges = customizableEdges7;
            txtIncidentLocation.DefaultText = "";
            txtIncidentLocation.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtIncidentLocation.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtIncidentLocation.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtIncidentLocation.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtIncidentLocation.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtIncidentLocation.Font = new Font("Arial", 10F);
            txtIncidentLocation.ForeColor = Color.Black;
            txtIncidentLocation.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtIncidentLocation.Location = new Point(57, 206);
            txtIncidentLocation.MaxLength = 200;
            txtIncidentLocation.Name = "txtIncidentLocation";
            txtIncidentLocation.PlaceholderText = "";
            txtIncidentLocation.SelectedText = "";
            txtIncidentLocation.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtIncidentLocation.Size = new Size(756, 36);
            txtIncidentLocation.TabIndex = 7;
            // 
            // lblIncidentLocation
            // 
            lblIncidentLocation.BackColor = Color.Transparent;
            lblIncidentLocation.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncidentLocation.Location = new Point(54, 184);
            lblIncidentLocation.Name = "lblIncidentLocation";
            lblIncidentLocation.Size = new Size(129, 21);
            lblIncidentLocation.TabIndex = 6;
            lblIncidentLocation.Text = "Incident location";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategory.BackColor = Color.Transparent;
            cmbCategory.BorderColor = Color.Black;
            cmbCategory.BorderRadius = 5;
            cmbCategory.CustomizableEdges = customizableEdges9;
            cmbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbCategory.Font = new Font("Arial", 10F);
            cmbCategory.ForeColor = Color.Black;
            cmbCategory.ItemHeight = 30;
            cmbCategory.Items.AddRange(new object[] { "Noise Complaint", "Neighbor Dispute", "Garbage or Sanitation", "Public Disturbance", "Property Damage", "Other" });
            cmbCategory.Location = new Point(57, 130);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cmbCategory.Size = new Size(756, 36);
            cmbCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(54, 108);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(155, 21);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Complaint Category";
            // 
            // ResidentComplaintControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 650);
            Controls.Add(btnSubmitComplaint);
            Controls.Add(dtpIncidentDate);
            Controls.Add(lblIncidentDate);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtIncidentLocation);
            Controls.Add(lblIncidentLocation);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(pnlWelcome);
            Name = "ResidentComplaintControl";
            Size = new Size(871, 650);
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblComplaintSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtIncidentLocation;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIncidentLocation;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpIncidentDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIncidentDate;
        private Guna.UI2.WinForms.Guna2Button btnSubmitComplaint;
    }
}
