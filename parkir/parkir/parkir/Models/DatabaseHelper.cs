using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace parkir.Models
{
    public class DatabaseHelper
    {
        public static void InsertData(string noPlat, string name, DateTime date, string jenisKendaraan, string jamMasuk, string jamKeluar)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                string query = "INSERT INTO parking VALUES (@no_plat, @name, @date, @jenis_kendaraan, @jam_masuk, @jam_keluar)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@no_plat", noPlat);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@jenis_kendaraan", jenisKendaraan);
                cmd.Parameters.AddWithValue("@jam_masuk", jamMasuk);
                cmd.Parameters.AddWithValue("@jam_keluar", jamKeluar);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void UpdateData(string noPlat, string name, DateTime date, string jenisKendaraan, string jamMasuk, string jamKeluar)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                string query = "UPDATE parking SET name=@name, date=@date, jenis_kendaraan=@jenis_kendaraan, jam_masuk=@jam_masuk, jam_keluar=@jam_keluar WHERE no_plat=@no_plat";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@no_plat", noPlat);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@jenis_kendaraan", jenisKendaraan);
                cmd.Parameters.AddWithValue("@jam_masuk", jamMasuk);
                cmd.Parameters.AddWithValue("@jam_keluar", jamKeluar);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void DeleteData(string noPlat)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                string query = "DELETE FROM parking WHERE no_plat=@no_plat";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@no_plat", noPlat);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static DataTable SelectAll()
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM parking", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable SearchByPlat(string plat)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM parking WHERE no_plat LIKE @no_plat", con);
                cmd.Parameters.AddWithValue("@no_plat", "%" + plat + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}

