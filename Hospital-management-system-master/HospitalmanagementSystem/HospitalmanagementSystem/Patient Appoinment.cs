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
    public partial class PatientAppoinment : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=ANUPAM\ANUPAM;Initial Catalog=hospitalManagementSystem;Integrated Security=True");
        int IdNo = 0;
        Out_Patient outpatient;
        public PatientAppoinment()
        {
            InitializeComponent();
            setTokenId();
            GetDoctorId();
            Display();
        }

        void setTokenId()
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT tokenNo FROM appoinment", c);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {


                    String wn = item[0].ToString();

                    IdNo = Convert.ToInt32(wn);

                }

               
                    IdNo = IdNo + 1;
                    tokenID.Text = IdNo.ToString();
   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void GetDoctorId()
        {
            SqlDataAdapter sd = new SqlDataAdapter(@"SELECT        d_id
FROM            doctor  ", c);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                doctorID.Items.Add(item[0].ToString());
            }
        }
        void Display()
        {


            SqlDataAdapter cm1 = new SqlDataAdapter(@"SELECT        doctor.d_id, doctor.d_name, doctor.w_no, DoctorRoom.room_no
FROM            doctor INNER JOIN
                         DoctorRoom ON doctor.d_id = DoctorRoom.d_id", c);

            DataTable dt1 = new DataTable();
            cm1.Fill(dt1);
            
            dataGridView1.DataSource = dt1;


            SqlDataAdapter cm2 = new SqlDataAdapter(@"SELECT *FROM appoinment", c);

            DataTable dt2 = new DataTable();
            cm2.Fill(dt2);
           
            dataGridView2.DataSource = dt2;

            }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            doctorID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            RoomNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date.Text = dateTimePicker1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void PatientAppoinment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            outpatient = new Out_Patient(0,"");
            this.Close();
            outpatient.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                c.Open();
                SqlCommand cm = new SqlCommand(@"INSERT INTO appoinment
                         (tokenNo, d_id, p_id, AppoinmentDate, roomNo)
VALUES        ('" + tokenID.Text + "','" + doctorID.Text + "','" + PatientId.Text + "','" + Date.Text + "','" + RoomNo.Text + "')", c);
                cm.ExecuteNonQuery();

                SqlCommand cmo = new SqlCommand(@"UPDATE       Outpatient
SET                appoinment_no = '" + tokenID.Text + "',room_no = '" + RoomNo.Text + "'  WHERE ( p_id = '" + PatientId.Text + "')", c);
                cmo.ExecuteNonQuery();

                c.Close();
                MessageBox.Show("Saved");
                Display();


            }
            catch (Exception ex)
            {
                c.Close();
                MessageBox.Show(ex.Message);
            }
        }

        }
    }

