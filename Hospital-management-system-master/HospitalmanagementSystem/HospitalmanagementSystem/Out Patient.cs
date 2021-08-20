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
    public partial class Out_Patient : Form
    {
        SqlConnection c = new SqlConnection(Constantes.RUTA);
        PatientAppoinment fixAppaoinment;
        public bool doctor = false;
        public String DoctorPid = "";
        int IdNo = 120000;
        int token = 0;
        public Out_Patient(int st,String id)
        {
            if (st == 1)
            {
                doctor = true;
            }
            DoctorPid = id;
            InitializeComponent();
            Display();
            DisplayDoctorRoom();
            setPatientId();
            setPatientId();
        }

        void setPatientId()
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT p_id FROM Outpatient", c);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {


                    String wn = item[0].ToString();

                    IdNo = Convert.ToInt32(wn);

                }

                
                    IdNo = IdNo + 1;
                   

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void setToken()
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT appoinment_no FROM Outpatient", c);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {


                    String wn = item[0].ToString();

                    token = Convert.ToInt32(wn);

                }

                token++;
                appoinmentNo.Text = token.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void DisplayDoctorRoom()
        {
            SqlDataAdapter sd = new SqlDataAdapter(@"SELECT        doctor.d_id, doctor.Speciality, DoctorRoom.room_no
FROM            doctor INNER JOIN
                         DoctorRoom ON doctor.d_id = DoctorRoom.d_id", c);

            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;


        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                c.Open();
            SqlCommand cm = new SqlCommand(@"INSERT INTO Outpatient
                         (p_id, p_name, p_gender, p_age, appoinment_no, city, country, p_mobile, room_no)
VALUES        ('"+pid.Text+"','"+pname.Text+"','"+pgender.Text+"','"+page.Text+"','"+appoinmentNo.Text+"','"+pcity.Text+"','"+pcountry.Text+"','"+pmobile.Text+"','"+proom.Text+"')", c);
            cm.ExecuteNonQuery();
            c.Close();

            Display();
            MessageBox.Show("Register successful");
            }
            catch (Exception ex)
            {
                c.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void addDataGridViewRows(DataRow item)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
            dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
            dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
            dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
            dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
            dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
            dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
            dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
            
        }

        void Display()
        {

            if (doctor)
            {
                SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM Outpatient WHERE (p_id = '"+DoctorPid+"')", c);
                DataTable dt = new DataTable();

                cm.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            else 
            {
                SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM Outpatient ", c);
                DataTable dt = new DataTable();

                cm.Fill(dt);
                dataGridView1.DataSource = dt;
            }


            

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                pid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                pname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                pgender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                page.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                appoinmentNo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                pcity.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                pcountry.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                pmobile.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                proom.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fixAppaoinment = new PatientAppoinment();
            fixAppaoinment.PatientId.Text = pid.Text;
            fixAppaoinment.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

    }
}
