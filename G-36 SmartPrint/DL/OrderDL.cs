using System.Collections.Generic;
using System;
using System.Data;
using G_36_SmartPrint.BL;
using MySql.Data.MySqlClient;

namespace G_36_SmartPrint.DL
{
    internal class OrderDL
    {
        public static List<OrderBL> LoadAllOrders()
        {
            List<OrderBL> orders = new List<OrderBL>();

            string query = @"
                SELECT 
                    o.OrderID,
                    o.OrderDate,
                    o.DeliveryRequired,
                    o.TotalAmount,
                    
                    o.AddressID,
                    a.Address_Detail,
                    a.City,
                    a.State,
                    a.PostalCode,
                    a.Country,

                    o.CustomerID,
                    u.Username,
                    u.Email,
                    u.Name,
                    u.Phone_number,

                    s.LookupID AS OrderStatusID,
                    s.LookupValue AS OrderStatusValue,

                    od.OrderDetailID,
                    od.ProductID,
                    od.Quantity,
                    od.DesignDescription,

                    p.Name AS ProductName,
                    p.Description AS ProductDescription,
                    p.Price AS ProductPrice,
                    p.QuantityInStock

                FROM Orders o
                LEFT JOIN UserAddress a ON o.AddressID = a.AddressID
                INNER JOIN Users u ON o.CustomerID = u.UserID
                INNER JOIN LookupTable s ON o.order_StatusID = s.LookupID
                LEFT JOIN OrderDetails od ON o.OrderID = od.OrderID
                LEFT JOIN Products p ON od.ProductID = p.ProductID

                ORDER BY o.OrderID;";

            DataTable dt = SqlHelper.getDataTable(query);

            OrderBL currentOrder = null;
            int previousOrderId = -1;

            foreach (DataRow row in dt.Rows)
            {
                int orderId = Convert.ToInt32(row["OrderID"]);

                if (orderId != previousOrderId)
                {
                    CustomersBL customer = new CustomersBL(
                        Convert.ToInt32(row["CustomerID"]),
                        row["Username"].ToString(),
                        row["Email"].ToString(),
                        row["Name"].ToString(),
                        row["Phone_number"].ToString()
                    );

                    AddressBL address = null;
                    if (row["AddressID"] != DBNull.Value)
                    {
                        address = new AddressBL(
                            Convert.ToInt32(row["AddressID"]),
                            row["Address_Detail"].ToString(),
                            row["City"].ToString(),
                            row["State"].ToString(),
                            row["PostalCode"].ToString(),
                            row["Country"].ToString()
                        );
                    }

                    currentOrder = new OrderBL(
                        orderId,
                        Convert.ToDateTime(row["OrderDate"]),
                        Convert.ToBoolean(row["DeliveryRequired"]),
                        address,
                        Convert.ToDecimal(row["TotalAmount"]),
                        new List<Order_DetailsBL>(),
                        customer
                    );

                    LookupBL orderStatus = new LookupBL(
                        Convert.ToInt32(row["OrderStatusID"]),
                        row["OrderStatusValue"].ToString()
                    );
                    currentOrder.setOrderStatus(orderStatus);

                    orders.Add(currentOrder);
                    previousOrderId = orderId;
                }

                // Add OrderDetail if exists
                if (row["OrderDetailID"] != DBNull.Value)
                {
                    ProductBL product = new ProductBL(
                        Convert.ToInt32(row["ProductID"]),
                        row["ProductName"].ToString(),
                        row["ProductDescription"].ToString(),
                        Convert.ToDecimal(row["ProductPrice"]),
                        Convert.ToInt32(row["QuantityInStock"])
                    );

                    Order_DetailsBL orderDetail = new Order_DetailsBL(
                        Convert.ToInt32(row["OrderDetailID"]),
                        product,
                        Convert.ToInt32(row["Quantity"]),
                        null, // Status of order detail if needed
                        row["DesignDescription"].ToString()
                    );

                    currentOrder.getOrderDetails().Add(orderDetail);
                }
            }

            return orders;
        }

