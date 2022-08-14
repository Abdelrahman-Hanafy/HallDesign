using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HallDesign
{
    public class DataBase
    {
        private static DataBase DB;
        private SqlConnection conn;

        private DataBase()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            //create instanace of database connection
            conn = new SqlConnection(connStr);

            //open connection
            conn.Open();
        }

        public static DataBase ConnectDB()
        {
            if (DB == null)
            {
                DB = new DataBase();
            }

            return DB;
        }

        public DataTable addHall(string name)
        {
            string query = $"exec addHall '{name}'";
            return fillTable(query);
        }

        public void addBlock(string hall, Block blk)
        {
            string query = $"exec addBlock {hall},{blk.w},{blk.h},{blk.a}," +
                $"{blk.r.Left},{blk.r.Top},{blk.r.Right},{blk.r.Bottom}";
            exec(query);
        }

        public DataTable fetchHall()
        {
            string query = "exec fetchHall ";
            return fillTable(query);
        }



        private void exec(string query)
        {
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
        }

        private DataTable fillTable(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;

        }

    }
}