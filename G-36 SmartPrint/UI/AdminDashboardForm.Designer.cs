namespace G_36_SmartPrint.UI
{
    partial class AdminDashboardForm
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
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCompanyName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelNavigation = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelivery = new Guna.UI2.WinForms.Guna2Button();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewFeedback = new Guna.UI2.WinForms.Guna2Button();
            this.btnFinancal = new Guna.UI2.WinForms.Guna2Button();
            this.btnInstuctions = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageSalary = new Guna.UI2.WinForms.Guna2Button();
            this.btnProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDesigner = new Guna.UI2.WinForms.Guna2Button();
            this.btnManager = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
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
            this.panelHeader.Size = new System.Drawing.Size(1240, 113);
            this.panelHeader.TabIndex = 0;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(271, 41);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(1101, 63);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "SMART PRINT: Custom Design and Clothing";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::G_36_SmartPrint.Properties.Resources.log_removebg_preview;
            this.picLogo.ImageRotate = 0F;
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
            this.panelNavigation.Controls.Add(this.btnDelivery);
            this.panelNavigation.Controls.Add(this.btnReport);
            this.panelNavigation.Controls.Add(this.btnViewFeedback);
            this.panelNavigation.Controls.Add(this.btnFinancal);
            this.panelNavigation.Controls.Add(this.btnInstuctions);
            this.panelNavigation.Controls.Add(this.btnManageSalary);
            this.panelNavigation.Controls.Add(this.btnProducts);
            this.panelNavigation.Controls.Add(this.btnAddDesigner);
            this.panelNavigation.Controls.Add(this.btnManager);
            this.panelNavigation.Controls.Add(this.btnDashboard);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 113);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(220, 587);
            this.panelNavigation.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BorderRadius = 3;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 527);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 57);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            // 
            // btnDelivery
            // 
            this.btnDelivery.Animated = true;
            this.btnDelivery.BorderRadius = 3;
            this.btnDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelivery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Location = new System.Drawing.Point(0, 155);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(220, 46);
            this.btnDelivery.TabIndex = 0;
            this.btnDelivery.Text = "Manage Delivery";
            // 
            // btnReport
            // 
            this.btnReport.Animated = true;
            this.btnReport.BorderRadius = 3;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(-3, 475);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(220, 46);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Generate Report";
            // 
            // btnViewFeedback
            // 
            this.btnViewFeedback.Animated = true;
            this.btnViewFeedback.BorderRadius = 3;
            this.btnViewFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewFeedback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewFeedback.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnViewFeedback.ForeColor = System.Drawing.Color.White;
            this.btnViewFeedback.Location = new System.Drawing.Point(0, 425);
            this.btnViewFeedback.Name = "btnViewFeedback";
            this.btnViewFeedback.Size = new System.Drawing.Size(220, 46);
            this.btnViewFeedback.TabIndex = 0;
            this.btnViewFeedback.Text = "View Feedback";
            // 
            // btnFinancal
            // 
            this.btnFinancal.Animated = true;
            this.btnFinancal.BorderRadius = 3;
            this.btnFinancal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinancal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFinancal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnFinancal.ForeColor = System.Drawing.Color.White;
            this.btnFinancal.Location = new System.Drawing.Point(0, 373);
            this.btnFinancal.Name = "btnFinancal";
            this.btnFinancal.Size = new System.Drawing.Size(220, 46);
            this.btnFinancal.TabIndex = 0;
            this.btnFinancal.Text = "View Financials";
            // 
            // btnInstuctions
            // 
            this.btnInstuctions.Animated = true;
            this.btnInstuctions.BorderRadius = 3;
            this.btnInstuctions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstuctions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnInstuctions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnInstuctions.ForeColor = System.Drawing.Color.White;
            this.btnInstuctions.Location = new System.Drawing.Point(0, 321);
            this.btnInstuctions.Name = "btnInstuctions";
            this.btnInstuctions.Size = new System.Drawing.Size(220, 46);
            this.btnInstuctions.TabIndex = 0;
            this.btnInstuctions.Text = "Give Instruction";
            // 
            // btnManageSalary
            // 
            this.btnManageSalary.Animated = true;
            this.btnManageSalary.BorderRadius = 3;
            this.btnManageSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSalary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnManageSalary.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnManageSalary.ForeColor = System.Drawing.Color.White;
            this.btnManageSalary.Location = new System.Drawing.Point(0, 258);
            this.btnManageSalary.Name = "btnManageSalary";
            this.btnManageSalary.Size = new System.Drawing.Size(220, 57);
            this.btnManageSalary.TabIndex = 0;
            this.btnManageSalary.Text = "Manage Salary";
            this.btnManageSalary.Click += new System.EventHandler(this.btnManageSalary_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Animated = true;
            this.btnProducts.BorderRadius = 3;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(0, 207);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(220, 45);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Manage Products";
            // 
            // btnAddDesigner
            // 
            this.btnAddDesigner.Animated = true;
            this.btnAddDesigner.BorderRadius = 3;
            this.btnAddDesigner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDesigner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddDesigner.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddDesigner.ForeColor = System.Drawing.Color.White;
            this.btnAddDesigner.Location = new System.Drawing.Point(0, 105);
            this.btnAddDesigner.Name = "btnAddDesigner";
            this.btnAddDesigner.Size = new System.Drawing.Size(220, 44);
            this.btnAddDesigner.TabIndex = 0;
            this.btnAddDesigner.Text = "Manage Designers";
            // 
            // btnManager
            // 
            this.btnManager.Animated = true;
            this.btnManager.BorderRadius = 3;
            this.btnManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManager.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnManager.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnManager.ForeColor = System.Drawing.Color.White;
            this.btnManager.Location = new System.Drawing.Point(0, 56);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(220, 43);
            this.btnManager.TabIndex = 0;
            this.btnManager.Text = "Manage Managers";
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.BorderRadius = 3;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 113);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1020, 587);
            this.panelMain.TabIndex = 2;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCompanyName;
        private Guna.UI2.WinForms.Guna2Panel panelNavigation;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnAddDesigner;
        private Guna.UI2.WinForms.Guna2Button btnManager;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnProducts;
        private Guna.UI2.WinForms.Guna2Button btnDelivery;
        private Guna.UI2.WinForms.Guna2Button btnInstuctions;
        private Guna.UI2.WinForms.Guna2Button btnManageSalary;
        private Guna.UI2.WinForms.Guna2Button btnFinancal;
        private Guna.UI2.WinForms.Guna2Button btnViewFeedback;
        private Guna.UI2.WinForms.Guna2Button btnReport;
    }
}