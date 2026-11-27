namespace Barangay_E_Service_System.USERCONTROLS.Admin
{
    partial class ResidentManagementControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pnlWelcome = new Panel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSearchResident = new Guna.UI2.WinForms.Guna2TextBox();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            dgvResidents = new Guna.UI2.WinForms.Guna2DataGridView();
            lblNoResults = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ResidentID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            RegistrationDate = new DataGridViewTextBoxColumn();
            btnView = new DataGridViewButtonColumn();
            pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResidents).BeginInit();
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
            lblSubtitle.Size = new Size(285, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View and manage registered barangay residents.";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(18, 52, 86);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(251, 34);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Resident Accounts";
            // 
            // txtSearchResident
            // 
            txtSearchResident.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchResident.BorderColor = Color.Black;
            txtSearchResident.BorderRadius = 5;
            txtSearchResident.CustomizableEdges = customizableEdges1;
            txtSearchResident.DefaultText = "";
            txtSearchResident.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchResident.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchResident.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchResident.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchResident.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchResident.Font = new Font("Arial", 10F);
            txtSearchResident.ForeColor = Color.Black;
            txtSearchResident.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchResident.Location = new Point(22, 106);
            txtSearchResident.MaxLength = 200;
            txtSearchResident.Name = "txtSearchResident";
            txtSearchResident.PlaceholderForeColor = SystemColors.ActiveBorder;
            txtSearchResident.PlaceholderText = "Search by ID, name, username, or contact number...";
            txtSearchResident.SelectedText = "";
            txtSearchResident.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchResident.Size = new Size(672, 36);
            txtSearchResident.TabIndex = 16;
            txtSearchResident.TextChanged += txtSearchResident_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.BorderRadius = 5;
            btnRefresh.CustomizableEdges = customizableEdges3;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.FromArgb(18, 52, 86);
            btnRefresh.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(700, 106);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRefresh.Size = new Size(149, 36);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvResidents
            // 
            dgvResidents.AllowUserToAddRows = false;
            dgvResidents.AllowUserToResizeColumns = false;
            dgvResidents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvResidents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvResidents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 52, 86);
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(18, 52, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvResidents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvResidents.ColumnHeadersHeight = 40;
            dgvResidents.Columns.AddRange(new DataGridViewColumn[] { ResidentID, FullName, Username, ContactNumber, Address, RegistrationDate, btnView });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle9.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(22, 138, 145);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvResidents.DefaultCellStyle = dataGridViewCellStyle9;
            dgvResidents.GridColor = Color.FromArgb(226, 232, 240);
            dgvResidents.Location = new Point(22, 163);
            dgvResidents.MultiSelect = false;
            dgvResidents.Name = "dgvResidents";
            dgvResidents.ReadOnly = true;
            dgvResidents.RowHeadersVisible = false;
            dgvResidents.RowTemplate.Height = 30;
            dgvResidents.Size = new Size(827, 455);
            dgvResidents.TabIndex = 18;
            dgvResidents.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvResidents.ThemeStyle.GridColor = Color.FromArgb(226, 232, 240);
            dgvResidents.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(18, 52, 86);
            dgvResidents.ThemeStyle.HeaderStyle.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvResidents.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvResidents.ThemeStyle.HeaderStyle.Height = 40;
            dgvResidents.ThemeStyle.ReadOnly = true;
            dgvResidents.ThemeStyle.RowsStyle.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvResidents.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(51, 65, 85);
            dgvResidents.ThemeStyle.RowsStyle.Height = 30;
            dgvResidents.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(22, 138, 145);
            dgvResidents.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dgvResidents.CellContentClick += dgvResidents_CellContentClick;
            // 
            // lblNoResults
            // 
            lblNoResults.AutoSize = false;
            lblNoResults.BackColor = Color.Transparent;
            lblNoResults.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoResults.Location = new Point(357, 339);
            lblNoResults.Name = "lblNoResults";
            lblNoResults.Size = new Size(142, 63);
            lblNoResults.TabIndex = 2;
            lblNoResults.Text = "No resident found.";
            lblNoResults.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ResidentID
            // 
            ResidentID.DataPropertyName = "ResidentID";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ResidentID.DefaultCellStyle = dataGridViewCellStyle3;
            ResidentID.HeaderText = "ResidentID";
            ResidentID.Name = "ResidentID";
            ResidentID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            FullName.DefaultCellStyle = dataGridViewCellStyle4;
            FullName.HeaderText = "FullName";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 180;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Username.DefaultCellStyle = dataGridViewCellStyle5;
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 150;
            // 
            // ContactNumber
            // 
            ContactNumber.DataPropertyName = "ContactNumber";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ContactNumber.DefaultCellStyle = dataGridViewCellStyle6;
            ContactNumber.HeaderText = "ContactNumber";
            ContactNumber.Name = "ContactNumber";
            ContactNumber.ReadOnly = true;
            ContactNumber.Width = 170;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Address.DefaultCellStyle = dataGridViewCellStyle7;
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 200;
            // 
            // RegistrationDate
            // 
            RegistrationDate.DataPropertyName = "RegistrationDate";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            RegistrationDate.DefaultCellStyle = dataGridViewCellStyle8;
            RegistrationDate.HeaderText = "RegistrationDate";
            RegistrationDate.Name = "RegistrationDate";
            RegistrationDate.ReadOnly = true;
            RegistrationDate.Width = 180;
            // 
            // btnView
            // 
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.HeaderText = "Actions";
            btnView.Name = "btnView";
            btnView.ReadOnly = true;
            btnView.Text = "View";
            btnView.UseColumnTextForButtonValue = true;
            btnView.Width = 90;
            // 
            // ResidentManagementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblNoResults);
            Controls.Add(dgvResidents);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchResident);
            Controls.Add(pnlWelcome);
            Name = "ResidentManagementControl";
            Size = new Size(871, 650);
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResidents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchResident;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2DataGridView dgvResidents;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoResults;
        private DataGridViewTextBoxColumn ResidentID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn RegistrationDate;
        private DataGridViewButtonColumn btnView;
    }
}
