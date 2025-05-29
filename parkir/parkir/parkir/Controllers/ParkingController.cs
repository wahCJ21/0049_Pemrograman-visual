using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parkir.Models;

namespace parkir.Controllers
{
    internal class ParkingController
    {
        public void AddParkingData(string noPlat, string name, DateTime date, string jenisKendaraan, string jamMasuk, string jamKeluar)
        {
            DatabaseHelper.InsertData(noPlat, name, date, jenisKendaraan, jamMasuk, jamKeluar);
        }

        public void UpdateParkingData(string noPlat, string name, DateTime date, string jenisKendaraan, string jamMasuk, string jamKeluar)
        {
            DatabaseHelper.UpdateData(noPlat, name, date, jenisKendaraan, jamMasuk, jamKeluar);
        }

        public void DeleteParkingData(string noPlat)
        {
            DatabaseHelper.DeleteData(noPlat);
        }

        public DataTable GetAllParkingData()
        {
            return DatabaseHelper.SelectAll();
        }

        public DataTable SearchParkingByPlat(string plat)
        {
            return DatabaseHelper.SearchByPlat(plat);
        }
    }
}
