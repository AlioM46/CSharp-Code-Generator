using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess_Layer
{
    public class clsDataAccessSettings
    {
        public static string connectionString { get; set; }

        public static bool IsValidCredentials(string username, string password)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                return true;
                // Continue Here.
            }

        }

    }
}
