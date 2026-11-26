using System.Drawing;
using System.Windows.Forms;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    partial class EquipmentReservationControl
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubtitle;
        private Label lblEquipmentName;
        private Label lblAvailableQuantity;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Label lblEventName;
        private Guna.UI2.WinForms.Guna2TextBox txtEventName;
        private Label lblEventDate;
        private DateTimePicker dtpEventDate;
        private Label lblPurpose;
        private Guna.UI2.WinForms.Guna2TextBox txtPurpose;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Panel();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblEquipmentName = new Label();
            lblAvailableQuantity = new Label();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            lblEventName = new Label();
            txtEventName = new Guna.UI2.WinForms.Guna2TextBox();
            lblEventDate = new Label();
            dtpEventDate = new DateTimePicker();
            lblPurpose = new Label();
            txtPurpose = new Guna.UI2.WinForms.Guna2TextBox();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            dtpReturnDate = new DateTimePicker();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(234, 245, 245);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(871, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reserve Equipment";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Arial", 9.75F);
            lblSubtitle.Location = new Point(22, 53);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(369, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Choose the quantity and provide the details for your reservation.";
            // 
            // lblEquipmentName
            // 
            lblEquipmentName.AutoSize = true;
            lblEquipmentName.Font = new Font("Arial", 15F, FontStyle.Bold);
            lblEquipmentName.ForeColor = Color.FromArgb(18, 52, 86);
            lblEquipmentName.Location = new Point(54, 100);
            lblEquipmentName.Name = "lblEquipmentName";
            lblEquipmentName.Size = new Size(168, 24);
            lblEquipmentName.TabIndex = 1;
            lblEquipmentName.Text = "Equipment name";
            // 
            // lblAvailableQuantity
            // 
            lblAvailableQuantity.AutoSize = true;
            lblAvailableQuantity.Font = new Font("Arial", 9.75F);
            lblAvailableQuantity.ForeColor = Color.DimGray;
            lblAvailableQuantity.Location = new Point(56, 132);
            lblAvailableQuantity.Name = "lblAvailableQuantity";
            lblAvailableQuantity.Size = new Size(123, 16);
            lblAvailableQuantity.TabIndex = 2;
            lblAvailableQuantity.Text = "Available quantity: 0";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblQuantity.Location = new Point(430, 173);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(60, 16);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Arial", 10F);
            numQuantity.Location = new Point(433, 195);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(350, 23);
            numQuantity.TabIndex = 0;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblEventName.Location = new Point(54, 173);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(83, 16);
            lblEventName.TabIndex = 4;
            lblEventName.Text = "Event Name";
            // 
            // txtEventName
            // 
            txtEventName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEventName.BorderColor = Color.Black;
            txtEventName.BorderRadius = 5;
            txtEventName.CustomizableEdges = customizableEdges1;
            txtEventName.DefaultText = "";
            txtEventName.Font = new Font("Arial", 10F);
            txtEventName.ForeColor = Color.Black;
            txtEventName.Location = new Point(57, 195);
            txtEventName.MaxLength = 100;
            txtEventName.Name = "txtEventName";
            txtEventName.PlaceholderText = "";
            txtEventName.SelectedText = "";
            txtEventName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEventName.Size = new Size(350, 36);
            txtEventName.TabIndex = 1;
            // 
            // lblEventDate
            // 
            lblEventDate.AutoSize = true;
            lblEventDate.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblEventDate.Location = new Point(54, 252);
            lblEventDate.Name = "lblEventDate";
            lblEventDate.Size = new Size(75, 16);
            lblEventDate.TabIndex = 6;
            lblEventDate.Text = "Event Date";
            // 
            // dtpEventDate
            // 
            dtpEventDate.Font = new Font("Arial", 10F);
            dtpEventDate.Format = DateTimePickerFormat.Short;
            dtpEventDate.Location = new Point(57, 274);
            dtpEventDate.MinDate = new DateTime(2026, 11, 17, 0, 0, 0, 0);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(350, 23);
            dtpEventDate.TabIndex = 2;
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            lblPurpose.Location = new Point(54, 318);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(59, 16);
            lblPurpose.TabIndex = 10;
            lblPurpose.Text = "Purpose";
            // 
            // txtPurpose
            // 
            txtPurpose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPurpose.BorderColor = Color.Black;
            txtPurpose.BorderRadius = 5;
            txtPurpose.CustomizableEdges = customizableEdges3;
            txtPurpose.DefaultText = "";
            txtPurpose.Font = new Font("Arial", 10F);
            txtPurpose.ForeColor = Color.Black;
            txtPurpose.Location = new Point(57, 340);
            txtPurpose.MaxLength = 500;
            txtPurpose.Multiline = true;
            txtPurpose.Name = "txtPurpose";
            txtPurpose.PlaceholderText = "";
            txtPurpose.SelectedText = "";
            txtPurpose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPurpose.Size = new Size(756, 110);
            txtPurpose.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.BorderRadius = 5;
            btnSubmit.CustomizableEdges = customizableEdges5;
            btnSubmit.Enabled = false;
            btnSubmit.FillColor = Color.FromArgb(18, 52, 86);
            btnSubmit.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(592, 510);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSubmit.Size = new Size(225, 42);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit Reservation";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label1.Location = new Point(433, 252);
            label1.Name = "label1";
            label1.Size = new Size(82, 16);
            label1.TabIndex = 12;
            label1.Text = "Return Date";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Font = new Font("Arial", 10F);
            dtpReturnDate.Format = DateTimePickerFormat.Short;
            dtpReturnDate.Location = new Point(432, 274);
            dtpReturnDate.MinDate = new DateTime(2026, 11, 17, 0, 0, 0, 0);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(350, 23);
            dtpReturnDate.TabIndex = 11;
            // 
            // EquipmentReservationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(871, 590);
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(dtpReturnDate);
            Controls.Add(lblEquipmentName);
            Controls.Add(lblAvailableQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(numQuantity);
            Controls.Add(lblEventName);
            Controls.Add(txtEventName);
            Controls.Add(lblEventDate);
            Controls.Add(dtpEventDate);
            Controls.Add(lblPurpose);
            Controls.Add(txtPurpose);
            Controls.Add(btnSubmit);
            Controls.Add(pnlHeader);
            Name = "EquipmentReservationControl";
            Size = new Size(871, 620);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private DateTimePicker dtpReturnDate;
    }
}
