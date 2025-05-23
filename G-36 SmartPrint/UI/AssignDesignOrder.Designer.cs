﻿namespace G_36_SmartPrint.UI
{
    partial class AssignDesignOrder
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
            this.dgvDesignOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnAssign = new Guna.UI2.WinForms.Guna2Button();
            this.txtDesignDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbOrder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbDesigner = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDesignDescription = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblDesigner = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignOrders)).BeginInit();
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
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
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
            this.lblTitle.Size = new System.Drawing.Size(533, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Assign Designing Orders";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dgvDesignOrders);
            this.mainPanel.Controls.Add(this.btnClear);
            this.mainPanel.Controls.Add(this.btnAssign);
            this.mainPanel.Controls.Add(this.txtDesignDescription);
            this.mainPanel.Controls.Add(this.cmbOrder);
            this.mainPanel.Controls.Add(this.cmbDesigner);
            this.mainPanel.Controls.Add(this.lblDesignDescription);
            this.mainPanel.Controls.Add(this.lblOrder);
            this.mainPanel.Controls.Add(this.lblDesigner);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 123);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.mainPanel.Size = new System.Drawing.Size(1200, 800);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // dgvDesignOrders
            // 
            this.dgvDesignOrders.AllowUserToAddRows = false;
            this.dgvDesignOrders.AllowUserToDeleteRows = false;
            this.dgvDesignOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDesignOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDesignOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDesignOrders.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDesignOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDesignOrders.ColumnHeadersHeight = 40;
            this.dgvDesignOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDesignOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDesignOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDesignOrders.Location = new System.Drawing.Point(30, 472);
            this.dgvDesignOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDesignOrders.Name = "dgvDesignOrders";
            this.dgvDesignOrders.ReadOnly = true;
            this.dgvDesignOrders.RowHeadersVisible = false;
            this.dgvDesignOrders.RowHeadersWidth = 62;
            this.dgvDesignOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDesignOrders.Size = new System.Drawing.Size(1140, 297);
            this.dgvDesignOrders.TabIndex = 9;
            this.dgvDesignOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDesignOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDesignOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDesignOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDesignOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDesignOrders.ThemeStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.dgvDesignOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDesignOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDesignOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDesignOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDesignOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDesignOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDesignOrders.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDesignOrders.ThemeStyle.ReadOnly = true;
            this.dgvDesignOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDesignOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDesignOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDesignOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDesignOrders.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDesignOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDesignOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDesignOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesignOrders_CellContentClick);
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
            this.btnClear.Location = new System.Drawing.Point(940, 383);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 55);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
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
            this.btnAssign.Location = new System.Drawing.Point(648, 383);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(180, 55);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign";
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
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
            this.txtDesignDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDesignDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDesignDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDesignDescription.Location = new System.Drawing.Point(30, 318);
            this.txtDesignDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtDesignDescription.Multiline = true;
            this.txtDesignDescription.Name = "txtDesignDescription";
            this.txtDesignDescription.PlaceholderText = "";
            this.txtDesignDescription.ReadOnly = true;
            this.txtDesignDescription.SelectedText = "";
            this.txtDesignDescription.Size = new System.Drawing.Size(454, 120);
            this.txtDesignDescription.TabIndex = 5;
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
            this.cmbOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbOrder.ItemHeight = 30;
            this.cmbOrder.Location = new System.Drawing.Point(30, 197);
            this.cmbOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(452, 36);
            this.cmbOrder.TabIndex = 4;
            // 
            // cmbDesigner
            // 
            this.cmbDesigner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDesigner.BackColor = System.Drawing.Color.Transparent;
            this.cmbDesigner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbDesigner.BorderRadius = 5;
            this.cmbDesigner.BorderThickness = 2;
            this.cmbDesigner.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDesigner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesigner.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDesigner.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDesigner.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbDesigner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbDesigner.ItemHeight = 30;
            this.cmbDesigner.Location = new System.Drawing.Point(30, 77);
            this.cmbDesigner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDesigner.Name = "cmbDesigner";
            this.cmbDesigner.Size = new System.Drawing.Size(452, 36);
            this.cmbDesigner.TabIndex = 3;
            // 
            // lblDesignDescription
            // 
            this.lblDesignDescription.AutoSize = true;
            this.lblDesignDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDesignDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblDesignDescription.Location = new System.Drawing.Point(32, 272);
            this.lblDesignDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesignDescription.Name = "lblDesignDescription";
            this.lblDesignDescription.Size = new System.Drawing.Size(239, 32);
            this.lblDesignDescription.TabIndex = 2;
            this.lblDesignDescription.Text = "Design Description:";
            this.lblDesignDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblOrder.Location = new System.Drawing.Point(34, 166);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(88, 32);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "Order:";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesigner
            // 
            this.lblDesigner.AutoSize = true;
            this.lblDesigner.BackColor = System.Drawing.Color.Transparent;
            this.lblDesigner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesigner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblDesigner.Location = new System.Drawing.Point(32, 31);
            this.lblDesigner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesigner.Name = "lblDesigner";
            this.lblDesigner.Size = new System.Drawing.Size(197, 32);
            this.lblDesigner.TabIndex = 0;
            this.lblDesigner.Text = "Designer Name:";
            this.lblDesigner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AssignDesignOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AssignDesignOrder";
            this.Size = new System.Drawing.Size(1200, 923);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDesignOrders;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnAssign;
        private Guna.UI2.WinForms.Guna2TextBox txtDesignDescription;
        private System.Windows.Forms.Label lblDesignDescription;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblDesigner;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOrder;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDesigner;
    }
}