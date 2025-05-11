using Microsoft.Reporting.WinForms;

namespace G_36_SmartPrint.UI
{
    partial class GenerateReports
    {
        //    /// <summary>
        //    /// Required designer variable.
        //    /// </summary>
        //    private System.ComponentModel.IContainer components = null;

        //    /// <summary>
        //    /// Clean up any resources being used.
        //    /// </summary>
        //    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing && (components != null))
        //        {
        //            components.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }

        //    #region Component Designer generated code

        //    /// <summary>
        //    /// Required method for Designer support - do not modify
        //    /// the contents of this method with the code editor.
        //    /// </summary>
        //    private void InitializeComponent()
        //    {
        //        this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
        //        this.lblTitle = new System.Windows.Forms.Label();
        //        this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
        //        this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
        //        this.btnExportPDF = new Guna.UI2.WinForms.Guna2Button();
        //        this.btnGenerate = new Guna.UI2.WinForms.Guna2Button();
        //        this.cmbReportType = new Guna.UI2.WinForms.Guna2ComboBox();
        //        this.panelHeader.SuspendLayout();
        //        this.mainPanel.SuspendLayout();
        //        this.SuspendLayout();
        //        // 
        //        // panelHeader
        //        // 
        //        this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(43)))), ((int)(((byte)(226)))));
        //        this.panelHeader.Controls.Add(this.lblTitle);
        //        this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
        //        this.panelHeader.Location = new System.Drawing.Point(0, 0);
        //        this.panelHeader.Name = "panelHeader";
        //        this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
        //        this.panelHeader.ShadowDecoration.Parent = this.panelHeader;
        //        this.panelHeader.Size = new System.Drawing.Size(800, 80);
        //        this.panelHeader.TabIndex = 0;
        //        // 
        //        // lblTitle
        //        // 
        //        this.lblTitle.AutoSize = true;
        //        this.lblTitle.BackColor = System.Drawing.Color.Transparent;
        //        this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
        //        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        this.lblTitle.ForeColor = System.Drawing.Color.White;
        //        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        //        this.lblTitle.Name = "lblTitle";
        //        this.lblTitle.Size = new System.Drawing.Size(231, 41);
        //        this.lblTitle.TabIndex = 0;
        //        this.lblTitle.Text = "Generate Reports";
        //        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //        // 
        //        // mainPanel
        //        // 
        //        this.mainPanel.Controls.Add(this.reportViewer);
        //        this.mainPanel.Controls.Add(this.btnExportPDF);
        //        this.mainPanel.Controls.Add(this.btnGenerate);
        //        this.mainPanel.Controls.Add(this.cmbReportType);
        //        this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        //        this.mainPanel.Location = new System.Drawing.Point(0, 80);
        //        this.mainPanel.Name = "mainPanel";
        //        this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
        //        this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
        //        this.mainPanel.Size = new System.Drawing.Size(800, 520);
        //        this.mainPanel.TabIndex = 1;
        //        // 
        //        // reportViewer
        //        // 
        //        this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        //        | System.Windows.Forms.AnchorStyles.Left)
        //        | System.Windows.Forms.AnchorStyles.Right)));
        //        this.reportViewer.LocalReport.ReportEmbeddedResource = "";
        //        this.reportViewer.Location = new System.Drawing.Point(20, 100);
        //        this.reportViewer.Name = "ReportViewer";
        //        this.reportViewer.ServerReport.BearerToken = null;
        //        this.reportViewer.Size = new System.Drawing.Size(760, 400);
        //        this.reportViewer.TabIndex = 3;
        //        // 
        //        // btnExportPDF
        //        // 
        //        this.btnExportPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        //        this.btnExportPDF.BorderRadius = 5;
        //        this.btnExportPDF.CheckedState.Parent = this.btnExportPDF;
        //        this.btnExportPDF.CustomImages.Parent = this.btnExportPDF;
        //        this.btnExportPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        //        this.btnExportPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        //        this.btnExportPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
        //        this.btnExportPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
        //        this.btnExportPDF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
        //        this.btnExportPDF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        //        this.btnExportPDF.ForeColor = System.Drawing.Color.White;
        //        this.btnExportPDF.HoverState.Parent = this.btnExportPDF;
        //        this.btnExportPDF.Location = new System.Drawing.Point(660, 50);
        //        this.btnExportPDF.Name = "btnExportPDF";
        //        this.btnExportPDF.ShadowDecoration.Parent = this.btnExportPDF;
        //        this.btnExportPDF.Size = new System.Drawing.Size(120, 36);
        //        this.btnExportPDF.TabIndex = 2;
        //        this.btnExportPDF.Text = "Export to PDF";
        //        // 
        //        // btnGenerate
        //        // 
        //        this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        //        this.btnGenerate.BorderRadius = 5;
        //        this.btnGenerate.CheckedState.Parent = this.btnGenerate;
        //        this.btnGenerate.CustomImages.Parent = this.btnGenerate;
        //        this.btnGenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        //        this.btnGenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        //        this.btnGenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
        //        this.btnGenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
        //        this.btnGenerate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
        //        this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        //        this.btnGenerate.ForeColor = System.Drawing.Color.White;
        //        this.btnGenerate.HoverState.Parent = this.btnGenerate;
        //        this.btnGenerate.Location = new System.Drawing.Point(520, 50);
        //        this.btnGenerate.Name = "btnGenerate";
        //        this.btnGenerate.ShadowDecoration.Parent = this.btnGenerate;
        //        this.btnGenerate.Size = new System.Drawing.Size(120, 36);
        //        this.btnGenerate.TabIndex = 1;
        //        this.btnGenerate.Text = "Generate Report";
        //        // 
        //        // cmbReportType
        //        // 
        //        this.cmbReportType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        //        | System.Windows.Forms.AnchorStyles.Right)));
        //        this.cmbReportType.BackColor = System.Drawing.Color.Transparent;
        //        this.cmbReportType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
        //        this.cmbReportType.BorderRadius = 5;
        //        this.cmbReportType.BorderThickness = 2;
        //        this.cmbReportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        //        this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        //        this.cmbReportType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
        //        this.cmbReportType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
        //        this.cmbReportType.FocusedState.Parent = this.cmbReportType;
        //        this.cmbReportType.Font = new System.Drawing.Font("Segoe UI", 11F);
        //        this.cmbReportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
        //        this.cmbReportType.HoverState.Parent = this.cmbReportType;
        //        this.cmbReportType.ItemHeight = 30;
        //        this.cmbReportType.Items.AddRange(new object[] {
        //        "Employee Report",
        //        "Orders Report",
        //        "Instructions Report",
        //        "Feedback Report",
        //        "Financial Report",
        //        "Salary Report",
        //        "Request Report"});
        //        this.cmbReportType.Location = new System.Drawing.Point(20, 50);
        //        this.cmbReportType.Name = "cmbReportType";
        //        this.cmbReportType.ShadowDecoration.Parent = this.cmbReportType;
        //        this.cmbReportType.Size = new System.Drawing.Size(480, 36);
        //        this.cmbReportType.TabIndex = 0;
        //        // 
        //        // GenerateReports
        //        // 
        //        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //        this.BackColor = System.Drawing.Color.White;
        //        this.Controls.Add(this.mainPanel);
        //        this.Controls.Add(this.panelHeader);
        //        this.Name = "GenerateReports";
        //        this.Size = new System.Drawing.Size(800, 600);
        //        this.panelHeader.ResumeLayout(false);
        //        this.panelHeader.PerformLayout();
        //        this.mainPanel.ResumeLayout(false);
        //        this.ResumeLayout(false);

        //    }

        //    #endregion

        //    private Guna.UI2.WinForms.Guna2Panel panelHeader;
        //    private System.Windows.Forms.Label lblTitle;
        //    private Guna.UI2.WinForms.Guna2Panel mainPanel;
        //    private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        //    private Guna.UI2.WinForms.Guna2Button btnExportPDF;
        //    private Guna.UI2.WinForms.Guna2Button btnGenerate;
        //    private Guna.UI2.WinForms.Guna2ComboBox cmbReportType;
    }
}