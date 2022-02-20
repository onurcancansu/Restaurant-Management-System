using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONURCANCANSU_2017100144_RESTAURANTMANAGEMENT
{
    public partial class Formadmin : Form
    {
        public Formadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txtpass.Text == "1234")
            {
                Patron enter = new Patron();
                enter.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please, enter the correct username and password.");
            }
        }

        private void Txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtpass_Enter(object sender, EventArgs e)
        {
            if (Txtpass.Text == "Password")
            {
                Txtpass.Text = "";
                Txtpass.ForeColor = Color.Black;
            }
        }

        private void Txtpass_Leave(object sender, EventArgs e)
        {
            if (Txtpass.Text == "")
            {
                Txtpass.Text = "Password";
                Txtpass.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
