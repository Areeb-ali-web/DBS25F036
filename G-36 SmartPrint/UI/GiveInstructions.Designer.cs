namespace G_36_SmartPrint.UI
{
    partial class GiveInstructions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvInstructions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.dtpSendDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtInstructions = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbManagerName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAdminName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSendDate = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructions)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Violet;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
<<<<<<< HEAD
<<<<<<< HEAD
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 76);
=======
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 117);
>>>>>>> Project
=======
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 117);
>>>>>>> main
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 41);
=======
            this.lblTitle.Location = new System.Drawing.Point(30, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(375, 60);
>>>>>>> Project
=======
            this.lblTitle.Location = new System.Drawing.Point(30, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(375, 60);
>>>>>>> main
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Give Instructions";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dgvInstructions);
            this.mainPanel.Controls.Add(this.btnClear);
            this.mainPanel.Controls.Add(this.btnSend);
            this.mainPanel.Controls.Add(this.dtpSendDate);
            this.mainPanel.Controls.Add(this.txtInstructions);
            this.mainPanel.Controls.Add(this.cmbManagerName);
            this.mainPanel.Controls.Add(this.txtAdminName);
            this.mainPanel.Controls.Add(this.lblSendDate);
            this.mainPanel.Controls.Add(this.lblInstructions);
            this.mainPanel.Controls.Add(this.lblManagerName);
            this.mainPanel.Controls.Add(this.lblAdminName);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
<<<<<<< HEAD
            this.mainPanel.Location = new System.Drawing.Point(0, 76);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.Size = new System.Drawing.Size(800, 524);
=======
            this.mainPanel.Location = new System.Drawing.Point(0, 117);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.mainPanel.Size = new System.Drawing.Size(1200, 806);
>>>>>>> Project
=======
            this.mainPanel.Location = new System.Drawing.Point(0, 117);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.mainPanel.Size = new System.Drawing.Size(1200, 806);
>>>>>>> main
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // dgvInstructions
            // 
            this.dgvInstructions.AllowUserToAddRows = false;
            this.dgvInstructions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvInstructions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInstructions.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvInstructions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstructions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInstructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInstructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee,
            this.Instruction,
            this.SentDate});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInstructions.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInstructions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
<<<<<<< HEAD
<<<<<<< HEAD
            this.dgvInstructions.Location = new System.Drawing.Point(23, 315);
            this.dgvInstructions.Name = "dgvInstructions";
            this.dgvInstructions.ReadOnly = true;
            this.dgvInstructions.RowHeadersVisible = false;
            this.dgvInstructions.Size = new System.Drawing.Size(754, 186);
=======
            this.dgvInstructions.Location = new System.Drawing.Point(34, 485);
            this.dgvInstructions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInstructions.Name = "dgvInstructions";
            this.dgvInstructions.ReadOnly = true;
            this.dgvInstructions.RowHeadersVisible = false;
            this.dgvInstructions.RowHeadersWidth = 62;
            this.dgvInstructions.Size = new System.Drawing.Size(1131, 286);
>>>>>>> Project
=======
            this.dgvInstructions.Location = new System.Drawing.Point(34, 485);
            this.dgvInstructions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInstructions.Name = "dgvInstructions";
            this.dgvInstructions.ReadOnly = true;
            this.dgvInstructions.RowHeadersVisible = false;
            this.dgvInstructions.RowHeadersWidth = 62;
            this.dgvInstructions.Size = new System.Drawing.Size(1131, 286);
>>>>>>> main
            this.dgvInstructions.TabIndex = 10;
            this.dgvInstructions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInstructions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInstructions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInstructions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInstructions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInstructions.ThemeStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.dgvInstructions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInstructions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvInstructions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInstructions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvInstructions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInstructions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInstructions.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvInstructions.ThemeStyle.ReadOnly = true;
            this.dgvInstructions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInstructions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInstructions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvInstructions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInstructions.ThemeStyle.RowsStyle.Height = 22;
            this.dgvInstructions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInstructions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInstructions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstructions_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BorderRadius = 5;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnClear.Location = new System.Drawing.Point(592, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 36);
=======
            this.btnClear.Location = new System.Drawing.Point(888, 342);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 55);
>>>>>>> Project
=======
            this.btnClear.Location = new System.Drawing.Point(888, 342);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 55);
>>>>>>> main
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BorderRadius = 5;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnSend.Location = new System.Drawing.Point(402, 222);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 36);
=======
            this.btnSend.Location = new System.Drawing.Point(603, 342);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(180, 55);
