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
    internal class EmployeeDL
    {
        public static List<EmployeesBL> LoadAllEmployees()
        {
            List<EmployeesBL> employees = new List<EmployeesBL>();

            string query = @"
                SELECT 
                    e.employeeID, e.positionID, e.hireDate, e.salary,
                    u.userID, u.username, u.passwordHash, u.email, u.name, u.phone_number, u.creationDate, u.roleID,
                    pos.lookupvalue AS positionName
                FROM 
                    Employee e
                INNER JOIN Users u ON e.userID = u.userID
                INNER JOIN Lookuptable pos ON e.positionID = pos.lookupID";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int employeeID = Convert.ToInt32(row["employeeID"]);
                int userID = Convert.ToInt32(row["userID"]);
                string username = row["username"].ToString();
                string passwordHash = row["passwordHash"].ToString();
                string email = row["email"].ToString();
                string name = row["name"].ToString();
                string phoneNumber = row["phone_number"].ToString();
                DateTime creationDate = Convert.ToDateTime(row["creationDate"]);
                DateTime hireDate = Convert.ToDateTime(row["hireDate"]);
                float salary = Convert.ToSingle(row["salary"]);

                int positionID = Convert.ToInt32(row["positionID"]);
                string positionName = row["positionName"].ToString();
                LookupBL position = new LookupBL(positionID, positionName);

                int roleID = Convert.ToInt32(row["roleID"]);
                LookupBL role = new LookupBL(roleID); // You can also fetch role name if needed

                EmployeesBL emp = new EmployeesBL(employeeID, position, hireDate, salary,
                                                  username, passwordHash, email, name, phoneNumber, creationDate, role);

                emp.setuserID(userID); // If needed to set userID manually
                employees.Add(emp);
            }

            return employees;
        }

        public static List<EmployeesBL> LoadEmployeesByPosition(int positionID)
        {
            List<EmployeesBL> employees = new List<EmployeesBL>();

            string query = @"
                SELECT 
                    e.employeeID, e.positionID, e.hireDate, e.salary,
                    u.userID, u.username, u.passwordHash, u.email, u.name, u.phone_number, u.creationDate, u.roleID,
                    pos.lookupvalue AS positionName
                FROM 
                    Employee e
                INNER JOIN Users u ON e.userID = u.userID
                INNER JOIN Lookuptable pos ON e.positionID = pos.lookupID
                WHERE e.positionID = @positionID";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@positionID", positionID)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);  // ✅ Using your SqlHelper

            foreach (DataRow row in dt.Rows)
            {
                int employeeID = Convert.ToInt32(row["employeeID"]);
                int userID = Convert.ToInt32(row["userID"]);
                string username = row["username"].ToString();
                string passwordHash = row["passwordHash"].ToString();
                string email = row["email"].ToString();
                string name = row["name"].ToString();
                string phoneNumber = row["phone_number"].ToString();
                DateTime creationDate = Convert.ToDateTime(row["creationDate"]);
                DateTime hireDate = Convert.ToDateTime(row["hireDate"]);
                float salary = Convert.ToSingle(row["salary"]);

                string positionName = row["positionName"].ToString();
                LookupBL position = new LookupBL(positionID, positionName);

                int roleID = Convert.ToInt32(row["roleID"]);
                LookupBL role = new LookupBL(roleID);

                EmployeesBL emp = new EmployeesBL(employeeID, position, hireDate, salary,
                                                  username, passwordHash, email, name, phoneNumber, creationDate, role);
                emp.setuserID(userID);
                employees.Add(emp);
            }

            return employees;
        }
        public static int? GetEmployeeIDByUserID(int userID)
        {
            string query = @"SELECT employee.employeeID 
                             FROM Employee 
                             JOIN Users ON Users.userID = Employee.userID 
                             WHERE Employee.userID = @userID 
                             LIMIT 1";  // Ensures only one row is returned

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@userID", userID)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);

            if (dt.Rows.Count == 1)
            {
                return Convert.ToInt32(dt.Rows[0]["employeeID"]);
            }
            return null; // Employee not found
        }
        public static LookupBL GetPositionByEmployeeID(int employeeID)
        {
            string query = @"
                SELECT l.lookupID, l.lookupvalue
                FROM Employee e
                INNER JOIN Lookuptable l ON e.positionID = l.lookupID
                WHERE e.employeeID = @employeeID
                LIMIT 1"; // Ensures one row

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@employeeID", employeeID)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);

            if (dt.Rows.Count == 1)
            {
                int positionID = Convert.ToInt32(dt.Rows[0]["lookupID"]);
                string positionName = dt.Rows[0]["lookupvalue"].ToString();

                return new LookupBL(positionID, positionName);
            }

            return null; // Position not found
        }

        public static void ChangeEmployeePosition(int employeeID, string newPositionName)
        {
            string query = @"
        UPDATE Employee 
        SET positionID = (
            SELECT lookupID 
            FROM Lookuptable 
            WHERE lookupvalue = @positionName AND lookuptype = 'position'
        )
        WHERE employeeID = @employeeID";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@positionName", newPositionName),
        new MySqlParameter("@employeeID", employeeID)
            };

            SqlHelper.executeDML(query, parameters);
        }
        public static void ChangeEmployeeSalary(int employeeID, float newSalary)
        {
            string query = @"
        UPDATE Employee
        SET salary = @newSalary
        WHERE employeeID = @employeeID";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@newSalary", newSalary),
        new MySqlParameter("@employeeID", employeeID)
            };

            SqlHelper.executeDML(query, parameters);
        }
    }
}
