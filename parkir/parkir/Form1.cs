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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HAIN24I\TIKET;Initial Catalog=parking_db;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("update parking set name=@name,date=@date,jenis_kendaraan=@jenis_kendaraan where no_plat=@no_plat", con);
            cnn.Parameters.AddWithValue("@no_plat", textBox1.Text);
            cnn.Parameters.AddWithValue("@name", textBox3.Text);
            cnn.Parameters.AddWithValue("@date", dateTimePicker1.Value);

            string jenisKendaraan = "";
            if (radioButtonMobil.Checked)
            {
                jenisKendaraan = "Mobil";
            }
            else if (radioButtonMontor.Checked)
            {
                jenisKendaraan = "Motor";
            }

            cnn.Parameters.AddWithValue("@jenis_kendaraan", jenisKendaraan);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!"); // Lebih baik menggunakan "Updated" untuk operasi update


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HAIN24I\TIKET;Initial Catalog=parking_db;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete parking where no_plat=@no_plat", con);
            cnn.Parameters.AddWithValue("@no_plat", textBox1.Text); // Kirim sebagai string
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HAIN24I\TIKET;Initial Catalog=parking_db;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into parking values(@no_plat,@name,@date,@jenis_kendaraan)", con);
            cnn.Parameters.AddWithValue("@no_plat", textBox1.Text);
            cnn.Parameters.AddWithValue("@name", textBox3.Text);
            cnn.Parameters.AddWithValue("@date", dateTimePicker1.Value);

            string jenisKendaraan = "";
            if (radioButtonMobil.Checked)
            {
                jenisKendaraan = "Mobil=10000";
            }
            else if (radioButtonMontor.Checked)
            {
                jenisKendaraan = "Motor=5000";
            }

            cnn.Parameters.AddWithValue("@jenis_kendaraan", jenisKendaraan);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HAIN24I\TIKET;Initial Catalog=parking_db;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from parking", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HAIN24I\TIKET;Initial Catalog=parking_db;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from parking", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
