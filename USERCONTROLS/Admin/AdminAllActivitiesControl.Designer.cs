namespace Barangay_E_Service_System.USERCONTROLS.Admin
{
    partial class AdminAllActivitiesControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlWelcome = new Panel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSearchActivities = new Guna.UI2.WinForms.Guna2TextBox();
            dgvAllActivities = new Guna.UI2.WinForms.Guna2DataGridView();
            ReferenceID = new DataGridViewTextBoxColumn();
            RequestType = new DataGridViewTextBoxColumn();
            DateSubmitted = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnView = new DataGridViewButtonColumn();
            cmbAction = new DataGridViewComboBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            lblNoActivitiesFound = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllActivities).BeginInit();
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
            pnlWelcome.TabIndex = 12;
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(22, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(371, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View and manage all resident requests and submitted activities.";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(18, 52, 86);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(167, 34);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "All Activities";
            // 
            // txtSearchActivities
            // 
            txtSearchActivities.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchActivities.BorderColor = Color.Black;
            txtSearchActivities.BorderRadius = 5;
            txtSearchActivities.CustomizableEdges = customizableEdges1;
            txtSearchActivities.DefaultText = "";
            txtSearchActivities.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchActivities.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchActivities.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchActivities.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchActivities.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchActivities.Font = new Font("Arial", 10F);
            txtSearchActivities.ForeColor = Color.Black;
            txtSearchActivities.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchActivities.Location = new Point(22, 106);
            txtSearchActivities.MaxLength = 200;
            txtSearchActivities.Name = "txtSearchActivities";
            txtSearchActivities.PlaceholderForeColor = SystemColors.ActiveBorder;
            txtSearchActivities.PlaceholderText = "Search by Reference ID, Request Type, etc.....";
            txtSearchActivities.SelectedText = "";
            txtSearchActivities.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchActivities.Size = new Size(827, 36);
            txtSearchActivities.TabIndex = 18;
            // 
            // dgvAllActivities
            // 
            dgvAllActivities.AllowUserToAddRows = false;
            dgvAllActivities.AllowUserToDeleteRows = false;
            dgvAllActivities.AllowUserToResizeColumns = false;
            dgvAllActivities.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvAllActivities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAllActivities.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 52, 86);
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(18, 52, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAllActivities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAllActivities.ColumnHeadersHeight = 35;
            dgvAllActivities.Columns.AddRange(new DataGridViewColumn[] { ReferenceID, RequestType, DateSubmitted, Status, btnView, cmbAction, btnDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAllActivities.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAllActivities.GridColor = Color.FromArgb(226, 232, 240);
            dgvAllActivities.Location = new Point(23, 164);
            dgvAllActivities.MultiSelect = false;
            dgvAllActivities.Name = "dgvAllActivities";
            dgvAllActivities.RowHeadersVisible = false;
            dgvAllActivities.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAllActivities.RowTemplate.Height = 30;
            dgvAllActivities.Size = new Size(826, 471);
            dgvAllActivities.TabIndex = 20;
            dgvAllActivities.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvAllActivities.ThemeStyle.GridColor = Color.FromArgb(226, 232, 240);
            dgvAllActivities.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(18, 52, 86);
            dgvAllActivities.ThemeStyle.HeaderStyle.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvAllActivities.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAllActivities.ThemeStyle.HeaderStyle.Height = 35;
            dgvAllActivities.ThemeStyle.RowsStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvAllActivities.ThemeStyle.RowsStyle.Height = 30;
            // 
            // ReferenceID
            // 
            ReferenceID.DataPropertyName = "ReferenceID";
            ReferenceID.HeaderText = "Reference ID";
            ReferenceID.Name = "ReferenceID";
            // 
            // RequestType
            // 
            RequestType.DataPropertyName = "RequestType";
            RequestType.HeaderText = "Request Type";
            RequestType.Name = "RequestType";
            // 
            // DateSubmitted
            // 
            DateSubmitted.DataPropertyName = "DateSubmitted";
            DateSubmitted.HeaderText = "Date Submitted";
            DateSubmitted.Name = "DateSubmitted";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // btnView
            // 
            btnView.HeaderText = "View";
            btnView.Name = "btnView";
            btnView.Text = "View";
            btnView.UseColumnTextForButtonValue = true;
            // 
            // cmbAction
            // 
            cmbAction.HeaderText = "Action";
            cmbAction.Items.AddRange(new object[] { "Approve", "Reject" });
            cmbAction.Name = "cmbAction";
            cmbAction.Resizable = DataGridViewTriState.True;
            cmbAction.ToolTipText = "Approve / Reject";
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // lblNoActivitiesFound
            // 
            lblNoActivitiesFound.AutoSize = false;
            lblNoActivitiesFound.BackColor = Color.Transparent;
            lblNoActivitiesFound.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoActivitiesFound.Location = new Point(339, 381);
            lblNoActivitiesFound.Name = "lblNoActivitiesFound";
            lblNoActivitiesFound.Size = new Size(142, 63);
            lblNoActivitiesFound.TabIndex = 21;
            lblNoActivitiesFound.Text = "No activities found.";
            lblNoActivitiesFound.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // AdminAllActivitiesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblNoActivitiesFound);
            Controls.Add(dgvAllActivities);
            Controls.Add(txtSearchActivities);
            Controls.Add(pnlWelcome);
            Name = "AdminAllActivitiesControl";
            Size = new Size(871, 650);
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllActivities).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchActivities;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAllActivities;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoActivitiesFound;
        private DataGridViewTextBoxColumn ReferenceID;
        private DataGridViewTextBoxColumn RequestType;
        private DataGridViewTextBoxColumn DateSubmitted;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn btnView;
        private DataGridViewComboBoxColumn cmbAction;
        private DataGridViewButtonColumn btnDelete;
    }
}