>>>>>>> Project
=======
            this.btnSend.Location = new System.Drawing.Point(603, 342);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(180, 55);
>>>>>>> main
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dtpSendDate
            // 
            this.dtpSendDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSendDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtpSendDate.BorderRadius = 5;
            this.dtpSendDate.BorderThickness = 2;
            this.dtpSendDate.Checked = true;
            this.dtpSendDate.FillColor = System.Drawing.Color.White;
            this.dtpSendDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpSendDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtpSendDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
<<<<<<< HEAD
<<<<<<< HEAD
            this.dtpSendDate.Location = new System.Drawing.Point(23, 222);
            this.dtpSendDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSendDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSendDate.Name = "dtpSendDate";
            this.dtpSendDate.Size = new System.Drawing.Size(252, 36);
=======
            this.dtpSendDate.Location = new System.Drawing.Point(34, 342);
            this.dtpSendDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpSendDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSendDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSendDate.Name = "dtpSendDate";
            this.dtpSendDate.Size = new System.Drawing.Size(378, 55);
>>>>>>> Project
=======
            this.dtpSendDate.Location = new System.Drawing.Point(34, 342);
            this.dtpSendDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpSendDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSendDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSendDate.Name = "dtpSendDate";
            this.dtpSendDate.Size = new System.Drawing.Size(378, 55);
>>>>>>> main
            this.dtpSendDate.TabIndex = 7;
            this.dtpSendDate.Value = new System.DateTime(2023, 11, 15, 0, 0, 0, 0);
            // 
            // txtInstructions
            // 
            this.txtInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstructions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtInstructions.BorderRadius = 5;
            this.txtInstructions.BorderThickness = 2;
            this.txtInstructions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstructions.DefaultText = "";
            this.txtInstructions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstructions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInstructions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstructions.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstructions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstructions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtInstructions.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtInstructions.Location = new System.Drawing.Point(402, 58);
            this.txtInstructions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.txtInstructions.Location = new System.Drawing.Point(603, 89);
            this.txtInstructions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
>>>>>>> Project
=======
            this.txtInstructions.Location = new System.Drawing.Point(603, 89);
            this.txtInstructions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
>>>>>>> main
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.PlaceholderText = "Instructions";
            this.txtInstructions.SelectedText = "";
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtInstructions.Size = new System.Drawing.Size(319, 100);
=======
            this.txtInstructions.Size = new System.Drawing.Size(478, 154);
>>>>>>> Project
=======
            this.txtInstructions.Size = new System.Drawing.Size(478, 154);
>>>>>>> main
            this.txtInstructions.TabIndex = 6;
            // 
            // cmbManagerName
            // 
            this.cmbManagerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbManagerName.BackColor = System.Drawing.Color.Transparent;
            this.cmbManagerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbManagerName.BorderRadius = 5;
            this.cmbManagerName.BorderThickness = 2;
            this.cmbManagerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbManagerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManagerName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbManagerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbManagerName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbManagerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbManagerName.ItemHeight = 30;
            this.cmbManagerName.Items.AddRange(new object[] {
            "Manager 1",
            "Manager 2",
            "Manager 3",
            "Manager 4"});
<<<<<<< HEAD
<<<<<<< HEAD
            this.cmbManagerName.Location = new System.Drawing.Point(23, 146);
=======
            this.cmbManagerName.Location = new System.Drawing.Point(34, 225);
            this.cmbManagerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> main
            this.cmbManagerName.Name = "cmbManagerName";
            this.cmbManagerName.Size = new System.Drawing.Size(376, 36);
            this.cmbManagerName.TabIndex = 5;
=======
            this.cmbManagerName.Location = new System.Drawing.Point(34, 225);
            this.cmbManagerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbManagerName.Name = "cmbManagerName";
            this.cmbManagerName.Size = new System.Drawing.Size(376, 36);
            this.cmbManagerName.TabIndex = 5;
            this.cmbManagerName.SelectedIndexChanged += new System.EventHandler(this.cmbManagerName_SelectedIndexChanged);
>>>>>>> Project
            // 
            // txtAdminName
            // 
            this.txtAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdminName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAdminName.BorderRadius = 5;
            this.txtAdminName.BorderThickness = 2;
            this.txtAdminName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminName.DefaultText = "";
            this.txtAdminName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdminName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdminName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdminName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtAdminName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtAdminName.Location = new System.Drawing.Point(23, 58);
            this.txtAdminName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.txtAdminName.Location = new System.Drawing.Point(34, 89);
            this.txtAdminName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
