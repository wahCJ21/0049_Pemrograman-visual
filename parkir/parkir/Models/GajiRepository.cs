using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkir.Models
{
    public class GajiRepository
    {
        // ✅ Tidak perlu lagi connectionString di sini karena sudah ada di Koneksi.cs

        public static void SimpanGaji(Gaji gaji)
        {
            using (SqlConnection conn = Koneksi.GetConnection()) // ✅ Pakai class Koneksi
            {
                conn.Open();
                string query = "INSERT INTO gaji (nama_karyawan, jumlah_hari, gaji_per_hari, total_gaji, tanggal) VALUES (@nama, @hari, @perhari, @total, @tanggal)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", gaji.nama_karyawan);
                cmd.Parameters.AddWithValue("@hari", gaji.jumlah_hari);
                cmd.Parameters.AddWithValue("@perhari", gaji.gaji_per_hari);
                cmd.Parameters.AddWithValue("@total", gaji.total_gaji);
                cmd.Parameters.AddWithValue("@tanggal", gaji.tanggal);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static List<Gaji> GetGajiList(string filterNama = "")
        {
            List<Gaji> list = new List<Gaji>();

            using (SqlConnection conn = Koneksi.GetConnection()) // ✅ Pakai class Koneksi
            {
                conn.Open();
                string query = "SELECT * FROM gaji";

                if (!string.IsNullOrEmpty(filterNama))
                {
                    query += " WHERE nama_karyawan LIKE @filter";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(filterNama))
                {
                    cmd.Parameters.AddWithValue("@filter", "%" + filterNama + "%");
                }

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Gaji
                    {
                        id = (int)reader["id"],
                        nama_karyawan = reader["nama_karyawan"].ToString(),
                        jumlah_hari = (int)reader["jumlah_hari"],
                        gaji_per_hari = (decimal)reader["gaji_per_hari"],
                        total_gaji = (decimal)reader["total_gaji"],
                        tanggal = (DateTime)reader["tanggal"]
                    });
                }
                conn.Close();
            }

            return list;
        }
    }
}
