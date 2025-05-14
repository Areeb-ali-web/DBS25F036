using System.Collections.Generic;
using System;
using System.Data;
using G_36_SmartPrint.BL;
using MySqlConnector;
using G_36_SmartPrint.UI;

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
            o.DesignDescription,

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
                    currentOrder.OrderStatus=(orderStatus);

                    // Load and set associated designs
                    List<DesignBL> designs = DesignDL.LoadDesignsByOrderId(orderId);
                    currentOrder.Designs=(designs);

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
                        null
                    );

                    currentOrder.OrderDetails.Add(orderDetail);
                }
            }

            return orders;
        }

        public static List<OrderBL> LoadOrdersByStatus(string statusName)
        {
            List<OrderBL> orders = new List<OrderBL>();

            // Step 1: Get LookupID for the given status name
            string lookupQuery = $"SELECT LookupID FROM LookupTable WHERE LookupValue = '{statusName}' AND lookupType = 'Order_Status'";
            DataTable statusResult = SqlHelper.getDataTable(lookupQuery);

            if (statusResult.Rows.Count == 0)
                throw new Exception("Invalid order status name.");

            int statusId = Convert.ToInt32(statusResult.Rows[0]["LookupID"]);

            // Step 2: Load orders with the given status
            string query = $@"
        SELECT 
            o.OrderID,
            o.OrderDate,
            o.DeliveryRequired,
            o.TotalAmount,
            o.DesignDescription,

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
        WHERE o.order_StatusID = {statusId}
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

                    LookupBL orderStatus = new LookupBL(
                        Convert.ToInt32(row["OrderStatusID"]),
                        row["OrderStatusValue"].ToString()
                    );

                    List<FeedbackBL> feedback = FeedbackDL.LoadFeedbackByOrderId(orderId);

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
                    currentOrder.DesignDescription=(row["DesignDescription"].ToString());
                    currentOrder.OrderStatus=(orderStatus);

                    List<DesignBL> designs = DesignDL.LoadDesignsByOrderId(orderId);
                    currentOrder.Designs=(designs);

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
                        null
                    );

                    currentOrder.OrderDetails.Add(orderDetail);
                }
            }

            return orders;
        }
        public static List<OrderBL> LoadOrdersByDesignerId(int designerId)
        {
            List<OrderBL> orders = new List<OrderBL>();

            string query = $@"
        SELECT 
            o.OrderID,
            o.OrderDate,
            o.DeliveryRequired,
            o.TotalAmount,
            o.DesignDescription,

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
        INNER JOIN Designs d ON o.OrderID = d.OrderID
        WHERE d.DesignerID = {designerId}
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

                    LookupBL orderStatus = new LookupBL(
                        Convert.ToInt32(row["OrderStatusID"]),
                        row["OrderStatusValue"].ToString()
                    );

                    List<FeedbackBL> feedback = FeedbackDL.LoadFeedbackByOrderId(orderId);

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

                    currentOrder.DesignDescription=(row["DesignDescription"].ToString());
                    currentOrder.OrderStatus= (orderStatus);

                    // Load only designs made by the specified designer for this order
                    List<DesignBL> designs = DesignDL.LoadDesignsByOrderId(orderId)
                        .FindAll(d => d.Designer != null && d.Designer.EmployeeID == designerId);

                    currentOrder.Designs = (designs);

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
                        null
                    );

                    currentOrder.OrderDetails.Add(orderDetail);
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
            o.DesignDescription,

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
                    currentOrder.OrderStatus = (orderStatus);

                    // Load and set associated designs
                    List<DesignBL> designs = DesignDL.LoadDesignsByOrderId(orderId);
                    currentOrder.Designs = (designs);

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
                        null
                    );

                    currentOrder.OrderDetails.Add(orderDetail);
                }
            }

            return orders;
        }

        public static List<OrderBL> LoadOrdersForApprovalByCustomerId(int customerId)
        {
            string query = $" SELECT o.OrderID,o.CustomerID,u.Name AS CustomerName,o.OrderDate, o.TotalAmount,o.DesignDescription,d.DesignID,d.DesignFile, d.CreatedDate AS DesignCreatedDate, lt.LookupID,lt.LookupValue AS ApprovalStatus FROM  orders o JOIN  users u ON o.CustomerID = u.UserID JOIN designs d ON o.OrderID = d.OrderID JOIN lookuptable lt ON d.ApprovalStatusID = lt.LookupID WHERE d.ApprovalStatusID = 26 AND o.CustomerID = {customerId}";



            DataTable dt = SqlHelper.getDataTable(query);

            List<OrderBL> orders = new List<OrderBL>();

            foreach (DataRow row in dt.Rows)
            {
                UserBL customer = new UserBL(
                    Convert.ToInt32(row["CustomerID"]),
                    row["CustomerName"].ToString()
                );

                LookupBL approvalStatus = new LookupBL(
                    Convert.ToInt32(row["LookupID"]),
                    row["ApprovalStatus"].ToString()
                );

                DesignerBL dummyDesigner = new DesignerBL(); // Replace with real logic if needed

                DesignBL design = new DesignBL(
                    row["DesignFile"].ToString(),
                    dummyDesigner,
                    Convert.ToDateTime(row["DesignCreatedDate"]),
                    approvalStatus
                );

                List<DesignBL> designs = new List<DesignBL> { design };
                CustomersBL customersBL = new CustomersBL(customer);
                OrderBL order = new OrderBL(
                    Convert.ToInt32(row["OrderID"]),
                    customersBL,
                    Convert.ToDateTime(row["OrderDate"]),
                    Convert.ToDecimal(row["TotalAmount"]),
                    row["DesignDescription"].ToString(),
                    designs
                );

                orders.Add(order);
            }

            return orders;
        }
        public static DataTable getproductsforApproval(int customerId)
        {
            string query = $"SELECTo.OrderID,o.OrderDate,o.TotalAmount,o.DesignDescription,d.DesignFile, lt.LookupValue AS ApprovalStatus  FROM orders o JOIN users u ON o.CustomerID = u.UserID JOIN designs d ON o.OrderID = d.OrderID JOIN lookuptable lt ON d.ApprovalStatusID = lt.LookupID WHERE d.ApprovalStatusID = 26 = {customerId} ";


            DataTable dt = SqlHelper.getDataTable(query);
            return dt;
        }
        public static void  ChangeOrderStatusByName(int orderId, string newStatusName)
        {
            // Step 1: Get LookupID from LookupTable using status name
            string lookupQuery = $"SELECT LookupID FROM LookupTable WHERE LookupValue = '{newStatusName}' AND lookupType = 'Order_Status'";
            DataTable result = SqlHelper.getDataTable(lookupQuery);

            if (result.Rows.Count == 0)
            {
                throw new Exception("Invalid order status name provided.");
            }

            int newStatusId = Convert.ToInt32(result.Rows[0]["LookupID"]);

            // Step 2: Update Orders table
            string updateQuery = $"UPDATE Orders SET order_StatusID = {newStatusId} WHERE OrderID = {orderId}";
            SqlHelper.executeDML(updateQuery);
        }
        public static OrderBL LoadOrderByOrderId(int orderId)
        {
            string query = $@"
        SELECT 
            o.OrderID,
            o.OrderDate,
            o.DeliveryRequired,
            o.TotalAmount,
            o.DesignDescription,

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
        WHERE o.OrderID = {orderId};";

            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count == 0)
                return null;

            OrderBL order = null;
            foreach (DataRow row in dt.Rows)
            {
                if (order == null)
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

                    LookupBL orderStatus = new LookupBL(
                        Convert.ToInt32(row["OrderStatusID"]),
                        row["OrderStatusValue"].ToString()
                    );

                    List<FeedbackBL> feedback = FeedbackDL.LoadFeedbackByOrderId(orderId);
                    List<Order_DetailsBL> details = new List<Order_DetailsBL>();

                    order = new OrderBL(
                        orderId,
                        Convert.ToDateTime(row["OrderDate"]),
                        Convert.ToBoolean(row["DeliveryRequired"]),
                        address,
                        Convert.ToDecimal(row["TotalAmount"]),
                        details,
                        customer,
                        feedback
                    );
                    order.DesignDescription = (row["DesignDescription"].ToString());
                    order.OrderStatus = (orderStatus);

                    List<DesignBL> designs = DesignDL.LoadDesignsByOrderId(orderId);
                    order.Designs = (designs);
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
                        null
                    );

                    order.OrderDetails.Add(orderDetail);
                }
            }

            return order;
        }

        public static void AddOrder(OrderBL order)
        {
            using (MySqlConnection con = new MySqlConnection(SqlHelper.constring))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();

       
                    // 1. Insert into Orders table
                    string insertOrderQuery = @"
                INSERT INTO Orders 
                (CustomerID, DeliveryRequired, AddressID, TotalAmount, order_StatusID, designdescription)
                VALUES 
                (@CustomerID, @DeliveryRequired, @AddressID, @TotalAmount, @OrderStatusID, @DesignDescription);
                SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(insertOrderQuery, con, transaction);
                    cmd.Parameters.AddWithValue("@CustomerID", LoginHelpers.currentcustomer.UserID);
                    cmd.Parameters.AddWithValue("@DeliveryRequired", 1); // assuming always true
                    cmd.Parameters.AddWithValue("@AddressID", order.DeliveryAddress.AddressID);
                    cmd.Parameters.AddWithValue("@TotalAmount", 0000); // Use actual amount
                    cmd.Parameters.AddWithValue("@OrderStatusID", 7); // default status
                    cmd.Parameters.AddWithValue("@DesignDescription", order.DesignDescription);

                    int orderId = Convert.ToInt32(cmd.ExecuteScalar());
                    order.OrderID=(orderId);

                    // 2. Insert each order detail
                    foreach (Order_DetailsBL detail in order.OrderDetails)
                    {
                        string insertDetailQuery = @"
                    INSERT INTO OrderDetails (OrderID, ProductID, Quantity)
                    VALUES (@OrderID, @ProductID, @Quantity);";

                        MySqlCommand detailCmd = new MySqlCommand(insertDetailQuery, con, transaction);
                        detailCmd.Parameters.AddWithValue("@OrderID", orderId);
                        detailCmd.Parameters.AddWithValue("@ProductID", detail.Product.ProductID);
                        detailCmd.Parameters.AddWithValue("@Quantity", detail.Quantity);

                        detailCmd.ExecuteNonQuery();
                    }

                    // 3. Commit the transaction
                    transaction.Commit();
                //}
                //catch (Exception ex)
                //{
                //    // 4. Rollback if anything fails
                //    transaction.Rollback();
                //    throw new Exception("Failed to insert order: " + ex.Message);
                //}
            }
        }


    }
}
