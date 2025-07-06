using parkir.Controllers;
using parkir.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parkir
{
    public partial class Form1 : Form
    {
        private ParkingController controller = new ParkingController();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string jenisKendaraan = radioButtonMobil.Checked ? "Mobil= 5000" : (radioButtonMontor.Checked ? "Motor= 2000" : "");

            controller.UpdateParkingData(
                textBox1.Text,
                textBox3.Text,
                dateTimePicker1.Value,
                jenisKendaraan,
                textBoxJamMasuk.Text,
                textBoxJamKeluar.Text
            );

            MessageBox.Show("Data berhasil diperbarui!");
            dataGridView1.DataSource = controller.GetAllParkingData();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.DeleteParkingData(textBox1.Text);
                MessageBox.Show("Data berhasil dihapus.");
                dataGridView1.DataSource = controller.GetAllParkingData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jenisKendaraan = radioButtonMobil.Checked ? "Mobil= 5000" : (radioButtonMontor.Checked ? "Motor= 2000" : "");

            controller.AddParkingData(
                textBox1.Text,
                textBox3.Text,
                dateTimePicker1.Value,
                jenisKendaraan,
                textBoxJamMasuk.Text,
                textBoxJamKeluar.Text
            );

            MessageBox.Show("Data berhasil ditambahkan!");
            dataGridView1.DataSource = controller.GetAllParkingData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.GetAllParkingData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.GetAllParkingData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncari_Click(object sender, EventArgs e)
        {
            string cariPlat = textBoxcari.Text.Trim();

            if (string.IsNullOrWhiteSpace(cariPlat))
            {
                MessageBox.Show("Masukkan nomor plat untuk mencari data.");
                return;
            }

            DataTable result = controller.SearchParkingByPlat(cariPlat);
            if (result.Rows.Count > 0)
            {
                dataGridView1.DataSource = result;
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan.");
                dataGridView1.DataSource = null;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dashboard mainForm = new dashboard();
            mainForm.Show();
            this.Hide();
        }

        private void radioButtonMontor_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
