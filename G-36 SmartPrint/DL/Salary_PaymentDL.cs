using System;
using System.Collections.Generic;
using System.Data;
using G_36_SmartPrint.BL;
using MySqlConnector;

namespace G_36_SmartPrint.DL
{
    internal class Salary_PaymentDL
    {
        public static void PaySalary(int employeeId)
        {
            string updateQuery = @"
                UPDATE salarypayment 
                SET Salary_StatusID = 24, 
                    PaymentDate = @PaymentDate 
                WHERE EmployeeID = @EmployeeID AND Salary_StatusID = 25";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@PaymentDate", DateTime.Now),
                new MySqlParameter("@EmployeeID", employeeId)
            };

            SqlHelper.executeDML(updateQuery, parameters);
        }

        public static List<SalaryPaymentBL> LoadAllSalaryPayments()
        {
            List<SalaryPaymentBL> salaries = new List<SalaryPaymentBL>();

            string query = @"
                SELECT 
     sp.PaymentID,
     sp.employeeid,
     sp.Amount,
     sp.PaymentDate,
     l.LookupID AS SalaryStatusID,
     l.LookupValue AS SalaryStatusValue
 FROM salarypayment sp
 INNER JOIN Lookuptable l ON sp.Salary_StatusID = l.LookupID
 WHERE sp.Salary_StatusID = 25";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                LookupBL status = new LookupBL(
                    Convert.ToInt32(row["SalaryStatusID"]),
                    row["SalaryStatusValue"].ToString()
                );

                SalaryPaymentBL salary = new SalaryPaymentBL(
                    Convert.ToInt32(row["PaymentID"]),
                    Convert.ToDecimal(row["Amount"]),
                    Convert.ToDateTime(row["PaymentDate"]),
                    status
                );
                salary.employee = EmployeeDL.LoadEmployeeById(Convert.ToInt32(row["employeeid"]));

                salaries.Add(salary);
            }

            return salaries;
        }
        public static List<SalaryPaymentBL> LoadSalariesByEmployeeId(int employeeId)
        {
            List<SalaryPaymentBL> salaries = new List<SalaryPaymentBL>();

            string query = @"
        SELECT 
            sp.PaymentID,
            sp.Amount,
            sp.PaymentDate,
            l.LookupID AS SalaryStatusID,
            l.LookupValue AS SalaryStatusValue
        FROM salarypayment sp
        INNER JOIN Lookuptable l ON sp.Salary_StatusID = l.LookupID
        WHERE  sp.EmployeeID = @EmployeeID";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@EmployeeID", employeeId)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                LookupBL status = new LookupBL(
                    Convert.ToInt32(row["SalaryStatusID"]),
                    row["SalaryStatusValue"].ToString()
                );

                SalaryPaymentBL salary = new SalaryPaymentBL(
                    Convert.ToInt32(row["PaymentID"]),
                    Convert.ToDecimal(row["Amount"]),
                    Convert.ToDateTime(row["PaymentDate"]),
                    status
                );

                salaries.Add(salary);
            }

            return salaries;
        }
        public static void PayAllSalaries()
        {
            string updateQuery = @"
                UPDATE salarypayment 
                SET Salary_StatusID = 24, 
                    PaymentDate = @PaymentDate 
                WHERE Salary_StatusID = 25";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@PaymentDate", DateTime.Now)
            };

            SqlHelper.executeDML(updateQuery, parameters);
        }
    }
}
