using parkir.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parkir
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = comboBox1.SelectedItem?.ToString(); // Ambil role yang dipilih

            if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Silakan pilih role terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi login berdasarkan role
            if (role == "Admin" && username == "rudi" && password == "123")
            {
                MessageBox.Show("Login Admin berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dashboard adminForm = new dashboard(); // misalnya dashboard untuk admin
                adminForm.Show();
                this.Hide();
            }
            else if (role == "Karyawan" && username == "karyawan" && password == "123")
            {
                MessageBox.Show("Login Karyawan berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dasboard2 karyawanForm = new dasboard2(); // form khusus untuk karyawan
                karyawanForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username, password, atau role salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Karyawan");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
