using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    partial class ResidentHomeContentControl
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRecentRequests;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRecentRequests;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlPending;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPendingCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPending;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlApproved;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblApprovedCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblApproved;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTotalRequests;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalRequests;
        private Panel pnlWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvRecentRequests = new Guna.UI2.WinForms.Guna2DataGridView();
            ReferenceID = new DataGridViewTextBoxColumn();
            colRequestType = new DataGridViewTextBoxColumn();
            colDateRequested = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            btnView = new DataGridViewButtonColumn();
            lblRecentRequests = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlPending = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            lblPendingCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblPending = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlApproved = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            lblApprovedCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblApproved = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlTotalRequests = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            lblTotalCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTotalRequests = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlWelcome = new Panel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dgvRecentRequests).BeginInit();
            pnlPending.SuspendLayout();
            pnlApproved.SuspendLayout();
            pnlTotalRequests.SuspendLayout();
            pnlWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRecentRequests
            // 
            dgvRecentRequests.AllowUserToAddRows = false;
            dgvRecentRequests.AllowUserToDeleteRows = false;
            dgvRecentRequests.AllowUserToResizeColumns = false;
            dgvRecentRequests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvRecentRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentRequests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentRequests.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 52, 86);
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(18, 52, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRecentRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentRequests.ColumnHeadersHeight = 35;
            dgvRecentRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvRecentRequests.Columns.AddRange(new DataGridViewColumn[] { ReferenceID, colRequestType, colDateRequested, colStatus, btnView });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRecentRequests.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRecentRequests.GridColor = Color.FromArgb(226, 232, 240);
            dgvRecentRequests.Location = new Point(19, 283);
            dgvRecentRequests.MultiSelect = false;
            dgvRecentRequests.Name = "dgvRecentRequests";
            dgvRecentRequests.ReadOnly = true;
            dgvRecentRequests.RowHeadersVisible = false;
            dgvRecentRequests.RowTemplate.Height = 30;
            dgvRecentRequests.Size = new Size(824, 345);
            dgvRecentRequests.TabIndex = 0;
            dgvRecentRequests.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvRecentRequests.ThemeStyle.BackColor = Color.Gainsboro;
            dgvRecentRequests.ThemeStyle.GridColor = Color.FromArgb(226, 232, 240);
            dgvRecentRequests.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(18, 52, 86);
            dgvRecentRequests.ThemeStyle.HeaderStyle.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvRecentRequests.ThemeStyle.HeaderStyle.Height = 35;
            dgvRecentRequests.ThemeStyle.ReadOnly = true;
            dgvRecentRequests.ThemeStyle.RowsStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvRecentRequests.ThemeStyle.RowsStyle.Height = 30;
            dgvRecentRequests.CellContentClick += dgvRecentRequests_CellContentClick;
            // 
            // ReferenceID
            // 
            ReferenceID.DataPropertyName = "ReferenceID";
            ReferenceID.FillWeight = 18F;
            ReferenceID.HeaderText = "Reference ID";
            ReferenceID.Name = "ReferenceID";
            ReferenceID.ReadOnly = true;
            // 
            // colRequestType
            // 
            colRequestType.DataPropertyName = "RequestType";
            colRequestType.FillWeight = 30F;
            colRequestType.HeaderText = "Request Type";
            colRequestType.Name = "colRequestType";
            colRequestType.ReadOnly = true;
            // 
            // colDateRequested
            // 
            colDateRequested.DataPropertyName = "DateRequested";
            dataGridViewCellStyle3.Format = "MMM d, yyyy h:mm tt";
            dataGridViewCellStyle3.NullValue = "Not recorded";
            colDateRequested.DefaultCellStyle = dataGridViewCellStyle3;
            colDateRequested.FillWeight = 22F;
            colDateRequested.HeaderText = "Date Requested";
            colDateRequested.Name = "colDateRequested";
            colDateRequested.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.FillWeight = 12F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // btnView
            // 
            btnView.FillWeight = 18F;
            btnView.HeaderText = "View";
            btnView.Name = "btnView";
            btnView.ReadOnly = true;
            btnView.Text = "View";
            btnView.UseColumnTextForButtonValue = true;
            // 
            // lblRecentRequests
            // 
            lblRecentRequests.BackColor = Color.Transparent;
            lblRecentRequests.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentRequests.Location = new Point(22, 251);
            lblRecentRequests.Name = "lblRecentRequests";
            lblRecentRequests.Size = new Size(161, 26);
            lblRecentRequests.TabIndex = 1;
            lblRecentRequests.Text = "Recent Activities";
            // 
            // pnlPending
            // 
            pnlPending.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlPending.BackColor = Color.White;
            pnlPending.Controls.Add(lblPendingCount);
            pnlPending.Controls.Add(lblPending);
            pnlPending.CustomizableEdges = customizableEdges1;
            pnlPending.FillColor = Color.Gainsboro;
            pnlPending.FillColor2 = Color.Gainsboro;
            pnlPending.FillColor3 = Color.Gainsboro;
            pnlPending.FillColor4 = Color.Gainsboro;
            pnlPending.Location = new Point(613, 110);
            pnlPending.Name = "pnlPending";
            pnlPending.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlPending.Size = new Size(230, 125);
            pnlPending.TabIndex = 2;
            // 
            // lblPendingCount
            // 
            lblPendingCount.BackColor = Color.Transparent;
            lblPendingCount.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.Location = new Point(106, 60);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(18, 34);
            lblPendingCount.TabIndex = 3;
            lblPendingCount.Text = "0";
            lblPendingCount.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblPending
            // 
            lblPending.BackColor = Color.Transparent;
            lblPending.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPending.Location = new Point(82, 16);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(67, 21);
            lblPending.TabIndex = 4;
            lblPending.Text = "Pending";
            // 
            // pnlApproved
            // 
            pnlApproved.Anchor = AnchorStyles.Top;
            pnlApproved.BackColor = Color.White;
            pnlApproved.Controls.Add(lblApprovedCount);
            pnlApproved.Controls.Add(lblApproved);
            pnlApproved.CustomizableEdges = customizableEdges3;
            pnlApproved.FillColor = Color.Gainsboro;
            pnlApproved.FillColor2 = Color.Gainsboro;
            pnlApproved.FillColor3 = Color.Gainsboro;
            pnlApproved.FillColor4 = Color.Gainsboro;
            pnlApproved.Location = new Point(321, 110);
            pnlApproved.Name = "pnlApproved";
            pnlApproved.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlApproved.Size = new Size(230, 125);
            pnlApproved.TabIndex = 5;
            // 
            // lblApprovedCount
            // 
            lblApprovedCount.BackColor = Color.Transparent;
            lblApprovedCount.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApprovedCount.Location = new Point(106, 60);
            lblApprovedCount.Name = "lblApprovedCount";
            lblApprovedCount.Size = new Size(18, 34);
            lblApprovedCount.TabIndex = 6;
            lblApprovedCount.Text = "0";
            lblApprovedCount.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblApproved
            // 
            lblApproved.BackColor = Color.Transparent;
            lblApproved.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApproved.Location = new Point(76, 16);
            lblApproved.Name = "lblApproved";
            lblApproved.Size = new Size(78, 21);
            lblApproved.TabIndex = 7;
            lblApproved.Text = "Approved";
            // 
            // pnlTotalRequests
            // 
            pnlTotalRequests.BackColor = Color.White;
            pnlTotalRequests.Controls.Add(lblTotalCount);
            pnlTotalRequests.Controls.Add(lblTotalRequests);
            pnlTotalRequests.CustomizableEdges = customizableEdges5;
            pnlTotalRequests.FillColor = Color.Gainsboro;
            pnlTotalRequests.FillColor2 = Color.Gainsboro;
            pnlTotalRequests.FillColor3 = Color.Gainsboro;
            pnlTotalRequests.FillColor4 = Color.Gainsboro;
            pnlTotalRequests.Location = new Point(22, 110);
            pnlTotalRequests.Name = "pnlTotalRequests";
            pnlTotalRequests.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlTotalRequests.Size = new Size(230, 125);
            pnlTotalRequests.TabIndex = 8;
            // 
            // lblTotalCount
            // 
            lblTotalCount.BackColor = Color.Transparent;
            lblTotalCount.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCount.Location = new Point(103, 60);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(18, 34);
            lblTotalCount.TabIndex = 9;
            lblTotalCount.Text = "0";
            lblTotalCount.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTotalRequests
            // 
            lblTotalRequests.BackColor = Color.Transparent;
            lblTotalRequests.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRequests.Location = new Point(56, 16);
            lblTotalRequests.Name = "lblTotalRequests";
            lblTotalRequests.Size = new Size(118, 21);
            lblTotalRequests.TabIndex = 10;
            lblTotalRequests.Text = "Total Requests";
            // 
            // pnlWelcome
            // 
            pnlWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlWelcome.BackColor = Color.FromArgb(234, 245, 245);
            pnlWelcome.Controls.Add(lblSubtitle);
            pnlWelcome.Controls.Add(lblWelcome);
            pnlWelcome.Location = new Point(0, 0);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(871, 80);
            pnlWelcome.TabIndex = 11;
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(22, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(305, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View your requests and account activity at a glance.";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(18, 52, 86);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(425, 34);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to the Resident Portal!";
            // 
            // ResidentHomeContentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 650);
            Controls.Add(dgvRecentRequests);
            Controls.Add(lblRecentRequests);
            Controls.Add(pnlPending);
            Controls.Add(pnlApproved);
            Controls.Add(pnlTotalRequests);
            Controls.Add(pnlWelcome);
            Name = "ResidentHomeContentControl";
            Size = new Size(871, 650);
            ((System.ComponentModel.ISupportInitialize)dgvRecentRequests).EndInit();
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            pnlApproved.ResumeLayout(false);
            pnlApproved.PerformLayout();
            pnlTotalRequests.ResumeLayout(false);
            pnlTotalRequests.PerformLayout();
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn ReferenceID;
        private DataGridViewTextBoxColumn colRequestType;
        private DataGridViewTextBoxColumn colDateRequested;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn btnView;
    }
}
