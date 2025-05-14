using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace G_36_SmartPrint.UI
{
    public partial class ManufactureDesign : UserControl
    {
        private List<OrderBL> approvedOrders;
        private OrderBL currentOrder;
        private DesignBL currentDesign;

        public ManufactureDesign()
        {
            InitializeComponent();
            InitializeForm();
            dgvApprovedDesigns.CellDoubleClick += DgvApprovedDesigns_CellDoubleClick;
            btnManufacture.Click += BtnManufacture_Click;
            btnPending.Click += BtnPending_Click;
        }

        private void InitializeForm()
        {
            LoadApprovedDesigns();
            ConfigureDataGridView();
            ClearFields();
        }

        private void LoadApprovedDesigns()
        {
            
            try
            {
                approvedOrders = OrderDL.LoadOrdersByStatus("pending");
                //approvedOrders = approvedOrders.FindAll(o => o.OrderStatus.LookupValue == "Approved");
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading approved designs: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            dgvApprovedDesigns.AutoGenerateColumns = false;
            dgvApprovedDesigns.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApprovedDesigns.AllowUserToAddRows = false;
            dgvApprovedDesigns.ReadOnly = true;

            // Clear existing columns
            dgvApprovedDesigns.Columns.Clear();

            // Add columns
            dgvApprovedDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colOrderId",
                HeaderText = "Order ID",
                DataPropertyName = "OrderID",
                Width = 100
            });

            dgvApprovedDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colCustomer",
                HeaderText = "Customer",
                DataPropertyName = "CustomerName",
                Width = 150
            });

            dgvApprovedDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colOrderDate",
                HeaderText = "Order Date",
                DataPropertyName = "OrderDate",
                Width = 120
            });

            dgvApprovedDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDescription",
                HeaderText = "Description",
                DataPropertyName = "DesignDescription",
                Width = 200
            });

            dgvApprovedDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colStatus",
                HeaderText = "Status",
                DataPropertyName = "OrderStatus",
                Width = 120
            });
            dgvApprovedDesigns.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDesignFile",
                HeaderText = "DesignFile",
                DataPropertyName = "DesignFile",
                Width = 120
            });
        }

        private void RefreshDataGridView()
        {
            dgvApprovedDesigns.DataSource = null;

            var displayList = new List<dynamic>();
            foreach (var order in approvedOrders)
            {
                displayList.Add(new
                {
                    OrderID = order.OrderID,
                    CustomerName = order.Customer.UserName,
                    OrderDate = order.OrderDate.ToString("yyyy-MM-dd"),
                    DesignDescription = order.DesignDescription,
                    OrderStatus = order.OrderStatus.LookupValue
                });
            }

            dgvApprovedDesigns.DataSource = displayList;
        }

        private void ClearFields()
        {
            txtOrderId.Text = "";
            txtDesignDescription.Text = "";
            txtDesignerName.Text = "";
            txtCustomerName.Text = "";
            dtpCreatedDate.Value = DateTime.Now;
            pbDesignImage.Image = null;
            currentOrder = null;
            currentDesign = null;
        }

        private void LoadDesignImage(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    pbDesignImage.Image = Image.FromFile(filePath);
                }
                else
                {
                    pbDesignImage.Image = Properties.Resources.log_removebg_preview;
                    MessageBox.Show("Design file not found at specified path", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading design image: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbDesignImage.Image = Properties.Resources.log_removebg_preview;
            }
        }

        private void DgvApprovedDesigns_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not a header row
            {
                var selectedRow = dgvApprovedDesigns.Rows[e.RowIndex];
                int orderId = Convert.ToInt32(selectedRow.Cells["colOrderId"].Value);
               
                LoadOrderDetails(orderId);
                OrderBL order = OrderDL.LoadOrderByOrderId(orderId);
                txtCustomerName.Text = order.Customer.UserName;
                txtDesignDescription.Text = order.DesignDescription;
                txtOrderId.Text =orderId.ToString();
               


                
            }
        }

        private void LoadOrderDetails(int orderId)
        {
            currentOrder = approvedOrders.Find(o => o.OrderID == orderId);
            if (currentOrder != null && currentOrder.Designs != null && currentOrder.Designs.Count > 0)
            {
                currentDesign = currentOrder.Designs[0];

                txtOrderId.Text = currentOrder.OrderID.ToString();
                txtDesignDescription.Text = currentOrder.DesignDescription;
                txtDesignerName.Text = currentDesign.Designer?.UserName ?? "Unknown Designer";
                txtCustomerName.Text = currentOrder.Customer.UserName;
                dtpCreatedDate.Value = currentDesign.CreatedDate;

                if (!string.IsNullOrEmpty(currentDesign.DesignFile))
                {
                    LoadDesignImage(currentDesign.DesignFile);
                }
            }
        }

        private void BtnManufacture_Click(object sender, EventArgs e)
        {
            if (currentOrder == null)
            {
                MessageBox.Show("Please select a design first by double-clicking on it", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                OrderDL.ChangeOrderStatusByName(currentOrder.OrderID, "manufactured");
                currentOrder.OrderStatus.SetLookupValue("manufactured");

                MessageBox.Show("Order status changed to manufactured'", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshDataGridView();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating order status: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPending_Click(object sender, EventArgs e)
        {
            if (currentOrder == null)
            {
                MessageBox.Show("Please select a design first by double-clicking on it", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                OrderDL.ChangeOrderStatusByName(currentOrder.OrderID, "Pending");
                currentOrder.OrderStatus.SetLookupValue("Pending");

                MessageBox.Show("Order status changed to 'Pending'", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshDataGridView();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating order status: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Implement your submit logic here
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Implement your update logic here
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvApprovedDesigns_SelectionChanged(object sender, EventArgs e)
        {
            // Optional: You can keep this if you want selection change to also load details
            // But it might be better to rely only on double-click to avoid confusion
        }

        private void pbDesignImage_Click(object sender, EventArgs e)
        {

        }

        private void btnManufacture_Click_1(object sender, EventArgs e)
        {

        }
    }
}