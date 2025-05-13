using System;
using System.Collections.Generic;
using System.Data;
using G_36_SmartPrint.BL;

namespace G_36_SmartPrint.DL
{
    internal class FinancialReportDL
    {
        public static bool AddFinancialReport(FinancialReportBL report)
        {
            if (report == null || report.Manager == null)
                return false;

            string query = @"
                INSERT INTO financialReport (managerid, date, TotalRevenue, totalexpenses, netprofit) 
                VALUES (@managerid, @date, @TotalRevenue, @totalexpenses, @netprofit)";

            var parameters = new MySqlConnector.MySqlParameter[]
            {
                new MySqlConnector.MySqlParameter("@managerid", report.Manager.EmployeeID),
                new MySqlConnector.MySqlParameter("@date", report.Date),
                new MySqlConnector.MySqlParameter("@TotalRevenue", report.totalRevinue),
                new MySqlConnector.MySqlParameter("@totalexpenses", report.totalexpenses),
                new MySqlConnector.MySqlParameter("@netprofit", report.totalprofit)
            };

            try
            {
                SqlHelper.executeDML(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error adding report: " + ex.Message);
                return false;
            }
        }

        public static List<FinancialReportBL> LoadAllReports()
        {
            List<FinancialReportBL> reports = new List<FinancialReportBL>();

            string query = "SELECT * FROM financialReport";
            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["finance_id"]);
                int managerId = Convert.ToInt32(row["managerid"]);
                DateTime date = Convert.ToDateTime(row["date"]);
                decimal revenue = Convert.ToDecimal(row["TotalRevenue"]);
                decimal expenses = Convert.ToDecimal(row["totalexpenses"]);
                decimal profit = Convert.ToDecimal(row["netprofit"]);

                ManagerBL manager = ManagerBL.GetManagerByID(managerId);
                if (manager != null)
                {
                    FinancialReportBL report = new FinancialReportBL(id, manager, date, revenue, expenses, profit);
                    reports.Add(report);
                }
            }

            return reports;
        }

        public static FinancialReportBL GetReportById(int reportId)
        {
            string query = $"SELECT * FROM financialReport WHERE finance_id = {reportId}";
            DataTable dt = SqlHelper.getDataTable(query);

            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            int managerId = Convert.ToInt32(row["managerid"]);
            DateTime date = Convert.ToDateTime(row["date"]);
            decimal revenue = Convert.ToDecimal(row["TotalRevenue"]);
            decimal expenses = Convert.ToDecimal(row["totalexpenses"]);
            decimal profit = Convert.ToDecimal(row["netprofit"]);

            ManagerBL manager = ManagerBL.GetManagerByID(managerId);
            if (manager != null)
            {
                return new FinancialReportBL(reportId, manager, date, revenue, expenses, profit);
            }

            return null;
        }

        public static List<FinancialReportBL> GetReportsByManager(int managerId)
        {
            List<FinancialReportBL> reports = new List<FinancialReportBL>();
            string query = $"SELECT * FROM financialReport WHERE managerid = {managerId}";
            DataTable dt = SqlHelper.getDataTable(query);

            ManagerBL manager = ManagerBL.GetManagerByID(managerId);
            if (manager == null)
                return reports;

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["finance_id"]);
                DateTime date = Convert.ToDateTime(row["date"]);
                decimal revenue = Convert.ToDecimal(row["TotalRevenue"]);
                decimal expenses = Convert.ToDecimal(row["totalexpenses"]);
                decimal profit = Convert.ToDecimal(row["netprofit"]);

                FinancialReportBL report = new FinancialReportBL(id, manager, date, revenue, expenses, profit);
                reports.Add(report);
            }

            return reports;
        }

        public static bool DeleteReportById(int reportId)
        {
            string query = $"DELETE FROM financialReport WHERE finance_id = {reportId}";

            try
            {
                SqlHelper.executeDML(query);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error deleting report: " + ex.Message);
                return false;
            }
        }
    }
}
