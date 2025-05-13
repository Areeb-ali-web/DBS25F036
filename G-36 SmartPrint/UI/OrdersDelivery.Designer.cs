namespace G_36_SmartPrint.UI
{
    partial class OrdersDelivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDeliveryHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelivered = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTrackingNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDeliveryMan = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbOrder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpDeliveredDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblDeliveredDate = new System.Windows.Forms.Label();
            this.lblDeliveryMan = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryHistory)).BeginInit();
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Orders Delivery";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dgvDeliveryHistory);
            this.mainPanel.Controls.Add(this.btnClear);
            this.mainPanel.Controls.Add(this.btnDelivered);
            this.mainPanel.Controls.Add(this.txtAddress);
            this.mainPanel.Controls.Add(this.txtTrackingNumber);
            this.mainPanel.Controls.Add(this.txtCustomerName);
            this.mainPanel.Controls.Add(this.txtDeliveryMan);
            this.mainPanel.Controls.Add(this.cmbOrder);
            this.mainPanel.Controls.Add(this.dtpDeliveredDate);
            this.mainPanel.Controls.Add(this.lblAddress);
            this.mainPanel.Controls.Add(this.lblTrackingNumber);
            this.mainPanel.Controls.Add(this.lblCustomerName);
            this.mainPanel.Controls.Add(this.lblDeliveredDate);
            this.mainPanel.Controls.Add(this.lblDeliveryMan);
            this.mainPanel.Controls.Add(this.lblOrder);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 123);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.mainPanel.Size = new System.Drawing.Size(1200, 800);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // dgvDeliveryHistory
            // 
            this.dgvDeliveryHistory.AllowUserToAddRows = false;
            this.dgvDeliveryHistory.AllowUserToDeleteRows = false;
            this.dgvDeliveryHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDeliveryHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeliveryHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeliveryHistory.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveryHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeliveryHistory.ColumnHeadersHeight = 40;
            this.dgvDeliveryHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeliveryHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeliveryHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeliveryHistory.Location = new System.Drawing.Point(30, 534);
            this.dgvDeliveryHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDeliveryHistory.Name = "dgvDeliveryHistory";
            this.dgvDeliveryHistory.ReadOnly = true;
            this.dgvDeliveryHistory.RowHeadersVisible = false;
            this.dgvDeliveryHistory.RowHeadersWidth = 62;
            this.dgvDeliveryHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDeliveryHistory.Size = new System.Drawing.Size(1140, 235);
            this.dgvDeliveryHistory.TabIndex = 15;
            this.dgvDeliveryHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDeliveryHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDeliveryHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDeliveryHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDeliveryHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDeliveryHistory.ThemeStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.dgvDeliveryHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeliveryHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDeliveryHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDeliveryHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDeliveryHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDeliveryHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDeliveryHistory.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDeliveryHistory.ThemeStyle.ReadOnly = true;
            this.dgvDeliveryHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDeliveryHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDeliveryHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDeliveryHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDeliveryHistory.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDeliveryHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeliveryHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BorderRadius = 5;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(922, 446);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 55);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            // 
            // btnDelivered
            // 
            this.btnDelivered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelivered.BorderRadius = 5;
            this.btnDelivered.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivered.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivered.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivered.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelivered.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnDelivered.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelivered.ForeColor = System.Drawing.Color.White;
            this.btnDelivered.Location = new System.Drawing.Point(660, 446);
            this.btnDelivered.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(180, 55);
            this.btnDelivered.TabIndex = 13;
            this.btnDelivered.Text = "Delivered";
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
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(630, 323);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(442, 95);
            this.txtAddress.TabIndex = 12;
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
            this.txtTrackingNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTrackingNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTrackingNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrackingNumber.Location = new System.Drawing.Point(624, 215);
            this.txtTrackingNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.PlaceholderText = "";
            this.txtTrackingNumber.ReadOnly = true;
            this.txtTrackingNumber.SelectedText = "";
            this.txtTrackingNumber.Size = new System.Drawing.Size(448, 55);
            this.txtTrackingNumber.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtCustomerName.BorderRadius = 5;
            this.txtCustomerName.BorderThickness = 2;
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.DefaultText = "";
            this.txtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.Location = new System.Drawing.Point(624, 89);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PlaceholderText = "";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(448, 55);
            this.txtCustomerName.TabIndex = 10;
            // 
            // txtDeliveryMan
            // 
            this.txtDeliveryMan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeliveryMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtDeliveryMan.BorderRadius = 5;
            this.txtDeliveryMan.BorderThickness = 2;
            this.txtDeliveryMan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeliveryMan.DefaultText = "";
            this.txtDeliveryMan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeliveryMan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeliveryMan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryMan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryMan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryMan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDeliveryMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDeliveryMan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryMan.Location = new System.Drawing.Point(30, 323);
            this.txtDeliveryMan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDeliveryMan.Name = "txtDeliveryMan";
            this.txtDeliveryMan.PlaceholderText = "";
            this.txtDeliveryMan.ReadOnly = true;
            this.txtDeliveryMan.SelectedText = "";
            this.txtDeliveryMan.Size = new System.Drawing.Size(448, 55);
            this.txtDeliveryMan.TabIndex = 9;
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
            this.cmbOrder.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbOrder.ItemHeight = 30;
            this.cmbOrder.Location = new System.Drawing.Point(30, 94);
            this.cmbOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(446, 36);
            this.cmbOrder.TabIndex = 7;
            // 
            // dtpDeliveredDate
            // 
            this.dtpDeliveredDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDeliveredDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtpDeliveredDate.BorderRadius = 5;
            this.dtpDeliveredDate.BorderThickness = 2;
            this.dtpDeliveredDate.Checked = true;
            this.dtpDeliveredDate.FillColor = System.Drawing.Color.White;
            this.dtpDeliveredDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpDeliveredDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtpDeliveredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliveredDate.Location = new System.Drawing.Point(30, 208);
            this.dtpDeliveredDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDeliveredDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDeliveredDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDeliveredDate.Name = "dtpDeliveredDate";
            this.dtpDeliveredDate.Size = new System.Drawing.Size(448, 55);
            this.dtpDeliveredDate.TabIndex = 6;
            this.dtpDeliveredDate.Value = new System.DateTime(2023, 10, 25, 0, 0, 0, 0);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblAddress.Location = new System.Drawing.Point(634, 277);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(113, 32);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackingNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackingNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblTrackingNumber.Location = new System.Drawing.Point(634, 171);
            this.lblTrackingNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(220, 32);
            this.lblTrackingNumber.TabIndex = 4;
            this.lblTrackingNumber.Text = "Tracking Number:";
            this.lblTrackingNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblCustomerName.Location = new System.Drawing.Point(634, 51);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(205, 32);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer Name:";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeliveredDate
            // 
            this.lblDeliveredDate.AutoSize = true;
            this.lblDeliveredDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDeliveredDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveredDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblDeliveredDate.Location = new System.Drawing.Point(34, 171);
            this.lblDeliveredDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveredDate.Name = "lblDeliveredDate";
            this.lblDeliveredDate.Size = new System.Drawing.Size(190, 32);
            this.lblDeliveredDate.TabIndex = 2;
            this.lblDeliveredDate.Text = "Delivered Date:";
            this.lblDeliveredDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeliveryMan
            // 
            this.lblDeliveryMan.AutoSize = true;
            this.lblDeliveryMan.BackColor = System.Drawing.Color.Transparent;
            this.lblDeliveryMan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblDeliveryMan.Location = new System.Drawing.Point(34, 277);
            this.lblDeliveryMan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryMan.Name = "lblDeliveryMan";
            this.lblDeliveryMan.Size = new System.Drawing.Size(174, 32);
            this.lblDeliveryMan.TabIndex = 1;
            this.lblDeliveryMan.Text = "Delivery Man:";
            this.lblDeliveryMan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblOrder.Location = new System.Drawing.Point(34, 51);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(88, 32);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Order:";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdersDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrdersDelivery";
            this.Size = new System.Drawing.Size(1200, 923);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDeliveryHistory;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnDelivered;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtTrackingNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtDeliveryMan;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOrder;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDeliveredDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTrackingNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblDeliveredDate;
        private System.Windows.Forms.Label lblDeliveryMan;
        private System.Windows.Forms.Label lblOrder;
    }
}