
namespace G_36_SmartPrint.UI
{
    partial class AssignDeliveryOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDeliveryOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnAssign = new Guna.UI2.WinForms.Guna2Button();
            this.dtDeliveryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTrackingNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbOrder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbDeliveryMan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblDeliveryMan = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Violet;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(30, 23, 30, 23);
            this.panelHeader.Size = new System.Drawing.Size(1200, 123);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(454, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Assign Delivery Orders";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dgvDeliveryOrders);
            this.mainPanel.Controls.Add(this.btnClear);
            this.mainPanel.Controls.Add(this.btnAssign);
            this.mainPanel.Controls.Add(this.dtDeliveryDate);
            this.mainPanel.Controls.Add(this.txtTrackingNumber);
            this.mainPanel.Controls.Add(this.txtAddress);
            this.mainPanel.Controls.Add(this.cmbOrder);
            this.mainPanel.Controls.Add(this.cmbDeliveryMan);
            this.mainPanel.Controls.Add(this.lblDeliveryDate);
            this.mainPanel.Controls.Add(this.lblTrackingNumber);
            this.mainPanel.Controls.Add(this.lblAddress);
            this.mainPanel.Controls.Add(this.lblOrder);
            this.mainPanel.Controls.Add(this.lblDeliveryMan);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 123);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.mainPanel.Size = new System.Drawing.Size(1200, 800);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // dgvDeliveryOrders
            // 
            this.dgvDeliveryOrders.AllowUserToAddRows = false;
            this.dgvDeliveryOrders.AllowUserToDeleteRows = false;
            this.dgvDeliveryOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvDeliveryOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDeliveryOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeliveryOrders.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveryOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDeliveryOrders.ColumnHeadersHeight = 40;
            this.dgvDeliveryOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeliveryOrders.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDeliveryOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeliveryOrders.Location = new System.Drawing.Point(93, 534);
            this.dgvDeliveryOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDeliveryOrders.Name = "dgvDeliveryOrders";
            this.dgvDeliveryOrders.ReadOnly = true;
            this.dgvDeliveryOrders.RowHeadersVisible = false;
            this.dgvDeliveryOrders.RowHeadersWidth = 62;
            this.dgvDeliveryOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDeliveryOrders.Size = new System.Drawing.Size(1024, 235);
            this.dgvDeliveryOrders.TabIndex = 14;
            this.dgvDeliveryOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDeliveryOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDeliveryOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDeliveryOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDeliveryOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDeliveryOrders.ThemeStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.dgvDeliveryOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeliveryOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDeliveryOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDeliveryOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDeliveryOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDeliveryOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDeliveryOrders.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDeliveryOrders.ThemeStyle.ReadOnly = true;
            this.dgvDeliveryOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDeliveryOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDeliveryOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDeliveryOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDeliveryOrders.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDeliveryOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeliveryOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BorderRadius = 5;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(848, 449);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 55);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssign.BorderRadius = 5;
            this.btnAssign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAssign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAssign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAssign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAssign.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(582, 449);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(180, 55);
            this.btnAssign.TabIndex = 11;
            this.btnAssign.Text = "Assign";
            // 
            // dtDeliveryDate
            // 
            this.dtDeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDeliveryDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtDeliveryDate.BorderRadius = 5;
            this.dtDeliveryDate.BorderThickness = 2;
            this.dtDeliveryDate.Checked = true;
            this.dtDeliveryDate.FillColor = System.Drawing.Color.White;
            this.dtDeliveryDate.FocusedColor = System.Drawing.Color.White;
            this.dtDeliveryDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDeliveryDate.Location = new System.Drawing.Point(582, 235);
            this.dtDeliveryDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtDeliveryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDeliveryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(483, 55);
            this.dtDeliveryDate.TabIndex = 10;
            this.dtDeliveryDate.Value = new System.DateTime(2023, 12, 12, 0, 0, 0, 0);
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrackingNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTrackingNumber.BorderRadius = 5;
            this.txtTrackingNumber.BorderThickness = 2;
            this.txtTrackingNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrackingNumber.DefaultText = "";
            this.txtTrackingNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrackingNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrackingNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrackingNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrackingNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrackingNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrackingNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrackingNumber.Location = new System.Drawing.Point(30, 314);
            this.txtTrackingNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.PlaceholderText = "";
            this.txtTrackingNumber.SelectedText = "";
            this.txtTrackingNumber.Size = new System.Drawing.Size(483, 55);
            this.txtTrackingNumber.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAddress.BorderRadius = 5;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(582, 86);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(483, 92);
            this.txtAddress.TabIndex = 8;
            // 
            // cmbOrder
            // 
            this.cmbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrder.BackColor = System.Drawing.Color.Transparent;
            this.cmbOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbOrder.BorderRadius = 5;
            this.cmbOrder.BorderThickness = 2;
            this.cmbOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrder.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbOrder.ItemHeight = 30;
            this.cmbOrder.Location = new System.Drawing.Point(34, 200);
            this.cmbOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(481, 36);
            this.cmbOrder.TabIndex = 7;
            // 
            // cmbDeliveryMan
            // 
            this.cmbDeliveryMan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDeliveryMan.BackColor = System.Drawing.Color.Transparent;
            this.cmbDeliveryMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbDeliveryMan.BorderRadius = 5;
            this.cmbDeliveryMan.BorderThickness = 2;
            this.cmbDeliveryMan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDeliveryMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeliveryMan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDeliveryMan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDeliveryMan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDeliveryMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDeliveryMan.ItemHeight = 30;
            this.cmbDeliveryMan.Location = new System.Drawing.Point(34, 86);
            this.cmbDeliveryMan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDeliveryMan.Name = "cmbDeliveryMan";
            this.cmbDeliveryMan.Size = new System.Drawing.Size(481, 36);
            this.cmbDeliveryMan.TabIndex = 6;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblDeliveryDate.Location = new System.Drawing.Point(592, 200);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(160, 30);
            this.lblDeliveryDate.TabIndex = 5;
            this.lblDeliveryDate.Text = "Delivery Date:";
            this.lblDeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackingNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblTrackingNumber.Location = new System.Drawing.Point(36, 275);
            this.lblTrackingNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(220, 32);
            this.lblTrackingNumber.TabIndex = 4;
            this.lblTrackingNumber.Text = "Tracking Number:";
            this.lblTrackingNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblAddress.Location = new System.Drawing.Point(591, 54);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(113, 32);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblOrder.Location = new System.Drawing.Point(34, 163);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(88, 32);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Order:";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeliveryMan
            // 
            this.lblDeliveryMan.AutoSize = true;
            this.lblDeliveryMan.BackColor = System.Drawing.Color.Transparent;
            this.lblDeliveryMan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblDeliveryMan.Location = new System.Drawing.Point(34, 54);
            this.lblDeliveryMan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryMan.Name = "lblDeliveryMan";
            this.lblDeliveryMan.Size = new System.Drawing.Size(200, 32);
            this.lblDeliveryMan.TabIndex = 1;
            this.lblDeliveryMan.Text = "DeliveryMan ID:";
            this.lblDeliveryMan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AssignDeliveryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AssignDeliveryOrder";
            this.Size = new System.Drawing.Size(1200, 923);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDeliveryOrders;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnAssign;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDeliveryDate;
        private Guna.UI2.WinForms.Guna2TextBox txtTrackingNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOrder;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDeliveryMan;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblTrackingNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblDeliveryMan;
    }
}