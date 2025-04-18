using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using System.Data.SqlClient;
namespace G_36_SmartPrint

{
    public class SqlHelper
    {
        public static string constring = "Server = localhost;Uid=root;Pwd=1234;Database= assignmentdb";
        public static void executeDML(string dml)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(dml, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }

        public static DataTable getDataTable(string sql)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
