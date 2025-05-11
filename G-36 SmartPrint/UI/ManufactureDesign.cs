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
                // Load orders with approved designs
                approvedOrders = OrderDL.LoadOrdersByStatus("Approved");
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
        }

        private void RefreshDataGridView()
        {
            dgvApprovedDesigns.DataSource = null;

            // Create a simplified list for display
            var displayList = new List<dynamic>();
            foreach (var order in approvedOrders)
            {
                displayList.Add(new
                {
                    OrderID = order.OrderID,
                    CustomerName = order.getCustomer().getUserName(),
                    OrderDate = order.getOrderDate().ToString("yyyy-MM-dd"),
                    DesignDescription = order.getDesignDescription()
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
                    pbDesignImage.Image = Properties.Resources.log_removebg_preview; // Default image
                    MessageBox.Show("Design file not found at specified path", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading design image: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbDesignImage.Image = Properties.Resources.log_removebg_preview; // Default image
            }
        }

        private void btnManufacture_Click(object sender, EventArgs e)
        {
            if (currentOrder == null || currentDesign == null)
            {
                MessageBox.Show("Please select a design to manufacture", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Update order status to "In Production"
                OrderDL.ChangeOrderStatusByName(currentOrder.OrderID, "In Pro");

                MessageBox.Show("Order marked as in production successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the list
                LoadApprovedDesigns();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating order status: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            if (currentOrder == null || currentDesign == null)
            {
                MessageBox.Show("Please select a design to mark as pending", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Update order status to "Pending"
                OrderDL.ChangeOrderStatusByName(currentOrder.OrderID, "Pending");

                MessageBox.Show("Order marked as pending successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the list
                LoadApprovedDesigns();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating order status: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvApprovedDesigns_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvApprovedDesigns.SelectedRows.Count > 0)
            {
                var selectedRow = dgvApprovedDesigns.SelectedRows[0];
                int orderId = Convert.ToInt32(selectedRow.Cells["colOrderId"].Value);

                // Find the order in our list
                currentOrder = approvedOrders.Find(o => o.OrderID == orderId);
                if (currentOrder != null && currentOrder.designs != null && currentOrder.designs.Count > 0)
                {
                    // Get the first approved design (you might want to handle multiple designs differently)
                    currentDesign = currentOrder.designs[0];

                    // Update UI with order/design details
                    txtOrderId.Text = currentOrder.OrderID.ToString();
                    txtDesignDescription.Text = currentOrder.getDesignDescription();
                    txtDesignerName.Text = currentDesign.designer?.getUserName() ?? "Unknown Designer";
                    txtCustomerName.Text = currentOrder.getCustomer().getUserName();
                    dtpCreatedDate.Value = currentDesign.createddate;

                    // Load design image
                    if (!string.IsNullOrEmpty(currentDesign.designFile))
                    {
                        LoadDesignImage(currentDesign.designFile);
                    }
                }
            }
        }

        private void dgvApprovedDesigns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any specific cell content clicks if needed
        }
    }
}