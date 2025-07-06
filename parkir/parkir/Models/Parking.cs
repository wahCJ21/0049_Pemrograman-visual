using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkir.Models
{
    public class Parking
    {
        public string no_plat { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public string jenis_kendaraan { get; set; }
        public TimeSpan jam_masuk { get; set; }
        public TimeSpan? jam_keluar { get; set; }

    }
}
