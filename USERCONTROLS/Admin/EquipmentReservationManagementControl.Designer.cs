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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlWelcome = new Panel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnAddEquipment = new Guna.UI2.WinForms.Guna2Button();
            txtSearchEquipment = new Guna.UI2.WinForms.Guna2TextBox();
            dgvEquipment = new Guna.UI2.WinForms.Guna2DataGridView();
            EquipmentID = new DataGridViewTextBoxColumn();
            EquipmentName = new DataGridViewTextBoxColumn();
            TotalQuantity = new DataGridViewTextBoxColumn();
            AvailableQuantity = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            pnlEquipmentForm = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnSaveEquipment = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbStatus = new ComboBox();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtTotalQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtEquipmentName = new Guna.UI2.WinForms.Guna2TextBox();
            lblEquipmentFormTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            pnlEquipmentForm.SuspendLayout();
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
            lblSubtitle.Size = new Size(616, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage equipment details, update quantities, and maintain equipment availability for resident reservations.";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(18, 52, 86);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(487, 34);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Equipment Reservation Management";
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddEquipment.BorderRadius = 5;
            btnAddEquipment.CustomizableEdges = customizableEdges1;
            btnAddEquipment.DisabledState.BorderColor = Color.DarkGray;
            btnAddEquipment.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddEquipment.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddEquipment.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddEquipment.FillColor = Color.FromArgb(18, 52, 86);
            btnAddEquipment.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnAddEquipment.ForeColor = Color.White;
            btnAddEquipment.Location = new Point(700, 107);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddEquipment.Size = new Size(149, 36);
            btnAddEquipment.TabIndex = 19;
            btnAddEquipment.Text = "Add Equipment";
            btnAddEquipment.Click += btnAddEquipment_Click_1;
            // 
            // txtSearchEquipment
            // 
            txtSearchEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchEquipment.BorderColor = Color.Black;
            txtSearchEquipment.BorderRadius = 5;
            txtSearchEquipment.CustomizableEdges = customizableEdges3;
            txtSearchEquipment.DefaultText = "";
            txtSearchEquipment.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchEquipment.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchEquipment.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchEquipment.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchEquipment.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchEquipment.Font = new Font("Arial", 10F);
            txtSearchEquipment.ForeColor = Color.Black;
            txtSearchEquipment.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchEquipment.Location = new Point(22, 107);
            txtSearchEquipment.MaxLength = 200;
            txtSearchEquipment.Name = "txtSearchEquipment";
            txtSearchEquipment.PlaceholderForeColor = SystemColors.ActiveBorder;
            txtSearchEquipment.PlaceholderText = "Search equipment by name...";
            txtSearchEquipment.SelectedText = "";
            txtSearchEquipment.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearchEquipment.Size = new Size(672, 36);
            txtSearchEquipment.TabIndex = 18;
            txtSearchEquipment.TextChanged += txtSearchEquipment_TextChanged;
            // 
            // dgvEquipment
            // 
            dgvEquipment.AllowUserToAddRows = false;
            dgvEquipment.AllowUserToDeleteRows = false;
            dgvEquipment.AllowUserToResizeColumns = false;
            dgvEquipment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvEquipment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 52, 86);
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(18, 52, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEquipment.ColumnHeadersHeight = 35;
            dgvEquipment.Columns.AddRange(new DataGridViewColumn[] { EquipmentID, EquipmentName, TotalQuantity, AvailableQuantity, Status, btnEdit, btnDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEquipment.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEquipment.GridColor = Color.FromArgb(226, 232, 240);
            dgvEquipment.Location = new Point(20, 167);
            dgvEquipment.MultiSelect = false;
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersVisible = false;
            dgvEquipment.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvEquipment.RowTemplate.Height = 30;
            dgvEquipment.Size = new Size(826, 465);
            dgvEquipment.TabIndex = 21;
            dgvEquipment.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvEquipment.ThemeStyle.GridColor = Color.FromArgb(226, 232, 240);
            dgvEquipment.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(18, 52, 86);
            dgvEquipment.ThemeStyle.HeaderStyle.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvEquipment.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEquipment.ThemeStyle.HeaderStyle.Height = 35;
            dgvEquipment.ThemeStyle.RowsStyle.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvEquipment.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(51, 65, 85);
            dgvEquipment.ThemeStyle.RowsStyle.Height = 30;
            dgvEquipment.ThemeStyle.RowsStyle.SelectionBackColor = Color.Teal;
            dgvEquipment.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dgvEquipment.CellContentClick += dgvEquipment_CellContentClick;
            // 
            // EquipmentID
            // 
            EquipmentID.DataPropertyName = "EquipmentID";
            EquipmentID.HeaderText = "EquipmentID";
            EquipmentID.Name = "EquipmentID";
            EquipmentID.ReadOnly = true;
            // 
            // EquipmentName
            // 
            EquipmentName.DataPropertyName = "EquipmentName";
            EquipmentName.HeaderText = "Equipment Name";
            EquipmentName.Name = "EquipmentName";
            // 
            // TotalQuantity
            // 
            TotalQuantity.DataPropertyName = "TotalQuantity";
            TotalQuantity.HeaderText = "Total Quantity";
            TotalQuantity.Name = "TotalQuantity";
            // 
            // AvailableQuantity
            // 
            AvailableQuantity.DataPropertyName = "AvailableQuantity";
            AvailableQuantity.HeaderText = "Available Quantity";
            AvailableQuantity.Name = "AvailableQuantity";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.HeaderText = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // pnlEquipmentForm
            // 
            pnlEquipmentForm.BorderColor = Color.Black;
            pnlEquipmentForm.BorderRadius = 10;
            pnlEquipmentForm.BorderThickness = 1;
            pnlEquipmentForm.Controls.Add(btnCancel);
            pnlEquipmentForm.Controls.Add(btnSaveEquipment);
            pnlEquipmentForm.Controls.Add(guna2HtmlLabel4);
            pnlEquipmentForm.Controls.Add(cmbStatus);
            pnlEquipmentForm.Controls.Add(guna2HtmlLabel3);
            pnlEquipmentForm.Controls.Add(txtTotalQuantity);
            pnlEquipmentForm.Controls.Add(guna2HtmlLabel2);
            pnlEquipmentForm.Controls.Add(txtEquipmentName);
            pnlEquipmentForm.Controls.Add(lblEquipmentFormTitle);
            pnlEquipmentForm.CustomizableEdges = customizableEdges13;
            pnlEquipmentForm.FillColor = Color.Gainsboro;
            pnlEquipmentForm.FillColor2 = Color.Gainsboro;
            pnlEquipmentForm.FillColor3 = Color.Gainsboro;
            pnlEquipmentForm.FillColor4 = Color.Gainsboro;
            pnlEquipmentForm.Location = new Point(178, 167);
            pnlEquipmentForm.Name = "pnlEquipmentForm";
            pnlEquipmentForm.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pnlEquipmentForm.Size = new Size(460, 296);
            pnlEquipmentForm.TabIndex = 22;
            pnlEquipmentForm.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BorderColor = Color.FromArgb(192, 0, 0);
            btnCancel.BorderRadius = 5;
            btnCancel.BorderThickness = 1;
            btnCancel.CustomizableEdges = customizableEdges5;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.Transparent;
            btnCancel.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(288, 253);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCancel.Size = new Size(72, 31);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveEquipment
            // 
            btnSaveEquipment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveEquipment.BorderRadius = 5;
            btnSaveEquipment.CustomizableEdges = customizableEdges7;
            btnSaveEquipment.DisabledState.BorderColor = Color.DarkGray;
            btnSaveEquipment.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSaveEquipment.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSaveEquipment.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSaveEquipment.FillColor = Color.FromArgb(18, 52, 86);
            btnSaveEquipment.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnSaveEquipment.ForeColor = Color.White;
            btnSaveEquipment.Location = new Point(371, 253);
            btnSaveEquipment.Name = "btnSaveEquipment";
            btnSaveEquipment.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSaveEquipment.Size = new Size(73, 31);
            btnSaveEquipment.TabIndex = 23;
            btnSaveEquipment.Text = "Save";
            btnSaveEquipment.Click += btnSaveEquipment_Click;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = Color.Black;
            guna2HtmlLabel4.Location = new Point(251, 123);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(42, 18);
            guna2HtmlLabel4.TabIndex = 28;
            guna2HtmlLabel4.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.White;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Arial", 9.75F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Not Available" });
            cmbStatus.Location = new Point(251, 147);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(176, 24);
            cmbStatus.TabIndex = 27;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = Color.Black;
            guna2HtmlLabel3.Location = new Point(17, 118);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(92, 18);
            guna2HtmlLabel3.TabIndex = 26;
            guna2HtmlLabel3.Text = "Total Quantity";
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalQuantity.BorderColor = Color.Black;
            txtTotalQuantity.BorderRadius = 5;
            txtTotalQuantity.CustomizableEdges = customizableEdges9;
            txtTotalQuantity.DefaultText = "";
            txtTotalQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTotalQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTotalQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTotalQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTotalQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTotalQuantity.Font = new Font("Arial", 10F);
            txtTotalQuantity.ForeColor = Color.Black;
            txtTotalQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTotalQuantity.Location = new Point(17, 142);
            txtTotalQuantity.MaxLength = 200;
            txtTotalQuantity.Name = "txtTotalQuantity";
            txtTotalQuantity.PlaceholderForeColor = SystemColors.ActiveBorder;
            txtTotalQuantity.PlaceholderText = "Enter total quantity";
            txtTotalQuantity.SelectedText = "";
            txtTotalQuantity.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtTotalQuantity.Size = new Size(200, 36);
            txtTotalQuantity.TabIndex = 25;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.Black;
            guna2HtmlLabel2.Location = new Point(16, 45);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(112, 18);
            guna2HtmlLabel2.TabIndex = 24;
            guna2HtmlLabel2.Text = "Equipment Name";
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEquipmentName.BorderColor = Color.Black;
            txtEquipmentName.BorderRadius = 5;
            txtEquipmentName.CustomizableEdges = customizableEdges11;
            txtEquipmentName.DefaultText = "";
            txtEquipmentName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEquipmentName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEquipmentName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEquipmentName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEquipmentName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEquipmentName.Font = new Font("Arial", 10F);
            txtEquipmentName.ForeColor = Color.Black;
            txtEquipmentName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEquipmentName.Location = new Point(16, 69);
            txtEquipmentName.MaxLength = 200;
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.PlaceholderForeColor = SystemColors.ActiveBorder;
            txtEquipmentName.PlaceholderText = "Enter equipment name";
            txtEquipmentName.SelectedText = "";
            txtEquipmentName.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtEquipmentName.Size = new Size(430, 36);
            txtEquipmentName.TabIndex = 23;
            // 
            // lblEquipmentFormTitle
            // 
            lblEquipmentFormTitle.BackColor = Color.Transparent;
            lblEquipmentFormTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentFormTitle.ForeColor = Color.FromArgb(18, 52, 86);
            lblEquipmentFormTitle.Location = new Point(13, 6);
            lblEquipmentFormTitle.Name = "lblEquipmentFormTitle";
            lblEquipmentFormTitle.Size = new Size(121, 21);
            lblEquipmentFormTitle.TabIndex = 1;
            lblEquipmentFormTitle.Text = "Add Equipment";
            // 
            // EquipmentReservationManagementControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlEquipmentForm);
            Controls.Add(dgvEquipment);
            Controls.Add(btnAddEquipment);
            Controls.Add(txtSearchEquipment);
            Controls.Add(pnlWelcome);
            Name = "EquipmentReservationManagementControl";
            Size = new Size(871, 650);
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            pnlEquipmentForm.ResumeLayout(false);
            pnlEquipmentForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2Button btnAddEquipment;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchEquipment;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEquipment;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlEquipmentForm;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtEquipmentName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEquipmentFormTitle;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSaveEquipment;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private ComboBox cmbStatus;
        private DataGridViewTextBoxColumn EquipmentID;
        private DataGridViewTextBoxColumn EquipmentName;
        private DataGridViewTextBoxColumn TotalQuantity;
        private DataGridViewTextBoxColumn AvailableQuantity;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
    }
}
