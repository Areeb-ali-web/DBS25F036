namespace G_36_SmartPrint.UI
{
    partial class FinancialReport
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
            this.dgvFinancialData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txtNetProfit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalExpenses = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalRevenue = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtManagerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpReportDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNetProfit = new System.Windows.Forms.Label();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblReportDate = new System.Windows.Forms.Label();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialData)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(364, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Financial Report";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dgvFinancialData);
            this.mainPanel.Controls.Add(this.btnClear);
            this.mainPanel.Controls.Add(this.btnUpdate);
            this.mainPanel.Controls.Add(this.btnSubmit);
            this.mainPanel.Controls.Add(this.txtNetProfit);
            this.mainPanel.Controls.Add(this.txtTotalExpenses);
            this.mainPanel.Controls.Add(this.txtTotalRevenue);
            this.mainPanel.Controls.Add(this.txtManagerName);
            this.mainPanel.Controls.Add(this.dtpReportDate);
            this.mainPanel.Controls.Add(this.lblNetProfit);
            this.mainPanel.Controls.Add(this.lblTotalExpenses);
            this.mainPanel.Controls.Add(this.lblTotalRevenue);
            this.mainPanel.Controls.Add(this.lblReportDate);
            this.mainPanel.Controls.Add(this.lblManagerName);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 123);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.mainPanel.Size = new System.Drawing.Size(1200, 800);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // dgvFinancialData
            // 
            this.dgvFinancialData.AllowUserToAddRows = false;
            this.dgvFinancialData.AllowUserToDeleteRows = false;
            this.dgvFinancialData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFinancialData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinancialData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFinancialData.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinancialData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinancialData.ColumnHeadersHeight = 40;
            this.dgvFinancialData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinancialData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFinancialData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFinancialData.Location = new System.Drawing.Point(30, 522);
            this.dgvFinancialData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFinancialData.Name = "dgvFinancialData";
            this.dgvFinancialData.ReadOnly = true;
            this.dgvFinancialData.RowHeadersVisible = false;
            this.dgvFinancialData.RowHeadersWidth = 62;
            this.dgvFinancialData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFinancialData.Size = new System.Drawing.Size(1140, 248);
            this.dgvFinancialData.TabIndex = 14;
            this.dgvFinancialData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFinancialData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFinancialData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFinancialData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFinancialData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFinancialData.ThemeStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.dgvFinancialData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFinancialData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvFinancialData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFinancialData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvFinancialData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFinancialData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFinancialData.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvFinancialData.ThemeStyle.ReadOnly = true;
            this.dgvFinancialData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFinancialData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFinancialData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvFinancialData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFinancialData.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFinancialData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFinancialData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFinancialData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinancialData_CellContentClick);
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
            this.btnClear.Location = new System.Drawing.Point(940, 423);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 55);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(700, 423);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 55);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BorderRadius = 5;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(482, 423);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 55);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            // 
            // txtNetProfit
            // 
            this.txtNetProfit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNetProfit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtNetProfit.BorderRadius = 5;
            this.txtNetProfit.BorderThickness = 2;
            this.txtNetProfit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNetProfit.DefaultText = "";
            this.txtNetProfit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNetProfit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNetProfit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNetProfit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNetProfit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNetProfit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNetProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNetProfit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNetProfit.Location = new System.Drawing.Point(648, 334);
            this.txtNetProfit.Margin = new System.Windows.Forms.Padding(6);
            this.txtNetProfit.Name = "txtNetProfit";
            this.txtNetProfit.PlaceholderText = "";
            this.txtNetProfit.ReadOnly = true;
            this.txtNetProfit.SelectedText = "";
            this.txtNetProfit.Size = new System.Drawing.Size(472, 54);
            this.txtNetProfit.TabIndex = 11;
            this.txtNetProfit.TextChanged += new System.EventHandler(this.txtNetProfit_TextChanged);
            // 
            // txtTotalExpenses
            // 
            this.txtTotalExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalExpenses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTotalExpenses.BorderRadius = 5;
            this.txtTotalExpenses.BorderThickness = 2;
            this.txtTotalExpenses.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalExpenses.DefaultText = "";
            this.txtTotalExpenses.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalExpenses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalExpenses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalExpenses.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalExpenses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalExpenses.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTotalExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTotalExpenses.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalExpenses.Location = new System.Drawing.Point(648, 197);
            this.txtTotalExpenses.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotalExpenses.Name = "txtTotalExpenses";
            this.txtTotalExpenses.PlaceholderText = "";
            this.txtTotalExpenses.SelectedText = "";
            this.txtTotalExpenses.Size = new System.Drawing.Size(472, 52);
            this.txtTotalExpenses.TabIndex = 10;
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalRevenue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTotalRevenue.BorderRadius = 5;
            this.txtTotalRevenue.BorderThickness = 2;
            this.txtTotalRevenue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalRevenue.DefaultText = "";
            this.txtTotalRevenue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalRevenue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalRevenue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTotalRevenue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalRevenue.Location = new System.Drawing.Point(648, 77);
            this.txtTotalRevenue.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.PlaceholderText = "";
            this.txtTotalRevenue.SelectedText = "";
            this.txtTotalRevenue.Size = new System.Drawing.Size(472, 52);
            this.txtTotalRevenue.TabIndex = 9;
            // 
            // txtManagerName
            // 
            this.txtManagerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManagerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtManagerName.BorderRadius = 5;
            this.txtManagerName.BorderThickness = 3;
            this.txtManagerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManagerName.DefaultText = "";
            this.txtManagerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtManagerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtManagerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtManagerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtManagerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtManagerName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtManagerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtManagerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtManagerName.Location = new System.Drawing.Point(30, 77);
            this.txtManagerName.Margin = new System.Windows.Forms.Padding(6);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.PlaceholderText = "";
            this.txtManagerName.ReadOnly = true;
            this.txtManagerName.SelectedText = "";
            this.txtManagerName.Size = new System.Drawing.Size(454, 52);
            this.txtManagerName.TabIndex = 7;
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReportDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtpReportDate.BorderRadius = 5;
            this.dtpReportDate.BorderThickness = 2;
            this.dtpReportDate.Checked = true;
            this.dtpReportDate.FillColor = System.Drawing.Color.White;
            this.dtpReportDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpReportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtpReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReportDate.Location = new System.Drawing.Point(30, 197);
            this.dtpReportDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpReportDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpReportDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(454, 52);
            this.dtpReportDate.TabIndex = 6;
            this.dtpReportDate.Value = new System.DateTime(2023, 10, 25, 0, 0, 0, 0);
            // 
            // lblNetProfit
            // 
            this.lblNetProfit.AutoSize = true;
            this.lblNetProfit.BackColor = System.Drawing.Color.Transparent;
            this.lblNetProfit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblNetProfit.Location = new System.Drawing.Point(650, 295);
            this.lblNetProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetProfit.Name = "lblNetProfit";
            this.lblNetProfit.Size = new System.Drawing.Size(134, 32);
            this.lblNetProfit.TabIndex = 5;
            this.lblNetProfit.Text = "Net Profit:";
            this.lblNetProfit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblTotalExpenses.Location = new System.Drawing.Point(650, 166);
            this.lblTotalExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(188, 32);
            this.lblTotalExpenses.TabIndex = 4;
            this.lblTotalExpenses.Text = "Total Expenses:";
            this.lblTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(650, 31);
            this.lblTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(181, 32);
            this.lblTotalRevenue.TabIndex = 3;
            this.lblTotalRevenue.Text = "Total Revenue:";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReportDate
            // 
            this.lblReportDate.AutoSize = true;
            this.lblReportDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReportDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblReportDate.Location = new System.Drawing.Point(34, 166);
            this.lblReportDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportDate.Name = "lblReportDate";
            this.lblReportDate.Size = new System.Drawing.Size(159, 32);
            this.lblReportDate.TabIndex = 1;
            this.lblReportDate.Text = "Report Date:";
            this.lblReportDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblManagerName
            // 
            this.lblManagerName.AutoSize = true;
            this.lblManagerName.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblManagerName.Location = new System.Drawing.Point(32, 31);
            this.lblManagerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(197, 32);
            this.lblManagerName.TabIndex = 0;
            this.lblManagerName.Text = "Manager Name:";
            this.lblManagerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FinancialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FinancialReport";
            this.Size = new System.Drawing.Size(1200, 923);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFinancialData;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtNetProfit;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalExpenses;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalRevenue;
        private Guna.UI2.WinForms.Guna2TextBox txtManagerName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpReportDate;
        private System.Windows.Forms.Label lblNetProfit;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblReportDate;
        private System.Windows.Forms.Label lblManagerName;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
    }
}