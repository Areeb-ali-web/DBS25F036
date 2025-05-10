namespace G_36_SmartPrint.UI
{
    partial class ManagerDashboardForm
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
            this.btnAssignDesigningOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageFinancial = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageConsumable = new Guna.UI2.WinForms.Guna2Button();
            this.btnRequest = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewInstructions = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewSalary = new Guna.UI2.WinForms.Guna2Button();
            this.btnAssignDeliveryOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewOrders = new Guna.UI2.WinForms.Guna2Button();
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
            this.panelHeader.Size = new System.Drawing.Size(1200, 113);
            this.panelHeader.TabIndex = 0;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(271, 41);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(726, 43);
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
            this.panelNavigation.Controls.Add(this.btnAssignDesigningOrder);
            this.panelNavigation.Controls.Add(this.btnManageFinancial);
            this.panelNavigation.Controls.Add(this.btnManageConsumable);
            this.panelNavigation.Controls.Add(this.btnRequest);
            this.panelNavigation.Controls.Add(this.btnViewInstructions);
            this.panelNavigation.Controls.Add(this.btnViewSalary);
            this.panelNavigation.Controls.Add(this.btnAssignDeliveryOrders);
            this.panelNavigation.Controls.Add(this.btnViewOrders);
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
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 527);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 57);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            // 
            // btnAssignDesigningOrder
            // 
            this.btnAssignDesigningOrder.Animated = true;
            this.btnAssignDesigningOrder.BorderRadius = 3;
            this.btnAssignDesigningOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignDesigningOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAssignDesigningOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAssignDesigningOrder.ForeColor = System.Drawing.Color.White;
            this.btnAssignDesigningOrder.Location = new System.Drawing.Point(0, 111);
            this.btnAssignDesigningOrder.Name = "btnAssignDesigningOrder";
            this.btnAssignDesigningOrder.Size = new System.Drawing.Size(220, 53);
            this.btnAssignDesigningOrder.TabIndex = 0;
            this.btnAssignDesigningOrder.Text = "Assign Designing Order";
            // 
            // btnManageFinancial
            // 
            this.btnManageFinancial.Animated = true;
            this.btnManageFinancial.BorderRadius = 3;
            this.btnManageFinancial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageFinancial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnManageFinancial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageFinancial.ForeColor = System.Drawing.Color.White;
            this.btnManageFinancial.Location = new System.Drawing.Point(0, 229);
            this.btnManageFinancial.Name = "btnManageFinancial";
            this.btnManageFinancial.Size = new System.Drawing.Size(220, 47);
            this.btnManageFinancial.TabIndex = 0;
            this.btnManageFinancial.Text = "Manage Financial";
            // 
            // btnManageConsumable
            // 
            this.btnManageConsumable.Animated = true;
            this.btnManageConsumable.BorderRadius = 3;
            this.btnManageConsumable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageConsumable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnManageConsumable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageConsumable.ForeColor = System.Drawing.Color.White;
            this.btnManageConsumable.Location = new System.Drawing.Point(0, 282);
            this.btnManageConsumable.Name = "btnManageConsumable";
            this.btnManageConsumable.Size = new System.Drawing.Size(220, 53);
            this.btnManageConsumable.TabIndex = 0;
            this.btnManageConsumable.Text = "Manage Consumables";
            // 
            // btnRequest
            // 
            this.btnRequest.Animated = true;
            this.btnRequest.BorderRadius = 3;
            this.btnRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.Location = new System.Drawing.Point(0, 341);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(220, 54);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Approve Request";
            // 
            // btnViewInstructions
            // 
            this.btnViewInstructions.Animated = true;
            this.btnViewInstructions.BorderRadius = 3;
            this.btnViewInstructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewInstructions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewInstructions.ForeColor = System.Drawing.Color.White;
            this.btnViewInstructions.Location = new System.Drawing.Point(0, 401);
            this.btnViewInstructions.Name = "btnViewInstructions";
            this.btnViewInstructions.Size = new System.Drawing.Size(220, 48);
            this.btnViewInstructions.TabIndex = 0;
            this.btnViewInstructions.Text = "View Instructions";
            // 
            // btnViewSalary
            // 
            this.btnViewSalary.Animated = true;
            this.btnViewSalary.BorderRadius = 3;
            this.btnViewSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSalary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewSalary.ForeColor = System.Drawing.Color.White;
            this.btnViewSalary.Location = new System.Drawing.Point(0, 455);
            this.btnViewSalary.Name = "btnViewSalary";
            this.btnViewSalary.Size = new System.Drawing.Size(220, 52);
            this.btnViewSalary.TabIndex = 0;
            this.btnViewSalary.Text = "View Salary";
            // 
            // btnAssignDeliveryOrders
            // 
            this.btnAssignDeliveryOrders.Animated = true;
            this.btnAssignDeliveryOrders.BorderRadius = 3;
            this.btnAssignDeliveryOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignDeliveryOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAssignDeliveryOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAssignDeliveryOrders.ForeColor = System.Drawing.Color.White;
            this.btnAssignDeliveryOrders.Location = new System.Drawing.Point(0, 170);
            this.btnAssignDeliveryOrders.Name = "btnAssignDeliveryOrders";
            this.btnAssignDeliveryOrders.Size = new System.Drawing.Size(220, 53);
            this.btnAssignDeliveryOrders.TabIndex = 0;
            this.btnAssignDeliveryOrders.Text = "Assign Delivery Order";
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Animated = true;
            this.btnViewOrders.BorderRadius = 3;
            this.btnViewOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewOrders.ForeColor = System.Drawing.Color.White;
            this.btnViewOrders.Location = new System.Drawing.Point(0, 55);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(220, 50);
            this.btnViewOrders.TabIndex = 0;
            this.btnViewOrders.Text = "View Orders";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.BorderRadius = 3;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 49);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
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
            // ManagerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ManagerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Designer Dashboard";
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
        private Guna.UI2.WinForms.Guna2Button btnViewOrders;
        private Guna.UI2.WinForms.Guna2Button btnAssignDesigningOrder;
        private Guna.UI2.WinForms.Guna2Button btnAssignDeliveryOrders;
        private Guna.UI2.WinForms.Guna2Button btnViewSalary;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnManageFinancial;
        private Guna.UI2.WinForms.Guna2Button btnViewInstructions;
        private Guna.UI2.WinForms.Guna2Button btnManageConsumable;
        private Guna.UI2.WinForms.Guna2Button btnRequest;
    }
}