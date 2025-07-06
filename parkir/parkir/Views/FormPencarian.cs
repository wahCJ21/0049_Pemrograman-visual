using parkir.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parkir.Views
{
    public partial class FormPencarian : Form
    {
        private ParkingController controller;
        public FormPencarian()
        {
            InitializeComponent();
            controller = new ParkingController();
            LoadData(); // Tampilkan semua data saat pertama kali
        }

        private void LoadData(string keyword = "")
        {
            var data = controller.CariParkir(keyword);
            dataGridView1.DataSource = data;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            LoadData(keyword); // Tampilkan hasil pencarian
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dasboard2 mainForm = new dasboard2();
            mainForm.Show();
            this.Hide();
        }
    }
}
