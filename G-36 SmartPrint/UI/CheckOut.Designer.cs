namespace G_36_SmartPrint.UI
{
    partial class CheckOut
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
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuy = new Guna.UI2.WinForms.Guna2Button();
            this.cmbPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtState = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCountry = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDesignDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDesignDescription = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.mainPanel.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(1125, 92);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CheckOut Order";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.btnBack);
            this.mainPanel.Controls.Add(this.btnBuy);
            this.mainPanel.Controls.Add(this.cmbPaymentMethod);
            this.mainPanel.Controls.Add(this.txtPayment);
            this.mainPanel.Controls.Add(this.txtCity);
            this.mainPanel.Controls.Add(this.txtState);
            this.mainPanel.Controls.Add(this.txtCountry);
            this.mainPanel.Controls.Add(this.txtAddress);
            this.mainPanel.Controls.Add(this.txtDesignDescription);
            this.mainPanel.Controls.Add(this.lblPaymentMethod);
            this.mainPanel.Controls.Add(this.lblPayment);
            this.mainPanel.Controls.Add(this.lblCity);
            this.mainPanel.Controls.Add(this.lblState);
            this.mainPanel.Controls.Add(this.lblCountry);
            this.mainPanel.Controls.Add(this.lblAddress);
            this.mainPanel.Controls.Add(this.lblDesignDescription);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 92);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.mainPanel.Size = new System.Drawing.Size(1125, 677);
            this.mainPanel.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BorderRadius = 5;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(560, 526);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 68);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuy.BorderRadius = 5;
            this.btnBuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(830, 526);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(180, 68);
            this.btnBuy.TabIndex = 14;
            this.btnBuy.Text = "Buy";
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.cmbPaymentMethod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbPaymentMethod.BorderRadius = 5;
            this.cmbPaymentMethod.BorderThickness = 2;
            this.cmbPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPaymentMethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPaymentMethod.ItemHeight = 30;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card",
            "PayPal",
            "Bank Transfer",
            "Cash on Delivery"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(58, 472);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(376, 36);
            this.cmbPaymentMethod.TabIndex = 13;
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPayment.BorderRadius = 5;
            this.txtPayment.BorderThickness = 2;
            this.txtPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPayment.DefaultText = "";
            this.txtPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPayment.Location = new System.Drawing.Point(60, 375);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.PlaceholderText = "";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.SelectedText = "";
            this.txtPayment.Size = new System.Drawing.Size(376, 55);
            this.txtPayment.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtCity.BorderRadius = 5;
            this.txtCity.BorderThickness = 2;
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.DefaultText = "";
            this.txtCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCity.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCity.Location = new System.Drawing.Point(604, 338);
            this.txtCity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.PlaceholderText = "";
            this.txtCity.SelectedText = "";
            this.txtCity.Size = new System.Drawing.Size(354, 55);
            this.txtCity.TabIndex = 11;
            // 
            // txtState
            // 
            this.txtState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtState.BorderRadius = 5;
            this.txtState.BorderThickness = 2;
            this.txtState.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtState.DefaultText = "";
            this.txtState.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtState.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtState.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtState.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtState.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtState.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtState.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtState.Location = new System.Drawing.Point(603, 215);
            this.txtState.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtState.Name = "txtState";
            this.txtState.PlaceholderText = "";
            this.txtState.SelectedText = "";
            this.txtState.Size = new System.Drawing.Size(356, 55);
            this.txtState.TabIndex = 10;
            // 
            // txtCountry
            // 
            this.txtCountry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtCountry.BorderRadius = 5;
            this.txtCountry.BorderThickness = 2;
            this.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountry.DefaultText = "";
            this.txtCountry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCountry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCountry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCountry.Location = new System.Drawing.Point(604, 105);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PlaceholderText = "";
            this.txtCountry.SelectedText = "";
            this.txtCountry.Size = new System.Drawing.Size(354, 55);
            this.txtCountry.TabIndex = 9;
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
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(58, 215);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(482, 92);
            this.txtAddress.TabIndex = 8;
            // 
            // txtDesignDescription
            // 
            this.txtDesignDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesignDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtDesignDescription.BorderRadius = 5;
            this.txtDesignDescription.BorderThickness = 2;
            this.txtDesignDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesignDescription.DefaultText = "";
            this.txtDesignDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDesignDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDesignDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesignDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDesignDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesignDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDesignDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDesignDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesignDescription.Location = new System.Drawing.Point(58, 68);
            this.txtDesignDescription.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDesignDescription.Multiline = true;
            this.txtDesignDescription.Name = "txtDesignDescription";
            this.txtDesignDescription.PlaceholderText = "";
            this.txtDesignDescription.SelectedText = "";
            this.txtDesignDescription.Size = new System.Drawing.Size(482, 92);
            this.txtDesignDescription.TabIndex = 7;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblPaymentMethod.Location = new System.Drawing.Point(54, 435);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(216, 32);
            this.lblPaymentMethod.TabIndex = 6;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblPayment.Location = new System.Drawing.Point(52, 338);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(120, 32);
            this.lblPayment.TabIndex = 5;
            this.lblPayment.Text = "Payment:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblCity.Location = new System.Drawing.Point(598, 302);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(65, 32);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblState.Location = new System.Drawing.Point(597, 178);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(77, 32);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblCountry.Location = new System.Drawing.Point(597, 68);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(114, 32);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblAddress.Location = new System.Drawing.Point(52, 178);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(113, 32);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblDesignDescription
            // 
            this.lblDesignDescription.AutoSize = true;
            this.lblDesignDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDesignDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblDesignDescription.Location = new System.Drawing.Point(52, 31);
            this.lblDesignDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesignDescription.Name = "lblDesignDescription";
            this.lblDesignDescription.Size = new System.Drawing.Size(239, 32);
            this.lblDesignDescription.TabIndex = 0;
            this.lblDesignDescription.Text = "Design Description:";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckOut";
            this.Size = new System.Drawing.Size(1125, 769);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Label lblDesignDescription;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblPaymentMethod;
        private Guna.UI2.WinForms.Guna2TextBox txtDesignDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtCountry;
        private Guna.UI2.WinForms.Guna2TextBox txtState;
        private Guna.UI2.WinForms.Guna2TextBox txtCity;
        private Guna.UI2.WinForms.Guna2TextBox txtPayment;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPaymentMethod;
        private Guna.UI2.WinForms.Guna2Button btnBuy;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}