using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HospitalmanagementSystem
{
    public partial class DoctorsRoom : Form
    {
        
        SqlConnection c = new SqlConnection(Constantes.RUTA);
        public String word_no = "";
        public DoctorsRoom()
        {
            InitializeComponent();
            Display();
            Index();
        }

        void Display()
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT*FROM DoctorRoom", c);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                DataGridViewRows(dt);


                SqlDataAdapter sd1 = new SqlDataAdapter("SELECT room_no as Room_No,w_no as Word from room", c);

                DataTable dt1 = new DataTable();
                sd1.Fill(dt1);
                DataGridView2Rows(dt1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewRows(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }

        private void DataGridView2Rows(DataTable dt)
        {
            dataGridView2.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                c.Open();
                SqlCommand cm = new SqlCommand(@"INSERT INTO DoctorRoom(d_id,room_no) VALUES('" + Did.Text + "','" + DroomNo.Text + "')", c);
                cm.ExecuteNonQuery();
                c.Close();
                Display();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Index()
        {
            SqlDataAdapter sd = new SqlDataAdapter("SELECT room_no FROM room ", c);

            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {


                DroomNo.Items.Add(item[0].ToString());

            }
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DroomNo.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void DoctorsRoom_MouseClick(object sender, MouseEventArgs e)
        {
            DroomNo.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
        }

       

       
    
    }
}
