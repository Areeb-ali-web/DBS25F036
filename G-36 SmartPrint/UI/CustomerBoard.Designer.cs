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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblAppreciation = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
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
            this.panelHeader.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(327, 38);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(246, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME {name}";
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
            this.panelContent.Controls.Add(this.lblAppreciation);
            this.panelContent.Controls.Add(this.lblCompany);
            this.panelContent.Controls.Add(this.lblServices);
            this.panelContent.Controls.Add(this.lblDesign);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(20, 15);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(554, 454);
            this.panelContent.TabIndex = 0;
            // 
            // lblAppreciation
            // 
            this.lblAppreciation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppreciation.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblAppreciation.Location = new System.Drawing.Point(0, 90);
            this.lblAppreciation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.lblAppreciation.Name = "lblAppreciation";
            this.lblAppreciation.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.lblAppreciation.Size = new System.Drawing.Size(554, 120);
            this.lblAppreciation.TabIndex = 0;
            this.lblAppreciation.Text = "We sincerely appreciate you choosing our services! Your trust means everything to" +
    " us.";
            // 
            // lblCompany
            // 
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompany.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCompany.Location = new System.Drawing.Point(0, 60);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(554, 30);
            this.lblCompany.TabIndex = 1;
            this.lblCompany.Text = "Our Clothing Company";
            // 
            // lblServices
            // 
            this.lblServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblServices.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblServices.Location = new System.Drawing.Point(0, 30);
            this.lblServices.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(554, 30);
            this.lblServices.TabIndex = 2;
            this.lblServices.Text = "Customer Services";
            // 
            // lblDesign
            // 
            this.lblDesign.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesign.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDesign.Location = new System.Drawing.Point(0, 0);
            this.lblDesign.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(554, 30);
            this.lblDesign.TabIndex = 3;
            this.lblDesign.Text = "Design Capabilities";
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.picSideImage);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSideImage)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblAppreciation;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox picSideImage;
    }
}