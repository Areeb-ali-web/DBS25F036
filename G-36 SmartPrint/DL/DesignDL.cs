using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_36_SmartPrint.BL;
using MySqlConnector;


namespace G_36_SmartPrint.DL
{
    internal class DesignDL
    {

        public static bool UpdateDesignFile(int orderId, int designId, string newDesignFile)
        {
            string query = @"
        UPDATE designs 
        SET DesignFile = @DesignFile 
        WHERE OrderID = @OrderID AND DesignID = @DesignID;
    ";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@DesignFile", newDesignFile),
        new MySqlParameter("@OrderID", orderId),
        new MySqlParameter("@DesignID", designId)
            };

            using (MySqlConnection con = new MySqlConnection(SqlHelper.constring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddRange(parameters);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public static List<DesignBL> LoadDesignsByOrderId(int orderId)
        {
            List<DesignBL> designs = new List<DesignBL>();

            string query = $@"
                SELECT
                    d.designid,
                    d.DesignFile,
                    d.CreatedDate,
                    d.OrderID,
                    l.LookupID AS ApprovalStatusID,
                    l.LookupValue AS ApprovalStatusValue,
                    
                    des.UserID AS DesignerID,
                    des.Username AS DesignerUsername,
                    des.Email AS DesignerEmail,
                    des.Name AS DesignerName,
                    des.Phone_number AS DesignerPhone

                FROM Designs d
                INNER JOIN Users des ON d.DesignerID = des.UserID
                INNER JOIN LookupTable l ON d.ApprovalStatusid = l.LookupID
                WHERE d.OrderID = {orderId};";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                DesignerBL designer = new DesignerBL(
                    Convert.ToInt32(row["DesignerID"]),
                    row["DesignerUsername"].ToString()

                );

                LookupBL approvalStatus = new LookupBL(
                    Convert.ToInt32(row["ApprovalStatusID"]),
                    row["ApprovalStatusValue"].ToString()
                );

                DesignBL design = new DesignBL(
                    row["DesignFile"].ToString(),
                    designer,
                    Convert.ToDateTime(row["CreatedDate"]),
                    approvalStatus,
                    Convert.ToInt32(row["OrderID"])
                );
                design.DesignID = Convert.ToInt32(row["DesignID"]);

                designs.Add(design);
            }

            return designs;
        }
        public static void DeleteDesign(int id)
        {
            string query = $"delete from design where designid ={id}";
            SqlHelper.executeDML(query);
        }
        public static List<DesignBL> LoadDesignsByDesignerID(int designerID)
        {
            List<DesignBL> designs = new List<DesignBL>();

            string query = @"
                SELECT 
                    d.DesignID,
                    o.DesignDescription,
                    lt.LookupValue AS DesignStatus,
                    d.CreatedDate,
                    u.Name AS DesignerName,
                    d.DesignFile,
                    d.OrderID,
                    lt.LookupID
                FROM 
                    designs d
                JOIN 
                    orders o ON d.OrderID = o.OrderID
                JOIN 
                    lookuptable lt ON d.ApprovalStatusID = lt.LookupID
                JOIN 
                    users u ON (SELECT UserID FROM employee WHERE EmployeeID = d.DesignerID) = u.UserID
                WHERE 
                    d.DesignerID = @DesignerID
                ORDER BY 
                    d.CreatedDate DESC;
            ";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@DesignerID", designerID)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                string file = row["DesignFile"].ToString();
                string designerName = row["DesignerName"].ToString();
                DateTime created = Convert.ToDateTime(row["CreatedDate"]);
                string statusValue = row["DesignStatus"].ToString();
                int statusID = Convert.ToInt32(row["LookupID"]);

                DesignerBL designer = new DesignerBL(designerID, designerName);
                LookupBL status = new LookupBL(statusID, statusValue);

                DesignBL design = new DesignBL(file, designer, created, status, Convert.ToInt32(row["OrderID"]));
                design.DesignID = Convert.ToInt32(row["DesignID"]);
                int OrderID = Convert.ToInt32(row["OrderID"]);
                OrderBL order = OrderDL.LoadOrderByOrderId(OrderID);
                design.Order = order;

                designs.Add(design);
            }

            return designs;
        }
        public static void InsertDesign(int orderId, int designerId)
        {
            string query = @"
        INSERT INTO designs (DesignFile, CreatedDate, OrderID, ApprovalStatusID, DesignerID)
        VALUES (@DesignFile, @CreatedDate, @OrderID, @ApprovalStatusID, @DesignerID);
    ";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@DesignFile", ""), // initially empty
        new MySqlParameter("@CreatedDate", DateTime.Now),
        new MySqlParameter("@OrderID", orderId),
        new MySqlParameter("@ApprovalStatusID", 26), // default status ID
        new MySqlParameter("@DesignerID", designerId)
            };

            SqlHelper.executeDML(query, parameters);
        }
        public static void UpdateDesignApprovalStatusByOrderId(int orderId, int newApprovalStatusId)
        {
            string query = "UPDATE design SET approvalstatus = @status WHERE orderid = @orderId";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@status", newApprovalStatusId),
                new MySqlParameter("@orderId", orderId)
            };

            SqlHelper.executeDML(query, parameters);
        }

    }
}
