using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace LoginProject
{
    class connct
    {
        static MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
        static MySqlDataAdapter adapter;
        static DataTable table = new DataTable();
        static MySqlCommand cmd;

        public static int querylogin(string log)
        {
            try
            {
                adapter = new MySqlDataAdapter(log, conn);
                adapter.Fill(table);
                return table.Rows.Count;
            }
            finally
            {
                table.Clear();
            }
        }

        public static bool query(string qry)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(qry, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
            
    }
}
