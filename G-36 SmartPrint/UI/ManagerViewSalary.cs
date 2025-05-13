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
    public partial class ManagerViewSalary : UserControl
    {
        public ManagerViewSalary()
        {
            InitializeComponent();
            this.Load += DesignerViewSalary_Load;
        }
        private void DesignerViewSalary_Load(object sender, EventArgs e)
        {
            LoadDesignerSalaries();
        }

        private void LoadDesignerSalaries()
        {
            try
            {
                txtManagerName.Text = LoginHelpers.currentuser.UserName;
                // ✅ FIX: Make sure currentEmployee is not null and EmployeeID is accessible
                if (LoginHelpers.currentEmployee == null)
                {
                    MessageBox.Show("No designer is currently logged in.");
                    return;
                }

                int designerId = LoginHelpers.currentEmployee.EmployeeID;

                // ✅ FIX: Confirm method LoadSalariesByEmployeeId exists and returns a list
                List<SalaryPaymentBL> salaries = Salary_PaymentDL.LoadSalariesByEmployeeId(LoginHelpers.currentEmployee.EmployeeID);

                dgvSalaryStatus.Rows.Clear();
                dgvSalaryStatus.Columns.Clear();

                dgvSalaryStatus.Columns.Add("PaymentID", "Payment ID");
                dgvSalaryStatus.Columns.Add("Amount", "Amount");
                dgvSalaryStatus.Columns.Add("PaymentDate", "Payment Date");
                dgvSalaryStatus.Columns.Add("Status", "Status");

                foreach (var salary in salaries)
                {
                    dgvSalaryStatus.Rows.Add(
                        salary.getPaymentid(),
                        salary.getAmount().ToString("C"), // Currency formatting based on system locale
                        salary.getPaymentdate().ToString("yyyy-MM-dd"),
                        salary.getSalary_status()?.LookupValue ?? "Unknown" // ✅ NULL check
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading salary data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSalaryStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
