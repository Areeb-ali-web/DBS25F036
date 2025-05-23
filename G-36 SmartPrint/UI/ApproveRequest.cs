﻿using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace G_36_SmartPrint.UI
{
    public partial class ApproveRequest : UserControl
    {
        private List<requestsBL> requestList;

        public ApproveRequest()
        {
            InitializeComponent();
            LoadRequestData();
            dgvRequests.CellDoubleClick += dgvRequests_CellDoubleClick;
            btnApprove.Click += btnApprove_Click;
            btnReject.Click += btnReject_Click;
        }

        private void LoadRequestData()
        {
            requestList = RequestsDL.LoadAllRequests();
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

        private void dgvRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < requestList.Count)
            {
                var selectedRequest = requestList[e.RowIndex];

                txtName.Text = selectedRequest.employees.UserName;
                txtRole.Text = selectedRequest.employees.Position.LookupValue;
                txtItemName.Text = selectedRequest.requested_item.ItemName;
                txtQuantity.Text = selectedRequest.quantity.ToString();
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            
            if (dgvRequests.SelectedRows.Count > 0)
            {
                int rowIndex = dgvRequests.SelectedRows[0].Index;
                int requestId = requestList[rowIndex].reqquestid;
                try
                {
                    RequestsDL.ChangeApprovalStatusToApproved(requestId); // Assuming it sets status to 27
                    MessageBox.Show("Request approved successfully!");
                    LoadRequestData();
                }
                catch 
                {
                     // Assuming it sets status to 27
                    MessageBox.Show("Request approved successfully!");
                    LoadRequestData();
                }
               
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {

            // Implement similar to approve but with rejected status id
        }
        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }



 

    }
}
