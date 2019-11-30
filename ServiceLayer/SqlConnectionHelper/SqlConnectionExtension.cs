using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class SqlConnectionExtension
    {
        static SqlConnection conn = new SqlConnection();


        public static SqlCommand ConnectToDb(string commandText)
        {
            conn.ConnectionString = ConnectionHelper.ConnectionString;


            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = commandText;

            cmd.Connection = conn;

            return cmd;
        }
        
    }
}