>>>>>>> Project
=======
            this.txtAdminName.Location = new System.Drawing.Point(34, 89);
            this.txtAdminName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
>>>>>>> main
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.PlaceholderText = "";
            this.txtAdminName.ReadOnly = true;
            this.txtAdminName.SelectedText = "";
<<<<<<< HEAD
<<<<<<< HEAD
            this.txtAdminName.Size = new System.Drawing.Size(252, 36);
=======
            this.txtAdminName.Size = new System.Drawing.Size(378, 55);
>>>>>>> Project
=======
            this.txtAdminName.Size = new System.Drawing.Size(378, 55);
>>>>>>> main
            this.txtAdminName.TabIndex = 4;
            // 
            // lblSendDate
            // 
            this.lblSendDate.AutoSize = true;
            this.lblSendDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSendDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSendDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblSendDate.Location = new System.Drawing.Point(23, 198);
            this.lblSendDate.Name = "lblSendDate";
            this.lblSendDate.Size = new System.Drawing.Size(92, 21);
=======
            this.lblSendDate.Location = new System.Drawing.Point(34, 305);
            this.lblSendDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendDate.Name = "lblSendDate";
            this.lblSendDate.Size = new System.Drawing.Size(137, 32);
>>>>>>> Project
=======
            this.lblSendDate.Location = new System.Drawing.Point(34, 305);
            this.lblSendDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendDate.Name = "lblSendDate";
            this.lblSendDate.Size = new System.Drawing.Size(137, 32);
>>>>>>> main
            this.lblSendDate.TabIndex = 3;
            this.lblSendDate.Text = "Send Date:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblInstructions.Location = new System.Drawing.Point(398, 33);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(104, 21);
=======
            this.lblInstructions.Location = new System.Drawing.Point(597, 51);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(158, 32);
>>>>>>> Project
=======
            this.lblInstructions.Location = new System.Drawing.Point(597, 51);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(158, 32);
>>>>>>> main
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Instructions:";
            // 
            // lblManagerName
            // 
            this.lblManagerName.AutoSize = true;
            this.lblManagerName.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblManagerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblManagerName.Location = new System.Drawing.Point(23, 109);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(132, 21);
=======
            this.lblManagerName.Location = new System.Drawing.Point(34, 168);
            this.lblManagerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(197, 32);
>>>>>>> Project
=======
            this.lblManagerName.Location = new System.Drawing.Point(34, 168);
            this.lblManagerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(197, 32);
>>>>>>> main
            this.lblManagerName.TabIndex = 1;
            this.lblManagerName.Text = "Manager Name:";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblAdminName.Location = new System.Drawing.Point(23, 33);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(115, 21);
=======
            this.lblAdminName.Location = new System.Drawing.Point(34, 51);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(171, 32);
>>>>>>> Project
=======
            this.lblAdminName.Location = new System.Drawing.Point(34, 51);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(171, 32);
>>>>>>> main
            this.lblAdminName.TabIndex = 0;
            this.lblAdminName.Text = "Admin Name:";
            // 
            // Employee
            // 
            this.Employee.HeaderText = "To Employee";
            this.Employee.MinimumWidth = 8;
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            // 
            // Instruction
            // 
            this.Instruction.HeaderText = "Instructions";
            this.Instruction.MinimumWidth = 8;
            this.Instruction.Name = "Instruction";
            this.Instruction.ReadOnly = true;
            // 
            // SentDate
            // 
            this.SentDate.HeaderText = "Send Date";
            this.SentDate.MinimumWidth = 8;
            this.SentDate.Name = "SentDate";
            this.SentDate.ReadOnly = true;
            // 
            // GiveInstructions
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
>>>>>>> Project
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
>>>>>>> main
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelHeader);
<<<<<<< HEAD
<<<<<<< HEAD
            this.Name = "GiveInstructions";
            this.Size = new System.Drawing.Size(800, 600);
=======
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GiveInstructions";
            this.Size = new System.Drawing.Size(1200, 923);
>>>>>>> Project
=======
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GiveInstructions";
            this.Size = new System.Drawing.Size(1200, 923);
>>>>>>> main
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblManagerName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblSendDate;
        private Guna.UI2.WinForms.Guna2TextBox txtAdminName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbManagerName;
        private Guna.UI2.WinForms.Guna2TextBox txtInstructions;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSendDate;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInstructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn SentDate;
    }
}