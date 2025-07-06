using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkir.Models
{
    public class Gaji
    {
        public int id { get; set; }
        public string nama_karyawan { get; set; }
        public int jumlah_hari { get; set; }
        public decimal gaji_per_hari { get; set; }
        public decimal total_gaji { get; set; }
        public DateTime tanggal { get; set; }
    }
}
