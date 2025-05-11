using System;
using System.Windows.Forms;
// using Microsoft.Reporting.WinForms;
using System.IO;
using Guna.UI2.WinForms;

namespace G_36_SmartPrint.UI
{
    public partial class GenerateReports : UserControl
    {
        //public GenerateReports()
        //{
        //    InitializeComponent();
        //}

        //private void GenerateReports_Load(object sender, EventArgs e)
        //{
        //    // Initialize the report viewer
        //    this.reportViewer.LocalReport.ReportEmbeddedResource = "";
        //    this.reportViewer.RefreshReport();
        //}

        //private void btnGenerate_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbReportType.SelectedItem == null)
        //        {
        //            MessageBox.Show("Please select a report type first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        string selectedReport = cmbReportType.SelectedItem.ToString();
        //        string reportPath = GetReportPath(selectedReport);

        //        if (string.IsNullOrEmpty(reportPath))
        //        {
        //            MessageBox.Show("Report definition not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Set the report path and refresh
        //        this.reportViewer.LocalReport.ReportPath = reportPath;

        //        // TODO: Add your data sources here based on the report type
        //        // Example:
        //        // this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", yourData));

        //        this.reportViewer.RefreshReport();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private string GetReportPath(string reportName)
        //{
        //    // Map report names to their RDLC file paths
        //    switch (reportName)
        //    {
        //        case "Employee Report":
        //            return Path.Combine(Application.StartupPath, "Reports\\EmployeeReport.rdlc");
        //        case "Orders Report":
        //            return Path.Combine(Application.StartupPath, "Reports\\OrdersReport.rdlc");
        //        case "Instructions Report":
        //            return Path.Combine(Application.StartupPath, "Reports\\InstructionsReport.rdlc");
        //        case "Feedback Report":
        //            return Path.Combine(Application.StartupPath, "Reports\\FeedbackReport.rdlc");
        //        case "Financial Report":
        //            return Path.Combine(Application.StartupPath, "Reports\\FinancialReport.rdlc");
        //        case "Salary Report":
        //            return Path.Combine(Application.StartupPath, "Reports\\SalaryReport.rdlc");
        //        case "Request Report":
        //            return Path.Combine(Application.StartupPath, "Reports\\RequestReport.rdlc");
        //        default:
        //            return null;
        //    }
        //}

        //private void btnExportPDF_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (reportViewer.LocalReport.ReportPath == null)
        //        {
        //            MessageBox.Show("Please generate a report first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        SaveFileDialog saveFileDialog = new SaveFileDialog
        //        {
        //            Filter = "PDF files (*.pdf)|*.pdf",
        //            Title = "Save Report as PDF",
        //            FileName = $"{cmbReportType.SelectedItem}_Report_{DateTime.Now:yyyyMMdd}.pdf"
        //        };

        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            byte[] bytes = reportViewer.LocalReport.Render("PDF");
        //            File.WriteAllBytes(saveFileDialog.FileName, bytes);
        //            MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}