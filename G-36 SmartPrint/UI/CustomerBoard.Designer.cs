namespace G_36_SmartPrint.UI
{
    partial class CustomerBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerBoard));
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAppreciation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblServices = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDesignProducts = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCompany = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelImage = new Guna.UI2.WinForms.Guna2Panel();
            this.picSideImage = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSideImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Violet;
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 25, 20, 20);
            this.panelHeader.Size = new System.Drawing.Size(984, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(327, 38);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(381, 57);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME {name}";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 100);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelContent);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(20, 15, 10, 15);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.panelImage);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(10, 15, 20, 15);
            this.splitContainerMain.Size = new System.Drawing.Size(984, 484);
            this.splitContainerMain.SplitterDistance = 584;
            this.splitContainerMain.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderRadius = 15;
            this.panelContent.Controls.Add(this.lblAppreciation);
            this.panelContent.Controls.Add(this.lblServices);
            this.panelContent.Controls.Add(this.lblDesignProducts);
            this.panelContent.Controls.Add(this.lblCompany);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Location = new System.Drawing.Point(20, 15);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(15);
            this.panelContent.Size = new System.Drawing.Size(554, 454);
            this.panelContent.TabIndex = 0;
            // 
            // lblAppreciation
            // 
            this.lblAppreciation.BackColor = System.Drawing.Color.Transparent;
            this.lblAppreciation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppreciation.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblAppreciation.IsSelectionEnabled = false;
            this.lblAppreciation.Location = new System.Drawing.Point(15, 15);
            this.lblAppreciation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblAppreciation.Name = "lblAppreciation";
            this.lblAppreciation.Size = new System.Drawing.Size(766, 126);
            this.lblAppreciation.TabIndex = 0;
            this.lblAppreciation.Text = resources.GetString("lblAppreciation.Text");
            // 
            // lblServices
            // 
            this.lblServices.BackColor = System.Drawing.Color.Transparent;
            this.lblServices.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblServices.IsSelectionEnabled = false;
            this.lblServices.Location = new System.Drawing.Point(15, 96);
            this.lblServices.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(515, 187);
            this.lblServices.TabIndex = 1;
            this.lblServices.Text = resources.GetString("lblServices.Text");
            // 
            // lblDesignProducts
            // 
            this.lblDesignProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblDesignProducts.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblDesignProducts.IsSelectionEnabled = false;
            this.lblDesignProducts.Location = new System.Drawing.Point(15, 237);
            this.lblDesignProducts.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblDesignProducts.Name = "lblDesignProducts";
            this.lblDesignProducts.Size = new System.Drawing.Size(433, 218);
            this.lblDesignProducts.TabIndex = 2;
            this.lblDesignProducts.Text = resources.GetString("lblDesignProducts.Text");
            // 
            // lblCompany
            // 
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblCompany.IsSelectionEnabled = false;
            this.lblCompany.Location = new System.Drawing.Point(15, 440);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(739, 156);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = resources.GetString("lblCompany.Text");
            // 
            // panelImage
            // 
            this.panelImage.BorderRadius = 15;
            this.panelImage.Controls.Add(this.picSideImage);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelImage.Location = new System.Drawing.Point(10, 15);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(366, 454);
            this.panelImage.TabIndex = 0;
            // 
            // picSideImage
            // 
            this.picSideImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSideImage.Location = new System.Drawing.Point(0, 0);
            this.picSideImage.Name = "picSideImage";
            this.picSideImage.Size = new System.Drawing.Size(366, 454);
            this.picSideImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSideImage.TabIndex = 0;
            this.picSideImage.TabStop = false;
            // 
            // CustomerBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "CustomerBoard";
            this.Size = new System.Drawing.Size(984, 584);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSideImage)).EndInit();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAppreciation;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblServices;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDesignProducts;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCompany;
        private Guna.UI2.WinForms.Guna2Panel panelImage;
        private System.Windows.Forms.PictureBox picSideImage;
    }
}