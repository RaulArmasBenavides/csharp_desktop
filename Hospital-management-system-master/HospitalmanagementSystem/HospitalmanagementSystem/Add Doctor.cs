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
    public partial class Add_Doctor : Form
    {
        SqlConnection c = new SqlConnection(Constantes.RUTA);
        public String getWord = "";
        public Add_Doctor()
        {
            InitializeComponent();
            Display();
            GetDoctorId();
        }

        void GetDoctorId()
        {
            SqlDataAdapter sd = new SqlDataAdapter(@"SELECT        d_id
FROM            doctor  ", c);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                DoctorID.Items.Add(item[0].ToString());
            }
        }

        void Display()
        {

           
            SqlDataAdapter cm1 = new SqlDataAdapter(@"SELECT        d_id, d_name,w_no
FROM            doctor  ", c);

            DataTable dt1 = new DataTable();
            cm1.Fill(dt1);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt1.Rows)
            {
                try {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                c.Open();
                SqlCommand cm = new SqlCommand(@"INSERT INTO doctorCheckPatient
                         (p_id, d_id, discharge_date)
VALUES        ('" + PatientID.Text + "','" + DoctorID.Text + "','" + "Null" + "')", c);
                cm.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("Successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Doctor_Load(object sender, EventArgs e)
        {

        }

    }
}
