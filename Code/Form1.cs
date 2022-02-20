using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ONURCANCANSU_2017100144_RESTAURANTMANAGEMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        //public string conString = "Data Source=DESKTOP-K7L8L8G;Initial Catalog=ConnectionDB;Integrated Security=True";

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TxtID_Enter(object sender, EventArgs e)
        {
            if (TxtID.Text == "Username")
            {
                TxtID.Text = "";
                TxtID.ForeColor = Color.Black;
            }

        }

        private void TxtID_Leave(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                TxtID.Text = "Username";
                TxtID.ForeColor = Color.Silver;
            }
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

        

        private void label4_Click(object sender, EventArgs e)
        {
            Formadmin fa = new Formadmin();
            fa.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K7L8L8G;Initial Catalog=restoran;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from TblUsers where Username ='" + TxtID.Text + "' and Password = '" + Txtpass.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                // Enter.show

                Product enter = new Product();
                enter.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please, enter the correct username and password.");
            }
        }
    }
}
/*

*/
