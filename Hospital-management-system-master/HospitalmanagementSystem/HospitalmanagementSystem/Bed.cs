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
    public partial class BedSelection : Form
    {

        SqlConnection c = new SqlConnection(Constantes.RUTA);
        
        public BedSelection()
        {
            

            InitializeComponent();
            Display();
            setWord();
            
        }
        void Display()
        {
            SqlDataAdapter sd = new SqlDataAdapter(@"select * from AddBed2",c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
              {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();

                SqlDataAdapter sd1 = new SqlDataAdapter(@"SELECT        COUNT(p_id) AS Expr1
                  FROM            Bed
                   WHERE        (bed_no = '" + item[0].ToString() + "' and room_no = '" + item[1].ToString() + "')", c);
                DataTable dt1 = new DataTable();
                sd1.Fill(dt1);
                

                foreach (DataRow item1 in dt1.Rows)
                {

                    if (item1[0].ToString() == "0")
                    {
                        dataGridView1.Rows[n].Cells[2].Value = "Free";
                    }
                    else 
                    {
                        dataGridView1.Rows[n].Cells[2].Value = "Booked";
                    }
                }
            }
        }
        void setWord()
        {
            SqlDataAdapter sd = new SqlDataAdapter("SELECT W_no FROM Word", c);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {


                WordNo.Items.Add(item[0].ToString());

            }
        }
        void SetRoom()
        {
            RoomNo.Items.Clear();
            try {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT room_no FROM room WHERE (w_no = '"+WordNo.Text+"') ", c);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {


                RoomNo.Items.Add(item[0].ToString());

            }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int RoomNnumber = Convert.ToInt32(RoomNo.Text);
                int BedNumber = Convert.ToInt32(BedNo.Text);
                c.Open();
                SqlCommand cm = new SqlCommand(@"INSERT INTO Bed
                         (room_no,p_id, bed_no ) VALUES        ('" + RoomNnumber + "','" + pid.Text + "','" + BedNumber + "') ", c);
                cm.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("Success");
                Display();

                this.Close();
                this.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WordNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRoom();
        }

        private void RoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {

                SqlDataAdapter sd = new SqlDataAdapter(@"select * from AddBed2 WHERE (room_no = '"+RoomNo.Text+"')", c);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();

                    SqlDataAdapter sd1 = new SqlDataAdapter(@"SELECT        COUNT(p_id) AS Expr1
                  FROM            Bed
                   WHERE        (bed_no = '" + item[0].ToString() + "' and room_no = '" + item[1].ToString() + "')", c);
                    DataTable dt1 = new DataTable();
                    sd1.Fill(dt1);


                    foreach (DataRow item1 in dt1.Rows)
                    {

                        if (item1[0].ToString() == "0")
                        {
                            dataGridView1.Rows[n].Cells[2].Value = "Free";
                        }
                        else if (item1[0].ToString() == "1")
                        {
                            dataGridView1.Rows[n].Cells[2].Value = "Booked";
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BedSelection_Load(object sender, EventArgs e)
        {

        }



        
    }
}
