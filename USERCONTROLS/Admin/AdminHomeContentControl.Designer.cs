using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Admin
{
    partial class AdminHomeContentControl
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvRecentRequests = new Guna.UI2.WinForms.Guna2DataGridView();
            ReferenceID = new DataGridViewTextBoxColumn();
            RequestType = new DataGridViewTextBoxColumn();
            DateSubmitted = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnView = new DataGridViewButtonColumn();
            btnAction = new DataGridViewComboBoxColumn();
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
            pnlDashboardContent = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dgvRecentRequests).BeginInit();
            pnlPending.SuspendLayout();
            pnlApproved.SuspendLayout();
            pnlTotalRequests.SuspendLayout();
            pnlWelcome.SuspendLayout();
            guna2CustomGradientPanel1.SuspendLayout();
            guna2CustomGradientPanel2.SuspendLayout();
            guna2CustomGradientPanel3.SuspendLayout();
            guna2CustomGradientPanel4.SuspendLayout();
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
            dgvRecentRequests.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvRecentRequests.Columns.AddRange(new DataGridViewColumn[] { ReferenceID, RequestType, DateSubmitted, Status, btnView, btnAction });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRecentRequests.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRecentRequests.GridColor = Color.FromArgb(226, 232, 240);
            dgvRecentRequests.Location = new Point(22, 504);
            dgvRecentRequests.MultiSelect = false;
            dgvRecentRequests.Name = "dgvRecentRequests";
            dgvRecentRequests.ReadOnly = true;
            dgvRecentRequests.RowHeadersVisible = false;
            dgvRecentRequests.RowTemplate.Height = 30;
            dgvRecentRequests.Size = new Size(826, 292);
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
            // 
            // ReferenceID
            // 
            ReferenceID.HeaderText = "Reference ID";
            ReferenceID.Name = "ReferenceID";
            ReferenceID.ReadOnly = true;
            // 
            // RequestType
            // 
            RequestType.HeaderText = "Request Type";
            RequestType.Name = "RequestType";
            RequestType.ReadOnly = true;
            // 
            // DateSubmitted
            // 
            DateSubmitted.DataPropertyName = "DateSubmitted";
            DateSubmitted.HeaderText = "Date Submitted";
            DateSubmitted.Name = "DateSubmitted";
            DateSubmitted.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // btnView
            // 
            btnView.HeaderText = "View";
            btnView.Name = "btnView";
            btnView.ReadOnly = true;
            btnView.Text = "View";
            // 
            // btnAction
            // 
            btnAction.HeaderText = "Action";
            btnAction.Items.AddRange(new object[] { "Approve", "Reject" });
            btnAction.Name = "btnAction";
            btnAction.ReadOnly = true;
            btnAction.Resizable = DataGridViewTriState.True;
            btnAction.ToolTipText = "Approve / Reject";
            // 
            // lblRecentRequests
            // 
            lblRecentRequests.BackColor = Color.Transparent;
            lblRecentRequests.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentRequests.Location = new Point(40, 511);
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
            pnlPending.Location = new Point(681, 105);
            pnlPending.Name = "pnlPending";
            pnlPending.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlPending.Size = new Size(150, 150);
            pnlPending.TabIndex = 2;
            // 
            // lblPendingCount
            // 
            lblPendingCount.BackColor = Color.Transparent;
            lblPendingCount.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.Location = new Point(65, 62);
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
            lblPending.Location = new Point(44, 9);
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
            pnlApproved.Location = new Point(464, 105);
            pnlApproved.Name = "pnlApproved";
            pnlApproved.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlApproved.Size = new Size(150, 150);
            pnlApproved.TabIndex = 5;
            // 
            // lblApprovedCount
            // 
            lblApprovedCount.BackColor = Color.Transparent;
            lblApprovedCount.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApprovedCount.Location = new Point(63, 62);
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
            lblApproved.Location = new Point(34, 9);
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
            pnlTotalRequests.Location = new Point(242, 105);
            pnlTotalRequests.Name = "pnlTotalRequests";
            pnlTotalRequests.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlTotalRequests.Size = new Size(150, 150);
            pnlTotalRequests.TabIndex = 8;
            // 
            // lblTotalCount
            // 
            lblTotalCount.BackColor = Color.Transparent;
            lblTotalCount.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCount.Location = new Point(64, 62);
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
            lblTotalRequests.Location = new Point(16, 9);
            lblTotalRequests.Name = "lblTotalRequests";
            lblTotalRequests.Size = new Size(118, 21);
            lblTotalRequests.TabIndex = 10;
            lblTotalRequests.Text = "Total Requests";
            // 
            // pnlWelcome
            // 
            pnlWelcome.AutoScroll = true;
            pnlWelcome.AutoScrollMinSize = new Size(0, 900);
            pnlWelcome.BackColor = Color.FromArgb(234, 245, 245);
            pnlWelcome.Controls.Add(lblSubtitle);
            pnlWelcome.Controls.Add(lblWelcome);
            pnlWelcome.Controls.Add(lblRecentRequests);
            pnlWelcome.Controls.Add(pnlDashboardContent);
            pnlWelcome.Location = new Point(0, 0);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(868, 99);
            pnlWelcome.TabIndex = 11;
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(22, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(381, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Welcome, Administrator! Here's an overview of barangay services.";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(18, 52, 86);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(242, 34);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Admin Dashboard";
            // 
            // pnlDashboardContent
            // 
            pnlDashboardContent.AutoScroll = true;
            pnlDashboardContent.CustomizableEdges = customizableEdges7;
            pnlDashboardContent.Dock = DockStyle.Fill;
            pnlDashboardContent.Location = new Point(0, 0);
            pnlDashboardContent.Name = "pnlDashboardContent";
            pnlDashboardContent.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlDashboardContent.Size = new Size(851, 900);
            pnlDashboardContent.TabIndex = 12;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = Color.White;
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel1);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel2);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges9;
            guna2CustomGradientPanel1.FillColor = Color.Gainsboro;
            guna2CustomGradientPanel1.FillColor2 = Color.Gainsboro;
            guna2CustomGradientPanel1.FillColor3 = Color.Gainsboro;
            guna2CustomGradientPanel1.FillColor4 = Color.Gainsboro;
            guna2CustomGradientPanel1.Location = new Point(22, 105);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2CustomGradientPanel1.Size = new Size(150, 150);
            guna2CustomGradientPanel1.TabIndex = 11;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(64, 62);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(18, 34);
            guna2HtmlLabel1.TabIndex = 9;
            guna2HtmlLabel1.Text = "0";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(16, 9);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(122, 21);
            guna2HtmlLabel2.TabIndex = 10;
            guna2HtmlLabel2.Text = "Total Residents";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.Location = new Point(22, 472);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(161, 26);
            guna2HtmlLabel3.TabIndex = 12;
            guna2HtmlLabel3.Text = "Recent Activities";
            // 
            // guna2CustomGradientPanel2
            // 
            guna2CustomGradientPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2CustomGradientPanel2.BackColor = Color.White;
            guna2CustomGradientPanel2.Controls.Add(guna2HtmlLabel4);
            guna2CustomGradientPanel2.Controls.Add(guna2HtmlLabel5);
            guna2CustomGradientPanel2.CustomizableEdges = customizableEdges11;
            guna2CustomGradientPanel2.FillColor = Color.Gainsboro;
            guna2CustomGradientPanel2.FillColor2 = Color.Gainsboro;
            guna2CustomGradientPanel2.FillColor3 = Color.Gainsboro;
            guna2CustomGradientPanel2.FillColor4 = Color.Gainsboro;
            guna2CustomGradientPanel2.Location = new Point(22, 320);
            guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            guna2CustomGradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2CustomGradientPanel2.Size = new Size(211, 125);
            guna2CustomGradientPanel2.TabIndex = 5;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.Location = new Point(82, 53);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(18, 34);
            guna2HtmlLabel4.TabIndex = 3;
            guna2HtmlLabel4.Text = "0";
            guna2HtmlLabel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.Location = new Point(58, 9);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(80, 21);
            guna2HtmlLabel5.TabIndex = 4;
            guna2HtmlLabel5.Text = "Certificate";
            // 
            // guna2CustomGradientPanel3
            // 
            guna2CustomGradientPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2CustomGradientPanel3.BackColor = Color.White;
            guna2CustomGradientPanel3.Controls.Add(guna2HtmlLabel6);
            guna2CustomGradientPanel3.Controls.Add(guna2HtmlLabel7);
            guna2CustomGradientPanel3.CustomizableEdges = customizableEdges13;
            guna2CustomGradientPanel3.FillColor = Color.Gainsboro;
            guna2CustomGradientPanel3.FillColor2 = Color.Gainsboro;
            guna2CustomGradientPanel3.FillColor3 = Color.Gainsboro;
            guna2CustomGradientPanel3.FillColor4 = Color.Gainsboro;
            guna2CustomGradientPanel3.Location = new Point(322, 320);
            guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2CustomGradientPanel3.Size = new Size(211, 125);
            guna2CustomGradientPanel3.TabIndex = 6;
            // 
            // guna2HtmlLabel6
            // 
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel6.Location = new Point(92, 53);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(18, 34);
            guna2HtmlLabel6.TabIndex = 3;
            guna2HtmlLabel6.Text = "0";
            guna2HtmlLabel6.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel7
            // 
            guna2HtmlLabel7.BackColor = Color.Transparent;
            guna2HtmlLabel7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel7.Location = new Point(52, 9);
            guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            guna2HtmlLabel7.Size = new Size(104, 21);
            guna2HtmlLabel7.TabIndex = 4;
            guna2HtmlLabel7.Text = "Reservations";
            // 
            // guna2CustomGradientPanel4
            // 
            guna2CustomGradientPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2CustomGradientPanel4.BackColor = Color.White;
            guna2CustomGradientPanel4.Controls.Add(guna2HtmlLabel8);
            guna2CustomGradientPanel4.Controls.Add(guna2HtmlLabel9);
            guna2CustomGradientPanel4.CustomizableEdges = customizableEdges15;
            guna2CustomGradientPanel4.FillColor = Color.Gainsboro;
            guna2CustomGradientPanel4.FillColor2 = Color.Gainsboro;
            guna2CustomGradientPanel4.FillColor3 = Color.Gainsboro;
            guna2CustomGradientPanel4.FillColor4 = Color.Gainsboro;
            guna2CustomGradientPanel4.Location = new Point(640, 320);
            guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            guna2CustomGradientPanel4.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2CustomGradientPanel4.Size = new Size(211, 125);
            guna2CustomGradientPanel4.TabIndex = 7;
            // 
            // guna2HtmlLabel8
            // 
            guna2HtmlLabel8.BackColor = Color.Transparent;
            guna2HtmlLabel8.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel8.Location = new Point(96, 53);
            guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            guna2HtmlLabel8.Size = new Size(18, 34);
            guna2HtmlLabel8.TabIndex = 3;
            guna2HtmlLabel8.Text = "0";
            guna2HtmlLabel8.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel9
            // 
            guna2HtmlLabel9.BackColor = Color.Transparent;
            guna2HtmlLabel9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel9.Location = new Point(65, 9);
            guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            guna2HtmlLabel9.Size = new Size(90, 21);
            guna2HtmlLabel9.TabIndex = 4;
            guna2HtmlLabel9.Text = "Complaints";
            // 
            // guna2HtmlLabel10
            // 
            guna2HtmlLabel10.BackColor = Color.Transparent;
            guna2HtmlLabel10.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel10.Location = new Point(22, 276);
            guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            guna2HtmlLabel10.Size = new Size(167, 26);
            guna2HtmlLabel10.TabIndex = 13;
            guna2HtmlLabel10.Text = "Service Overview";
            // 
            // AdminHomeContentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 819);
            Controls.Add(guna2HtmlLabel10);
            Controls.Add(guna2CustomGradientPanel4);
            Controls.Add(guna2CustomGradientPanel3);
            Controls.Add(guna2CustomGradientPanel2);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(pnlPending);
            Controls.Add(pnlApproved);
            Controls.Add(pnlTotalRequests);
            Controls.Add(pnlWelcome);
            Controls.Add(dgvRecentRequests);
            Name = "AdminHomeContentControl";
            Size = new Size(871, 819);
            ((System.ComponentModel.ISupportInitialize)dgvRecentRequests).EndInit();
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            pnlApproved.ResumeLayout(false);
            pnlApproved.PerformLayout();
            pnlTotalRequests.ResumeLayout(false);
            pnlTotalRequests.PerformLayout();
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            guna2CustomGradientPanel2.ResumeLayout(false);
            guna2CustomGradientPanel2.PerformLayout();
            guna2CustomGradientPanel3.ResumeLayout(false);
            guna2CustomGradientPanel3.PerformLayout();
            guna2CustomGradientPanel4.ResumeLayout(false);
            guna2CustomGradientPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlDashboardContent;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private DataGridViewTextBoxColumn ReferenceID;
        private DataGridViewTextBoxColumn RequestType;
        private DataGridViewTextBoxColumn DateSubmitted;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn btnView;
        private DataGridViewComboBoxColumn btnAction;
    }
}
