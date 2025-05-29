using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkir
{
    internal class Koneksi
    {
        private static string connectionString = @"Data Source=DESKTOP-HAIN24I\TIKET;Initial Catalog=parking_db;TrustServerCertificate=True;Integrated Security=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
