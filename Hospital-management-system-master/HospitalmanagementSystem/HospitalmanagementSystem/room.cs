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
    public partial class room : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=ANUPAM\ANUPAM;Initial Catalog=hospitalManagementSystem;Integrated Security=True");
        bool st = true;
        public room()
        {
            InitializeComponent();
            Display();
        }

        private void RefreshAll()
        {
            wordNo.SelectedIndex = -1;
            roomNo.SelectedIndex = -1;
            rroomtype.SelectedIndex = -1;
            bedCapacity.SelectedIndex = -1;
            sitCharge.SelectedIndex = -1;

            this.Close();
            room r = new room();
            r.Show();
        }

        void Display()
        {

            SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM room ", c);

            DataTable dt = new DataTable();

            cm.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter cc = new SqlDataAdapter(" SELECT room_no FROM room", c);

            DataTable dw = new DataTable();

            cc.Fill(dw);


            foreach (DataRow item in dw.Rows)
            {

                int n = 0;
                string[] wn = new string[4];
                wn[n] = item[0].ToString();


                if (wordNo.Text == wn[n])
                {
                    MessageBox.Show("Already added.\n Add another.");
                    this.Close();
                    room p = new room();
                    p.Show();
                    st = false;
                }
            }

            if (st)
            {
                if (wordNo.Text == "" || rroomtype.Text == "" || bedCapacity.Text == "" )
                {
                    MessageBox.Show("Fill all boxes");
                }
                else
                {

                    c.Open();
                    SqlCommand cm = new SqlCommand(@"INSERT INTO room
                         (w_no, room_no, room_type, capacity, charge)
VALUES          ('" + wordNo.Text + "','" + roomNo.Text + "','" + rroomtype.Text + "','" + bedCapacity.Text + "','" + sitCharge.Text + "') ", c);
                    cm.ExecuteNonQuery();
                    c.Close();

                    Display();
                    MessageBox.Show("Room added");
                    RefreshAll();
                }
                st = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Administration m = new Administration();
            m.Show();
        }

        private void room_Load(object sender, EventArgs e)
        {

        }


       

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshAll();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand cm = new SqlCommand(@"UPDATE       room
SET                w_no = '" + wordNo.Text + "', room_no = '" + roomNo.Text + "', room_type = '" + rroomtype.Text + "', capacity = '" + bedCapacity.Text + "', charge = '" + sitCharge.Text + "' WHERE (room_no = '" + roomNo.Text + "' or w_no = '" + wordNo.Text + "') ", c);

            cm.ExecuteNonQuery();
            c.Close();
        }

        

        
        
    }
}
