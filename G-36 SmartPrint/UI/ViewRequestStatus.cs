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
    public partial class ViewRequestStatus : UserControl
    {
        private List<requestsBL> requestList;
        public ViewRequestStatus()
        {
            InitializeComponent();
        txtDesignerName.Text = LoginHelpers.currentEmployee.UserName;
        LoadRequestData();
        }

        private void LoadRequestData()
        {
            int id = LoginHelpers.currentEmployee.EmployeeID;
            requestList = RequestsDL.LoadAllRequestsbyEmployeeID(id);
            dgvRequests.Rows.Clear();
            dgvRequests.Columns.Clear();

            dgvRequests.Columns.Add("RequestID", "Request ID");
            dgvRequests.Columns.Add("EmployeeName", "Employee Name");
            dgvRequests.Columns.Add("Position", "Position");
            dgvRequests.Columns.Add("ItemName", "Requested Item");
            dgvRequests.Columns.Add("Quantity", "Quantity");
            dgvRequests.Columns.Add("Status", "Approval Status");

            foreach (var req in requestList)
            {
                dgvRequests.Rows.Add(
                    req.reqquestid,
                    req.employees.UserName,
                    req.employees.Position.LookupValue,
                    req.requested_item.ItemName,
                    req.quantity,
                    req.approvalstatus.LookupValue
                );
            }
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