        public static List<OrderBL> LoadOrdersByCustomerId(int customerId)
        {
            List<OrderBL> orders = new List<OrderBL>();

            string query = $@"
                SELECT 
                    o.OrderID,
                    o.OrderDate,
                    o.DeliveryRequired,
                    o.TotalAmount,
                    
                    o.AddressID,
                    a.Address_Detail,
                    a.City,
                    a.State,
                    a.PostalCode,
                    a.Country,

                    o.CustomerID,
                    u.Username,
                    u.Email,
                    u.Name,
                    u.Phone_number,

                    s.LookupID AS OrderStatusID,
                    s.LookupValue AS OrderStatusValue,

                    od.OrderDetailID,
                    od.ProductID,
                    od.Quantity,
                    od.DesignDescription,

                    p.Name AS ProductName,
                    p.Description AS ProductDescription,
                    p.Price AS ProductPrice,
                    p.QuantityInStock

                FROM Orders o
                LEFT JOIN UserAddress a ON o.AddressID = a.AddressID
                INNER JOIN Users u ON o.CustomerID = u.UserID
                INNER JOIN LookupTable s ON o.order_StatusID = s.LookupID
                LEFT JOIN OrderDetails od ON o.OrderID = od.OrderID
                LEFT JOIN Products p ON od.ProductID = p.ProductID
                WHERE o.CustomerID = {customerId}
                ORDER BY o.OrderID;";

            DataTable dt = SqlHelper.getDataTable(query);

            OrderBL currentOrder = null;
            int previousOrderId = -1;

            foreach (DataRow row in dt.Rows)
            {
                int orderId = Convert.ToInt32(row["OrderID"]);

                if (orderId != previousOrderId)
                {
                    List<FeedbackBL> feedback = FeedbackDL.LoadFeedbackByOrderId(orderId);
                    CustomersBL customer = new CustomersBL(
                        Convert.ToInt32(row["CustomerID"]),
                        row["Username"].ToString(),
                        row["Email"].ToString(),
                        row["Name"].ToString(),
                        row["Phone_number"].ToString()
                    );

                    AddressBL address = null;
                    if (row["AddressID"] != DBNull.Value)
                    {
                        address = new AddressBL(
                            Convert.ToInt32(row["AddressID"]),
                            row["Address_Detail"].ToString(),
                            row["City"].ToString(),
                            row["State"].ToString(),
                            row["PostalCode"].ToString(),
                            row["Country"].ToString()
                        );
                    }

                    currentOrder = new OrderBL(
                        orderId,
                        Convert.ToDateTime(row["OrderDate"]),
                        Convert.ToBoolean(row["DeliveryRequired"]),
                        address,
                        Convert.ToDecimal(row["TotalAmount"]),
                        new List<Order_DetailsBL>(),
                        customer,
                        feedback
                    );

                    LookupBL orderStatus = new LookupBL(
                        Convert.ToInt32(row["OrderStatusID"]),
                        row["OrderStatusValue"].ToString()
                    );
                    currentOrder.setOrderStatus(orderStatus);

                    orders.Add(currentOrder);
                    previousOrderId = orderId;
                }

                if (row["OrderDetailID"] != DBNull.Value)
                {
                    ProductBL product = new ProductBL(
                        Convert.ToInt32(row["ProductID"]),
                        row["ProductName"].ToString(),
                        row["ProductDescription"].ToString(),
                        Convert.ToDecimal(row["ProductPrice"]),
                        Convert.ToInt32(row["QuantityInStock"])
                    );

                    Order_DetailsBL orderDetail = new Order_DetailsBL(
                        Convert.ToInt32(row["OrderDetailID"]),
                        product,
                        Convert.ToInt32(row["Quantity"]),
                        null,
                        row["DesignDescription"].ToString()
                    );

                    currentOrder.getOrderDetails().Add(orderDetail);
                }
            }

            return orders;
        }
    }
}
