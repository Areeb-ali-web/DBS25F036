using System;
using System.Collections.Generic;
using System.Data;
using G_36_SmartPrint.BL;
using MySql.Data.MySqlClient;


namespace G_36_SmartPrint.DL
{
    internal class FeedbackDL
    {

        public static List<FeedbackBL> LoadFeedbackByCustomerID(int customerID)
        {
            List<FeedbackBL> feedbackList = new List<FeedbackBL>();

            string query = $@"
        SELECT FeedbackID, Rating, Comment, FeedbackDate
        FROM Feedback
        WHERE CustomerID = {customerID}
        ORDER BY FeedbackDate DESC";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int feedbackId = Convert.ToInt32(row["FeedbackID"]);
                int rating = Convert.ToInt32(row["Rating"]);
                string comment = row["Comment"] == DBNull.Value ? "" : row["Comment"].ToString();
                DateTime feedbackDate = Convert.ToDateTime(row["FeedbackDate"]);

                FeedbackBL feedback = new FeedbackBL(feedbackId, rating, comment, feedbackDate);
                feedbackList.Add(feedback);
            }

            return feedbackList;
        }

        public static List<FeedbackBL> LoadFeedbackByOrderID(int orderID)
        {
            List<FeedbackBL> feedbackList = new List<FeedbackBL>();

            string query = $@"
        SELECT FeedbackID, Rating, Comment, FeedbackDate
        FROM Feedback
        WHERE OrderID = {orderID}
        ORDER BY FeedbackDate DESC";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int feedbackId = Convert.ToInt32(row["FeedbackID"]);
                int rating = Convert.ToInt32(row["Rating"]);
                string comment = row["Comment"] == DBNull.Value ? "" : row["Comment"].ToString();
                DateTime feedbackDate = Convert.ToDateTime(row["FeedbackDate"]);

                FeedbackBL feedback = new FeedbackBL(feedbackId, rating, comment, feedbackDate);
                feedbackList.Add(feedback);
            }

            return feedbackList;
        }
        public static List<FeedbackBL> LoadFeedbackByOrderId(int orderId)
        {
            string query = $"SELECT FeedbackID, Rating, Comment, FeedbackDate FROM Feedback WHERE OrderID = {orderId}";
            DataTable dt = SqlHelper.getDataTable(query);

            List<FeedbackBL> feedbackList = new List<FeedbackBL>();
            foreach (DataRow row in dt.Rows)
            {
                int feedbackId = Convert.ToInt32(row["FeedbackID"]);
                int rating = Convert.ToInt32(row["Rating"]);
                string comment = row["Comment"].ToString();
                DateTime feedbackDate = Convert.ToDateTime(row["FeedbackDate"]);

                FeedbackBL feedback = new FeedbackBL(feedbackId, rating, comment, feedbackDate);
                feedbackList.Add(feedback);
            }

            return feedbackList;
        }

        public static List<FeedbackBL> LoadFeedbackByProductName(string productName)
        {
            List<FeedbackBL> feedbackList = new List<FeedbackBL>();

            // WARNING: Directly embedding input - only safe if productName is controlled/sanitized
            string query = $@"
        SELECT DISTINCT f.FeedbackID, f.Rating, f.Comment, f.FeedbackDate
        FROM Feedback f
        JOIN Orders o ON f.OrderID = o.OrderID
        JOIN OrderDetails od ON o.OrderID = od.OrderID
        JOIN Products p ON od.ProductID = p.ProductID
        WHERE p.Name = '{productName}'
        ORDER BY f.FeedbackDate DESC";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int feedbackId = Convert.ToInt32(row["FeedbackID"]);
                int rating = Convert.ToInt32(row["Rating"]);
                string comment = row["Comment"] == DBNull.Value ? "" : row["Comment"].ToString();
                DateTime feedbackDate = Convert.ToDateTime(row["FeedbackDate"]);

                FeedbackBL feedback = new FeedbackBL(feedbackId, rating, comment, feedbackDate);
                feedbackList.Add(feedback);
            }

            return feedbackList;
        }

        public static void AddFeedback(int orderId, int customerId, int rating, string comment)
        {
            // Escape single quotes in comment to prevent SQL errors
            string safeComment = comment.Replace("'", "''");

            string query = $@"
        INSERT INTO Feedback (OrderID, CustomerID, Rating, Comment, FeedbackDate)
        VALUES ({orderId}, {customerId}, {rating}, '{safeComment}', NOW())";

            SqlHelper.executeDML(query);
        }

        public static void DeleteFeedbackByComment(string comment)
        {
            // Sanitize input by escaping single quotes
            string safeComment = comment.Replace("'", "''");

            string query = $"DELETE FROM Feedback WHERE Comment = '{safeComment}'";
            SqlHelper.executeDML(query);
        }

        public static void DeleteFeedbackByRating(int rating)
        {
            string query = $"DELETE FROM Feedback WHERE Rating = {rating}";
            SqlHelper.executeDML(query);
        }



        public static List<FeedbackBL> LoadAllFeedback()
        {
            List<FeedbackBL> feedbackList = new List<FeedbackBL>();

            string query = @"
                SELECT FeedbackID, Rating, Comment, FeedbackDate
                FROM Feedback
                ORDER BY FeedbackDate DESC";

            DataTable dt = SqlHelper.getDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                int feedbackId = Convert.ToInt32(row["FeedbackID"]);
                int rating = Convert.ToInt32(row["Rating"]);
                string comment = row["Comment"] == DBNull.Value ? "" : row["Comment"].ToString();
                DateTime feedbackDate = Convert.ToDateTime(row["FeedbackDate"]);

                FeedbackBL feedback = new FeedbackBL(feedbackId, rating, comment, feedbackDate);
                feedbackList.Add(feedback);
            }

            return feedbackList;
        }
    }
}
