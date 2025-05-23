﻿using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace G_36_SmartPrint.UI
{
    public partial class DeliveryViewAssignOrders : UserControl
    {
        private List<OrderBL> assignedOrders;

        public DeliveryViewAssignOrders()
        {
            InitializeComponent();
            LoadAssignedOrders();
        }

        private void LoadAssignedOrders()
        {
            try
            {
                assignedOrders = OrderDL.LoadOrdersByStatus("manufactured");

                dgvAssignedOrders.Rows.Clear();
                dgvAssignedOrders.Columns.Clear();

                dgvAssignedOrders.Columns.Add("OrderID", "Order ID");
                dgvAssignedOrders.Columns.Add("DeliveryAddress", "Delivery Address");

                foreach (var order in assignedOrders)
                {
                    string addressText = "N/A";

                    if (order.DeliveryAddress != null)
                    {
                        var addr = order.DeliveryAddress;
                        addressText = $"{addr.AddressDetail}, {addr.City}, {addr.State}, {addr.PostalCode}, {addr.Country}";
                    }

                    dgvAssignedOrders.Rows.Add(order.OrderID, addressText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assigned orders: " + ex.Message);
            }
        }

        private void dgvAssignedOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks here if needed
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional: styling or graphics
        }
    }
}
