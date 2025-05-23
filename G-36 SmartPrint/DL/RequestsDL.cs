﻿using G_36_SmartPrint.BL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace G_36_SmartPrint.DL
{
    internal class RequestsDL
    {
        // Load all requests with correct columns
        public static List<requestsBL> LoadAllRequests()
        {
            List<requestsBL> requests = new List<requestsBL>();

            string query = @"
                SELECT 
                    r.RequestID,
                    r.EmployeeID,
                    r.Quantity,
                    r.Request_StatusID,

                    ci.Item_ID,
                    ci.Item_name,
                    ci.CurrentStock,

                    lt.LookupID,
                    lt.LookupValue

                FROM requests r
                INNER JOIN consumableinventory ci ON r.Requested_item_Id = ci.Item_ID
                INNER JOIN lookuptable lt ON r.Request_StatusID = lt.LookupID;
            ";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                EmployeesBL employee = EmployeeDL.LoadEmployeeById(Convert.ToInt32(row["EmployeeID"]));

                ConsumableInventoryBL item = new ConsumableInventoryBL(
                    Convert.ToInt32(row["Item_ID"]),
                    row["Item_name"].ToString(),
                    Convert.ToInt32(row["CurrentStock"])
                );

                LookupBL status = new LookupBL(
                    Convert.ToInt32(row["LookupID"]),
                    row["LookupValue"].ToString()
                );

                requestsBL request = new requestsBL
                {
                    reqquestid = Convert.ToInt32(row["RequestID"]),
                    employees = employee,
                    requested_item = item,
                    quantity = Convert.ToInt32(row["Quantity"]),
                    approvalstatus = status
                };

                requests.Add(request);
            }

            return requests;

        }
        public static List<requestsBL> LoadAllRequestsbyEmployeeID(int id)
        {
            List<requestsBL> requests = new List<requestsBL>();

            string query = $"SELECT r.RequestID, r.EmployeeID,r.Quantity, r.Request_StatusID, ci.Item_ID, ci.Item_name, ci.CurrentStock,lt.LookupID,lt.LookupValue FROM requests r INNER JOIN consumableinventory ci ON r.Requested_item_Id = ci.Item_ID INNER JOIN lookuptable lt ON r.Request_StatusID = lt.LookupID where employeeid ={id};";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                EmployeesBL employee = EmployeeDL.LoadEmployeeById(Convert.ToInt32(row["EmployeeID"]));

                ConsumableInventoryBL item = new ConsumableInventoryBL(
                    Convert.ToInt32(row["Item_ID"]),
                    row["Item_name"].ToString(),
                    Convert.ToInt32(row["CurrentStock"])
                );

                LookupBL status = new LookupBL(
                    Convert.ToInt32(row["LookupID"]),
                    row["LookupValue"].ToString()
                );

                requestsBL request = new requestsBL
                {
                    reqquestid = Convert.ToInt32(row["RequestID"]),
                    employees = employee,
                    requested_item = item,
                    quantity = Convert.ToInt32(row["Quantity"]),
                    approvalstatus = status
                };

                requests.Add(request);
            }

            return requests;

        }
        public static void DeleteRequest(int id)
        {
            string query = $"delete * from requests where requestID = {id}";
            SqlHelper.executeDML(query);
        }
        public static void AddRequest(int requestedItemId, int employeeId, int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            string query = @"
        INSERT INTO requests (Requested_item_Id, EmployeeID, Quantity, Request_StatusID)
        VALUES (@RequestedItemId, @EmployeeID, @Quantity, 28);";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@RequestedItemId", requestedItemId),
        new MySqlParameter("@EmployeeID", employeeId),
        new MySqlParameter("@Quantity", quantity)
            };

            SqlHelper.executeDML(query, parameters);
        }

        public static void ChangeApprovalStatusToApproved(int requestId)
        {
            string query = "UPDATE requests SET Request_StatusID = 27 WHERE RequestID = @requestId";
            MySqlParameter[] parameters = {
        new MySqlParameter("@requestId", requestId)
    };
            SqlHelper.executeDML(query, parameters);
        }

        // Update Request_StatusID to 27 by RequestID
        public static void UpdateApprovalStatusToApproved(int requestId)
        {
            string query = "UPDATE requests SET Request_StatusID = 27 WHERE RequestID = @RequestID";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@RequestID", requestId)
            };

            SqlHelper.executeDML(query, parameters);
        }
    }
}
