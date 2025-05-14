using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class ViewFinancialReport : UserControl
    {
        private List<FinancialReportBL> reportsList;
        public ViewFinancialReport()
        {
            InitializeComponent();
            LoadFinancialReports();
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

        private void dgvFinancialReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
