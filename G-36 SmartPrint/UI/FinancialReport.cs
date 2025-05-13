using System;
using System.Collections.Generic;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class FinancialReport : UserControl
    {
        private List<FinancialReportBL> reportsList;
        private FinancialReportBL currentReport;
        private ManagerBL currentManager;

        public FinancialReport()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set current manager (you might want to get this from login context)
            currentManager = ManagerBL.GetManagerByID(1); // Replace with actual manager ID

            // Configure form
            txtManagerName.Text = currentManager?.UserName ?? "N/A";
            txtManagerName.ReadOnly = true;
            dtpReportDate.Value = DateTime.Now;

            // Set event handlers
            dgvFinancialData.CellDoubleClick += DgvFinancialData_CellDoubleClick;
            btnSubmit.Click += BtnSubmit_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnClear.Click += BtnClear_Click;


            // Load data
            LoadFinancialReports();
            CalculateTotals();
        }

        private void LoadFinancialReports()
        {
            try
            {
                reportsList = FinancialReportDL.LoadAllReports();
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading financial reports: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            dgvFinancialData.DataSource = null;
            dgvFinancialData.DataSource = reportsList;

            // Format columns
            if (dgvFinancialData.Columns.Count > 0)
            {
                dgvFinancialData.Columns["finance_id"].Visible = false;
                dgvFinancialData.Columns["Manager"].Visible = false;

                // Format date column
                if (dgvFinancialData.Columns["Date"] != null)
                {
                    dgvFinancialData.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }

                // Format currency columns
                string[] currencyColumns = { "totalRevinue", "totalexpenses", "totalprofit" };
                foreach (string col in currencyColumns)
                {
                    if (dgvFinancialData.Columns[col] != null)
                    {
                        dgvFinancialData.Columns[col].DefaultCellStyle.Format = "C2";
                    }
                }
            }
        }

        private void DgvFinancialData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvFinancialData.Rows.Count)
                return;

            try
            {
                currentReport = (FinancialReportBL)dgvFinancialData.Rows[e.RowIndex].DataBoundItem;
                DisplayReportDetails(currentReport);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayReportDetails(FinancialReportBL report)
        {
            if (report == null) return;

            txtManagerName.Text = report.Manager?.UserName ?? "N/A";
            dtpReportDate.Value = report.Date;
            txtTotalRevenue.Text = report.totalRevinue.ToString("0.00");
            txtTotalExpenses.Text = report.totalexpenses.ToString("0.00");
            txtNetProfit.Text = report.totalprofit.ToString("0.00");

            // Enable appropriate buttons
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void CalculateTotals()
        {
            if (decimal.TryParse(txtTotalRevenue.Text, out decimal revenue) &&
                decimal.TryParse(txtTotalExpenses.Text, out decimal expenses))
            {
                decimal profit = revenue - expenses;
                txtNetProfit.Text = profit.ToString("0.00");
            }
        }

        private bool ValidateInputs()
        {
            if (!decimal.TryParse(txtTotalRevenue.Text, out decimal revenue) || revenue < 0)
            {
                MessageBox.Show("Please enter a valid positive revenue amount", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtTotalExpenses.Text, out decimal expenses) || expenses < 0)
            {
                MessageBox.Show("Please enter a valid positive expenses amount", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                decimal revenue = decimal.Parse(txtTotalRevenue.Text);
                decimal expenses = decimal.Parse(txtTotalExpenses.Text);
                decimal profit = revenue - expenses;

                var newReport = new FinancialReportBL(
                    0, // ID will be set by database
                    currentManager,
                    dtpReportDate.Value,
                    revenue,
                    expenses,
                    profit
                );

                if (FinancialReportDL.AddFinancialReport(newReport))
                {
                    MessageBox.Show("Financial report added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh data
                    LoadFinancialReports();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding financial report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (currentReport == null)
            {
                MessageBox.Show("Please select a report to update", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                decimal revenue = decimal.Parse(txtTotalRevenue.Text);
                decimal expenses = decimal.Parse(txtTotalExpenses.Text);
                decimal profit = revenue - expenses;

                currentReport.Date = dtpReportDate.Value;
                currentReport.totalRevinue = revenue;
                currentReport.totalexpenses = expenses;
                currentReport.totalprofit = profit;

                // In a real app, you would call an Update method in DL
                // For now, we'll delete and re-add (not ideal for production)
                if (FinancialReportDL.DeleteReportById(currentReport.Finance_id) &&
                    FinancialReportDL.AddFinancialReport(currentReport))
                {
                    MessageBox.Show("Financial report updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh data
                    LoadFinancialReports();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating financial report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            currentReport = null;
            txtTotalRevenue.Text = "";
            txtTotalExpenses.Text = "";
            txtNetProfit.Text = "";
            dtpReportDate.Value = DateTime.Now;

            btnSubmit.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void TxtTotalRevenue_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void TxtTotalExpenses_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtNetProfit_TextChanged(object sender, EventArgs e)
        {
            // This can be empty or used for validation

        }


        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvFinancialData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
