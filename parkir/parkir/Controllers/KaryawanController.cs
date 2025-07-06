using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace parkir.Controllers
{
    public class KaryawanController
    {
        private static string connectionString = @"Data Source=LAPTOP-B61O4TU8\WAHYU;Initial Catalog=parking_db;TrustServerCertificate=True;Integrated Security=True;";

        public void AddKaryawan(string id, string nama, string shift)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Karyawan (IDKaryawan, Nama, Shift) VALUES (@id, @nama, @shift)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@shift", shift);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateKaryawan(string id, string nama, string shift)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Karyawan SET Nama = @nama, Shift = @shift WHERE IDKaryawan = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@shift", shift);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteKaryawan(string id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Karyawan WHERE IDKaryawan = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllKaryawan()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Karyawan";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
