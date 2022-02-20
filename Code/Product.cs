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
    public partial class Product : Form
    {

        public Product()
        {
            InitializeComponent();
            Place();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-K7L8L8G;Initial Catalog=restoran;Integrated Security=True");
        


        private void Place()
        {
            
            
            Con.Open();
            string query = "select * from TblProduct";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
            
        }
        /*
        private void Receive()
        {


            Con.Open();
            string query = "select PlaceNo from TblPlace";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dp = new DataSet();
            sda.Fill(dp);
            dataGridView1.DataSource = dp.Tables[0];
            Con.Close();

        }
        */
        
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (OrderId.Text == "" || OrderName.Text == "" || OrderQuan.Text == "" || OrderPrice.Text == "" || PlaceNo.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information!");
            }
            else
            {

                try
                {
                    Con.Open();
                    string query = "insert into TblProduct values('" + OrderId.Text + "', '" + OrderName.Text + "', '" + OrderQuan.Text + "', '" + OrderPrice.Text + "', '" + PlaceNo.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    Con.Close();
                    Place();

                    OrderId.Text = "";
                    OrderName.Text = "";
                    OrderQuan.Text = "";
                    OrderPrice.Text = "";
                    PlaceNo.Text = "";



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }


        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            //Place();
            

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            OrderId.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            OrderName.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            OrderQuan.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            OrderPrice.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            PlaceNo.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
        }











        private void circularButton3_Click(object sender, EventArgs e)
        {

            try
            {
                if (OrderId.Text == "")
                {
                    MessageBox.Show("Select the order to delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from TblProduct where OrderId=" + OrderId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Deleted Successfully");
                    Con.Close();
                    Place();
                    
                    OrderId.Text = "";
                    OrderName.Text = "";
                    OrderQuan.Text = "";
                    OrderPrice.Text = "";
                    PlaceNo.Text = "";
                     

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        private void circularButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if ( OrderId.Text == "" || OrderName.Text == "" || OrderQuan.Text == "" || OrderPrice.Text == "" || PlaceNo.Text == "") { 
                    MessageBox.Show("Sure");
                }
                else
                {
                    Con.Open();
                    string query = "update TblProduct set OrderName='" + OrderName.Text + "',OrderQuan ='" + OrderQuan.Text + "',OrderPrice='" + OrderPrice.Text + "', PlaceNo='" + PlaceNo.Text + "' where OrderId=" + OrderId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Updated Successfully");
                    Con.Close();
                    Place();
                    OrderId.Text = "";
                    OrderName.Text = "";
                    OrderQuan.Text = "";
                    OrderPrice.Text = "";
                    PlaceNo.Text = "";

                }
            }
            catch (Exception)
            {

                
            }
        }


        



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void PlaceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Receive();
        }

    }
        
        

}
