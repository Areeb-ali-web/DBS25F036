using System;
using System.Collections.Generic;
using System.Data;
using G_36_SmartPrint.BL;
using MySqlConnector;

namespace G_36_SmartPrint.DL
{
    internal class InstructionDL
    {
        public static List<Instructions> LoadAllInstructions()
        {
            List<Instructions> instructionList = new List<Instructions>();
            string query = "SELECT * FROM instructions";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int instructionId = Convert.ToInt32(row["InstructionID"]);
                int adminId = Convert.ToInt32(row["AdminID"]);
                int employeeId = Convert.ToInt32(row["EmployeeID"]);
                string instructionText = row["InstructionText"].ToString();
                DateTime sentDate = Convert.ToDateTime(row["SentDate"]);

                UserBL admin = UserDL.LoadUserById(adminId);
                EmployeesBL employee = EmployeeDL.LoadEmployeeById(employeeId);

                Instructions instruction = new Instructions(instructionId, admin, employee, instructionText, sentDate);
                instructionList.Add(instruction);
            }

            return instructionList;
        }
        public static List<Instructions> LoadInstructionsByEmployeeId(int employeeId)
        {
            List<Instructions> instructionList = new List<Instructions>();
            string query = "SELECT * FROM instructions WHERE EmployeeID = @employeeId";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@employeeId", employeeId)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                int instructionId = Convert.ToInt32(row["InstructionID"]);
                int adminId = Convert.ToInt32(row["AdminID"]);
                string instructionText = row["InstructionText"].ToString();
                DateTime sentDate = Convert.ToDateTime(row["SentDate"]);

                UserBL admin = UserDL.LoadUserById(adminId);
                EmployeesBL employee = EmployeeDL.LoadEmployeeById(employeeId);

                Instructions instruction = new Instructions(instructionId, admin, employee, instructionText, sentDate);
                instructionList.Add(instruction);
            }

            return instructionList;
        }
        public static List<Instructions> LoadInstructionsByAdminId(int adminId)
        {
            List<Instructions> instructionList = new List<Instructions>();
            string query = "SELECT * FROM instructions WHERE AdminID = @adminId";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@adminId", adminId)
            };

            DataTable dt = SqlHelper.getDataTable(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                int instructionId = Convert.ToInt32(row["InstructionID"]);
                int employeeId = Convert.ToInt32(row["EmployeeID"]);
                string instructionText = row["InstructionText"].ToString();
                DateTime sentDate = Convert.ToDateTime(row["SentDate"]);

                UserBL admin = UserDL.LoadUserById(adminId);
                EmployeesBL employee = EmployeeDL.LoadEmployeeById(employeeId);

                Instructions instruction = new Instructions(instructionId, admin, employee, instructionText, sentDate);
                instructionList.Add(instruction);
            }

            return instructionList;
        }
        public static void InsertInstruction(Instructions instruction)
        {
            string query = @"INSERT INTO instructions (AdminID, EmployeeID, InstructionText, SentDate)
                             VALUES (@adminId, @employeeId, @instructionText, @sentDate)";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@adminId", instruction.Admin.getuserID()),
                new MySqlParameter("@employeeId", instruction.Employee.getEmployeeID()),
                new MySqlParameter("@instructionText", instruction.InstructionText),
                new MySqlParameter("@sentDate", instruction.SentDate)
            };

            SqlHelper.executeDML(query, parameters);
        }
    }
}
