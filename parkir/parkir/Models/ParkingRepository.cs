using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkir.Models
{
    public class ParkingRepository
    {
        public static List<Parking> GetAll(string keyword = "")
        {
            List<Parking> list = new List<Parking>();

            using (SqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                string query = "SELECT no_plat, name, date, jenis_kendaraan, jam_masuk, jam_keluar FROM parking";

                if (!string.IsNullOrEmpty(keyword))
                {
                    query += " WHERE no_plat LIKE @keyword OR name LIKE @keyword";
                }

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(keyword))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                }

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Variable sementara untuk parsing jam
                    TimeSpan tempJamMasuk;
                    TimeSpan tempJamKeluar;

                    list.Add(new Parking
                    {
                        no_plat = reader["no_plat"].ToString(),
                        name = reader["name"].ToString(),

                        // ✅ Parsing tanggal aman
                        date = DateTime.TryParse(reader["date"].ToString(), out DateTime tempDate)
                            ? tempDate
                            : DateTime.MinValue,

                        jenis_kendaraan = reader["jenis_kendaraan"].ToString(),

                        // ✅ Parsing jam_masuk aman
                        jam_masuk = TimeSpan.TryParse(reader["jam_masuk"].ToString(), out tempJamMasuk)
                            ? tempJamMasuk
                            : TimeSpan.Zero,

                        // ✅ Parsing jam_keluar aman
                        jam_keluar = reader["jam_keluar"] == DBNull.Value
                            ? null
                            : (TimeSpan?)(
                                TimeSpan.TryParse(reader["jam_keluar"].ToString(), out tempJamKeluar)
                                    ? tempJamKeluar
                                    : TimeSpan.Zero
                            )
                    });
                }

                conn.Close();
            }

            return list;
        }
    }
}

