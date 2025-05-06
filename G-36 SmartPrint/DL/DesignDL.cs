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
        public static List<DesignBL> LoadDesignsByOrderId(int orderId)
        {
            List<DesignBL> designs = new List<DesignBL>();

            string query = $@"
                SELECT 
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

                designs.Add(design);
            }

            return designs;
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
