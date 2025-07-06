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

    public partial class Karyawan : Form
    {
        private KaryawanController karyawanController = new KaryawanController();

        public Karyawan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            karyawanController.AddKaryawan(textBox1.Text, textBox3.Text, textBox3.Text);
            MessageBox.Show("Data karyawan ditambahkan.");
            dataGridView1.DataSource = karyawanController.GetAllKaryawan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            karyawanController.UpdateKaryawan(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Data karyawan diperbarui.");
            dataGridView1.DataSource = karyawanController.GetAllKaryawan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            karyawanController.DeleteKaryawan(textBox1.Text);
            MessageBox.Show("Data karyawan dihapus.");
            dataGridView1.DataSource = karyawanController.GetAllKaryawan();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = karyawanController.GetAllKaryawan();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dashboard mainForm = new dashboard();
            mainForm.Show();
            this.Hide();  
        }
    }
}
