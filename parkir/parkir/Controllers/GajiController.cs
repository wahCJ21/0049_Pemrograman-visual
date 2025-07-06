using parkir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkir.Controllers
{
    public class GajiController
    {
        public void SimpanGaji(string nama, int jumlahHari, decimal gajiPerHari)
        {
            decimal totalGaji = jumlahHari * gajiPerHari;
            Gaji gaji = new Gaji
            {
                nama_karyawan = nama,
                jumlah_hari = jumlahHari,
                gaji_per_hari = gajiPerHari,
                total_gaji = totalGaji,
                tanggal = System.DateTime.Now.Date
            };
            GajiRepository.SimpanGaji(gaji);
        }

        public List<Gaji> GetGajiList(string namaFilter = "")
        {
            return GajiRepository.GetGajiList(namaFilter);
        }
    }
}
