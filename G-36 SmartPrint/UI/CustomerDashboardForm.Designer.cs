namespace G_36_SmartPrint.UI
{
    partial class CustomerDashboardForm
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

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnView = new Guna.UI2.WinForms.Guna2Button();
            this.btnFeedback = new Guna.UI2.WinForms.Guna2Button();
            this.btnApprove = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHeader.Controls.Add(this.lblCompanyName);
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 113);
            this.panelHeader.TabIndex = 0;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(271, 41);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(1119, 61);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "SMART PRINT: Custom Design and Clothing\r\n";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::G_36_SmartPrint.Properties.Resources.log_removebg_preview;
            this.picLogo.Location = new System.Drawing.Point(0, -23);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(265, 164);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelNavigation.Controls.Add(this.btnLogout);
            this.panelNavigation.Controls.Add(this.btnView);
            this.panelNavigation.Controls.Add(this.btnFeedback);
            this.panelNavigation.Controls.Add(this.btnApprove);
            this.panelNavigation.Controls.Add(this.btnOrder);
            this.panelNavigation.Controls.Add(this.btnDashboard);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 113);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(220, 587);
            this.panelNavigation.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogout.BorderRadius = 3;
            this.btnLogout.BorderThickness = 2;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogout.FocusedColor = System.Drawing.Color.Lime;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 527);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 57);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnView.BorderRadius = 3;
            this.btnView.BorderThickness = 2;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnView.FocusedColor = System.Drawing.Color.Lime;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(0, 189);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(220, 57);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View Order Status";
            this.btnView.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.Transparent;
            this.btnFeedback.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFeedback.BorderRadius = 3;
            this.btnFeedback.BorderThickness = 2;
            this.btnFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeedback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFeedback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFeedback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFeedback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFeedback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFeedback.FocusedColor = System.Drawing.Color.Lime;
            this.btnFeedback.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.Location = new System.Drawing.Point(0, 252);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(220, 57);
            this.btnFeedback.TabIndex = 0;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Transparent;
            this.btnApprove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnApprove.BorderRadius = 3;
            this.btnApprove.BorderThickness = 2;
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApprove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApprove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApprove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApprove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnApprove.FocusedColor = System.Drawing.Color.Lime;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(0, 126);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(220, 57);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Appprove Design";
            this.btnApprove.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOrder.BorderRadius = 3;
            this.btnOrder.BorderThickness = 2;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOrder.FocusedColor = System.Drawing.Color.Lime;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(0, 63);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(220, 57);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Book Orders";
            this.btnOrder.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDashboard.BorderRadius = 3;
            this.btnDashboard.BorderThickness = 2;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDashboard.FocusedColor = System.Drawing.Color.Lime;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 57);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 113);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(980, 587);
            this.panelMain.TabIndex = 2;
            // 
            // CustomerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CustomerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnApprove;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnFeedback;
        private Guna.UI2.WinForms.Guna2Button btnView;
    }
}