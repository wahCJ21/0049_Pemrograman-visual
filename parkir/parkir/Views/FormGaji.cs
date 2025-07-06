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
    public partial class FormGaji : Form
    {
        private GajiController controller;
        public FormGaji()
        {
            InitializeComponent();
            controller = new GajiController();
            LoadDataGrid();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int hari = (int)numHariKerja.Value;
            decimal gajiPerHari = decimal.Parse(txtGajiPerHari.Text);
            decimal total = hari * gajiPerHari;

            lblTotalGaji.Text = "Total Gaji: Rp " + total.ToString("N0");
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string filter = txtCari.Text.Trim();
            LoadDataGrid(filter);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNamaKaryawan.Text.Trim();
            int hari = (int)numHariKerja.Value;
            decimal gajiPerHari = decimal.Parse(txtGajiPerHari.Text);

            controller.SimpanGaji(nama, hari, gajiPerHari);
            MessageBox.Show("Data gaji berhasil disimpan!");

            LoadDataGrid();
        }
        private void LoadDataGrid(string namaFilter = "")
        {
            var data = controller.GetGajiList(namaFilter);

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Nama", "Nama Karyawan");
            dataGridView1.Columns.Add("Hari", "Jumlah Hari");
            dataGridView1.Columns.Add("PerHari", "Gaji Per Hari");
            dataGridView1.Columns.Add("Total", "Total Gaji");
            dataGridView1.Columns.Add("Tanggal", "Tanggal");

            foreach (var item in data)
            {
                dataGridView1.Rows.Add(
                    item.nama_karyawan,
                    item.jumlah_hari,
                    "Rp " + item.gaji_per_hari.ToString("N0"),
                    "Rp " + item.total_gaji.ToString("N0"),
                    item.tanggal.ToShortDateString()
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard mainForm = new dashboard();
            mainForm.Show();
            this.Hide();
        }
    }
}
