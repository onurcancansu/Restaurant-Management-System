using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONURCANCANSU_2017100144_RESTAURANTMANAGEMENT
{
    public partial class Patron : Form
    {
        
       public Patron()
       {
           InitializeComponent();
           Receive();
           Place();
           
           
           
        }
       SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-K7L8L8G;Initial Catalog=restoran;Integrated Security=True");

       private void Receive()
       {


           Con.Open();
           string query = "select * from TblProduct";
           SqlDataAdapter sda = new SqlDataAdapter(query, Con);
           SqlCommandBuilder builder = new SqlCommandBuilder(sda);
           var ds = new DataSet();
           sda.Fill(ds);
           dataGridView2.DataSource = ds.Tables[0];
           Con.Close();

       }
        private void Filter()
        {


            Con.Open();
            string query = "select * from TblProduct where PlaceNo= '"+comboBox1.SelectedItem.ToString() +"'  ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void Place()
        {


            Con.Open();
            string query = "Select PlaceNo, OrderName, OrderQuan * OrderPrice as Total from TblProduct";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            Con.Close();

        }
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Receive();
        }

        private void Filter1()
        {

            
            Con.Open();
            string query = "select PlaceNo, SUM(OrderQuan*OrderPrice) as Total from TblProduct where PlaceNo= '" + comboBox2.SelectedItem.ToString() + "' group by PlaceNo  ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            Con.Close();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter1();
        }
        private void Receive1()
        {


            Con.Open();
            string query = "Select PlaceNo, OrderName, OrderQuan * OrderPrice as Total from TblProduct";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Receive1();
        }
        
        
        
    }
}
