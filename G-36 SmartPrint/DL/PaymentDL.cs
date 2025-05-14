using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_36_SmartPrint.BL;

namespace G_36_SmartPrint.DL
{
    internal class PaymentDL
    {
        public static List<Order_PaymentBL> LoadAllPayments()
        {
            List<Order_PaymentBL> payments = new List<Order_PaymentBL>();

            string query = @"
                SELECT 
                    p.PaymentID,
                    p.OrderID,
                    p.Amount,
                    p.PaymentMethod,
                    p.PaymentDate,
                    l.LookupID,
                    l.LookupValue AS PaymentStatus
                FROM Payment p
                INNER JOIN LookupTable l ON p.Payment_StatusID = l.LookupID
                WHERE l.Lookuptype = 'PaymentStatus';";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int orderId = Convert.ToInt32(row["OrderID"]);
                LookupBL paymentStatus = new LookupBL(
                    Convert.ToInt32(row["LookupID"]),
                    row["PaymentStatus"].ToString()
                );

                OrderBL order = new OrderBL();
                order.OrderID=(orderId);

                Order_PaymentBL payment = new Order_PaymentBL(
                    Convert.ToInt32(row["PaymentID"]),
                    Convert.ToDecimal(row["Amount"]),
                    row["PaymentMethod"].ToString(),
                    Convert.ToDateTime(row["PaymentDate"]),
                    paymentStatus,
                    order
                );

                payments.Add(payment);
            }

            return payments;
        }
        public static bool AddPayment(Order_PaymentBL payment)
        {
            // Get LookupID for 'Paid' status
            string lookupQuery = "SELECT LookupID FROM LookupTable WHERE LookupValue = 'Paid';";
            DataTable lookupDt = SqlHelper.getDataTable(lookupQuery);

            if (lookupDt.Rows.Count == 0)
                return false; // 'Paid' status not found

            int paidStatusId = Convert.ToInt32(lookupDt.Rows[0]["LookupID"]);

            string insertQuery = $@"
                INSERT INTO Payment (OrderID, Amount, PaymentMethod, PaymentDate, Payment_StatusID)
                VALUES (
                    {payment.getOrder().OrderID},
                    {payment.getAmount()},
                    '{payment.getPaymentMethod()}',
                    '{payment.getPayment_date().ToString("yyyy-MM-dd HH:mm:ss")}',
                    {paidStatusId}
                );";
            SqlHelper.executeDML(insertQuery);
            return true;
        }
    }
}
