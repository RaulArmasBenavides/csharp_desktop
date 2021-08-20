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
    public partial class AddBed : Form
    {
        SqlConnection c = new SqlConnection(Constantes.RUTA);
        public AddBed()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand cm = new SqlCommand(@"INSERT INTO AddBed2
                         (bed_no, room_no)
VALUES        ('" + Convert.ToInt32(bedNo.Text) + "','" + Convert.ToInt32(roomNo.Text) + "')", c);
            cm.ExecuteNonQuery();
            c.Close();
            MessageBox.Show("Success");

           



        }

        private void AddBed_Load(object sender, EventArgs e)
        {

        }
    }
}
