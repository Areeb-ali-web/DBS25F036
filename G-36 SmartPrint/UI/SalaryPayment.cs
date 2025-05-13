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
    public partial class SalaryPayment : UserControl
    {
        private int _selectedPaymentId = -1;
        private int _selectedEmployeeId = -1;

        public SalaryPayment()
        {
            InitializeComponent();
            LoadDesignerSalaries(); // Load data when control initializes
            dgvPaymentHistory.CellDoubleClick += DgvPaymentHistory_CellDoubleClick;
            btnPay.Click += BtnPay_Click;
            btnPay.Enabled = false; // Disable pay button until a salary is selected
        }

        private void LoadDesignerSalaries()
        {
            try
            {
                //if (LoginHelpers.currentEmployee == null)
                //{
                //    MessageBox.Show("No employee is currently logged in.");
                //    return;
                //}

                List<SalaryPaymentBL> salaries = Salary_PaymentDL.LoadAllSalaryPayments();

                dgvPaymentHistory.Rows.Clear();
                dgvPaymentHistory.Columns.Clear();

                // Add columns
                dgvPaymentHistory.Columns.Add("SalaryID", "Salary ID");
                dgvPaymentHistory.Columns.Add("EmployeeNAME", "Employee Name");
                dgvPaymentHistory.Columns.Add("Amount", "Amount");
                dgvPaymentHistory.Columns.Add("PaymentDate", "Payment Date");
                dgvPaymentHistory.Columns.Add("Status", "Status");
                dgvPaymentHistory.Columns.Add("employeeid", "employee id");

                // Populate rows
                foreach (var salary in salaries)
                {
                    dgvPaymentHistory.Rows.Add(
                        salary.getPaymentid(),
                        salary.employee?.UserName ?? "N/A",
                        salary.getAmount().ToString("C"),
                        salary.getPaymentdate().ToString("yyyy-MM-dd"),
                        salary.getSalary_status()?.LookupValue?? "unpaid",
                        salary.employee.EmployeeID
                    );
                }

                dgvPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading salary data:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvPaymentHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvPaymentHistory.Rows.Count)
                return;

            try
            {
                // Get selected row data
                DataGridViewRow row = dgvPaymentHistory.Rows[e.RowIndex];

                // Check if salary is already paid
                string status = row.Cells["Status"].Value?.ToString() ?? "";
                if (status.Equals("Paid", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This salary has already been paid.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Store selected payment and employee IDs
                _selectedPaymentId = Convert.ToInt32(row.Cells["SalaryID"].Value);
                _selectedEmployeeId = Convert.ToInt32(row.Cells["employeeid"].Value);

                // Update textboxes
                txtEmployee.Text = row.Cells["EmployeeNAME"].Value?.ToString() ?? "";
                txtAmount.Text = row.Cells["Amount"].Value?.ToString() ?? "";

                // Enable pay button
                btnPay.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting salary:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (_selectedPaymentId == -1 || _selectedEmployeeId == -1)
            {
                MessageBox.Show("Please select a salary to pay first.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Confirm payment
                var result = MessageBox.Show($"Are you sure you want to pay {txtAmount.Text} to {txtEmployee.Text}?",
                    "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Process payment
                    Salary_PaymentDL.PaySalary(_selectedEmployeeId);

                    // Refresh data and reset form
                    LoadDesignerSalaries();
                    ResetForm();

                    MessageBox.Show("Salary paid successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            txtEmployee.Text = "";
            txtAmount.Text = "";
            _selectedPaymentId = -1;
            _selectedEmployeeId = -1;
            btnPay.Enabled = false;
        }

        private void dgvPaymentHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Single click handler (if needed)
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployee.Text = "";
            txtAmount.Text = "";
            _selectedPaymentId = -1;
            _selectedEmployeeId = -1;
            btnPay.Enabled = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Salary_PaymentDL.PayAllSalaries();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}