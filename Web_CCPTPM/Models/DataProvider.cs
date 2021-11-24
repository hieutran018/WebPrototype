

using Microsoft.Data.SqlClient;

namespace WEB.Models
{
    public class DataProvider
    {
        public static SqlConnection connectDB()
        {

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-RCDV2QVA\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
                conn.Open();
                return conn;

            }
            catch
            {
                return null;
            }
        }

    }
}

