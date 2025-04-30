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
    public partial class Form2 : Form
    {
        string usernameBenar = "admin";
        string passwordBenar = "123";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == usernameBenar && txtPassword.Text == passwordBenar)
            {
                
                Form1 menu = new Form1();
                menu.Show();
                this.Hide();
            }
            else
            {
              
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
