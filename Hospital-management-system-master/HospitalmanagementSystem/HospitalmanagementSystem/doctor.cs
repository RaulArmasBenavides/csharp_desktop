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
    public partial class doctor : Form
    {
        bool st = true;
        int IdNo = 123000;
        DoctorsRoom doctorRoom;
        Schedule CreatSchedule;

        SqlConnection c = new SqlConnection(Constantes.RUTA);
       
        public doctor()
        {
            InitializeComponent();
            Display();
            dsearchcategory.SelectedIndex = -1;
            setDoctorId();
            setWord();
            
        }

        void setDoctorId()
        {

            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT d_id FROM doctor", c);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {


                    String wn = item[0].ToString();

                    IdNo = Convert.ToInt32(wn);

                }

                    IdNo = IdNo + 1;
                    did.Text =  IdNo.ToString();
               
            }
            catch (Exception ex)
            {
                c.Close();
                MessageBox.Show(ex.Message);
            }

        }

        void setWord()
        {
            dword.Items.Clear();
            SqlDataAdapter sd = new SqlDataAdapter("SELECT W_no FROM Word", c);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {


                dword.Items.Add( item[0].ToString());

            }
        }

        void Display()
        {

            try
            {
                SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM doctor ", c);

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
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }
        private void RefreshAll()
        {


            this.Refresh();
            Display();
            dname.Text = "";
            dgender.SelectedIndex = -1;
            dage.Text = "";
            dq.Text = "";
            dsalary.Text = "";
            dmobile.Text = "";
            setWord();
            daddress.Text = "";
            dsearch.Text = "";
            dsearchcategory.SelectedIndex = -1;
            specialty.Text = "";
            Password.Text = "";
        }

        private void InsertDoctor()
        {
            c.Open();

            SqlCommand cm = new SqlCommand(@"INSERT INTO 
                                        doctor (d_id, d_name, d_gender, d_age, qualification,Speciality,salary, d_mobile, d_address, w_no) 
              VALUES ('" + did.Text + "','" + dname.Text + "','" + dgender.Text + "','" + dage.Text + "','" + dq.Text + "','" + specialty.Text + "','" + dsalary.Text + "','" + dmobile.Text + "','" + daddress.Text + "','" + dword.Text + "')", c);
            cm.ExecuteNonQuery();
            c.Close();

            MessageBox.Show("Successfully Added.");
           
        }

        private void AddDataGridViewRows(DataRow item)
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
            dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
            dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter cc = new SqlDataAdapter(" SELECT d_id FROM doctor", c);

            DataTable dw = new DataTable();

            cc.Fill(dw);


            foreach (DataRow item in dw.Rows)
            {

                int n = 0;
                string[] wn = new string[4];
                wn[n] = item[0].ToString();


                if (did.Text == wn[n])
                {
                    MessageBox.Show("Already Exist.\n  Try again");
                    this.Close();
                    doctor d = new doctor();
                    d.Show();
                    st = false;
                }
            }

            if (st)
            {
                if (did.Text == "" || dname.Text == "" || dgender.Text == "" || dage.Text == "" || dq.Text == "" || dsalary.Text == "" || dmobile.Text == "" || daddress.Text == "" || dword.Text == "")
                {
                    MessageBox.Show("Fill all boxes");

                }
                else
                {

                    InsertDoctor();
                    this.Close();
                    doctor d = new doctor();
                    d.Show();
                

                }
                st = false;
            }
        }

 

        private void button3_Click(object sender, EventArgs e)
        {

            RefreshAll();
           
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Main m = new Main();
            m.Show();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try {
                did.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                dname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dgender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dage.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dq.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                specialty.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dsalary.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                dmobile.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                daddress.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                dword.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                Password.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand cm = new SqlCommand(@"UPDATE doctor
              SET  d_id = '" + did.Text + "', d_name = '" + dname.Text + "', d_gender = '" + dgender.Text + "', d_age = '" + dage.Text + "', qualification = '" + dq.Text + "',Speciality = '" + specialty.Text + "', salary = '" + dsalary.Text + "', d_mobile = '" + dmobile.Text + "', d_address = '" + daddress.Text + "', w_no = '" + dword.Text + "',d_password = '" + Password.Text + "' WHERE (d_id = '" + did.Text + "')", c);
            cm.ExecuteNonQuery();
            c.Close();

            MessageBox.Show("Successfully Updated.");
            Display();
        }

        private void doctor_Load(object sender, EventArgs e)
        {

        }

        private void dsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (dsearchcategory.Text)
                {

                    case "Name":

                        searchCommandlabel.Text = "Enter the Name.";
                        if (dsearch.Text == "")
                        {
                            searchCommandlabel.Text = "";
                        }
                        SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM doctor WHERE d_name like ('%" + dsearch.Text + "%')", c);

                        DataTable dt = new DataTable();

                        cm.Fill(dt);

                        dataGridView1.Rows.Clear();

                        foreach (DataRow item in dt.Rows)
                        {
                            AddDataGridViewRows(item);

                        }
                        break;


                    case "ID":
                        searchCommandlabel.Text = "Enter the ID.";
                        if (dsearch.Text == "")
                        {
                            searchCommandlabel.Text = "";
                        }
                        SqlDataAdapter cmid = new SqlDataAdapter("SELECT * FROM doctor WHERE d_id like ('%" + dsearch.Text + "%')", c);

                        DataTable dtid = new DataTable();

                        cmid.Fill(dtid);

                        dataGridView1.Rows.Clear();

                        foreach (DataRow item in dtid.Rows)
                        {
                            AddDataGridViewRows(item);

                        }
                        break;

                    case "Mobile":
                        searchCommandlabel.Text = "Enter the mobile number.";
                        if (dsearch.Text == "")
                        {
                            searchCommandlabel.Text = "";
                        }
                        SqlDataAdapter cmobile = new SqlDataAdapter("SELECT * FROM doctor WHERE d_mobile like ('%" + dsearch.Text + "%')", c);

                        DataTable dtmobile = new DataTable();

                        cmobile.Fill(dtmobile);

                        dataGridView1.Rows.Clear();

                        foreach (DataRow item in dtmobile.Rows)
                        {
                            AddDataGridViewRows(item);

                        }
                        break;

                    case "Gender":
                        searchCommandlabel.Text = "Enter the Gender.";
                        if (dsearch.Text == "")
                        {
                            searchCommandlabel.Text = "";
                        }
                        SqlDataAdapter cg = new SqlDataAdapter("SELECT * FROM doctor WHERE d_gender like ('%" + dsearch.Text + "%')", c);

                        DataTable dg = new DataTable();

                        cg.Fill(dg);

                        dataGridView1.Rows.Clear();

                        foreach (DataRow item in dg.Rows)
                        {
                            AddDataGridViewRows(item);

                        }
                        break;

                    case "Age":
                        searchCommandlabel.Text = "Enter the Age.";
                        if (dsearch.Text == "")
                        {
                            searchCommandlabel.Text = "";
                        }
                        SqlDataAdapter ce = new SqlDataAdapter("SELECT * FROM doctor WHERE d_age like ('%" + dsearch.Text + "%')", c);

                        DataTable de = new DataTable();

                        ce.Fill(de);

                        dataGridView1.Rows.Clear();

                        foreach (DataRow item in de.Rows)
                        {
                            AddDataGridViewRows(item);

                        }
                        break;

                    case "Qualification":
                        searchCommandlabel.Text = "Enter the Qualification.";
                        if (dsearch.Text == "")
                        {
                            searchCommandlabel.Text = "";
                        }
                        SqlDataAdapter cco = new SqlDataAdapter("SELECT * FROM doctor WHERE qualification like ('%" + dsearch.Text + "%')", c);

                        DataTable dco = new DataTable();

                        cco.Fill(dco);

                        dataGridView1.Rows.Clear();

                        foreach (DataRow item in dco.Rows)
                        {
                            AddDataGridViewRows(item);

                        }
                        break;

                    case "Salary >":
                        searchCommandlabel.Text = "Enter the Salary.";
                        if (dsearch.Text != "")
                        {
                            try
                            {
                                searchCommandlabel.Text = "";
                                SqlDataAdapter ccl = new SqlDataAdapter("SELECT * FROM doctor WHERE salary >  ('" + dsearch.Text + "')", c);

                                DataTable dcl = new DataTable();

                                ccl.Fill(dcl);

                                dataGridView1.Rows.Clear();

                                foreach (DataRow item in dcl.Rows)
                                {
                                    AddDataGridViewRows(item);

                                }
                            }


                            catch (Exception ex)
                            {
                                c.Close();
                                MessageBox.Show(ex.Message);
                                this.Show();
                            }
                        }
                        break;

                    case "Salary <":
                        searchCommandlabel.Text = "Enter the Salary.";
                        if (dsearch.Text != "")
                        {
                            try
                            {
                                searchCommandlabel.Text = "";
                                SqlDataAdapter ccl = new SqlDataAdapter("SELECT * FROM doctor WHERE salary <  ('" + dsearch.Text + "')", c);

                                DataTable dcl = new DataTable();

                                ccl.Fill(dcl);

                                dataGridView1.Rows.Clear();

                                foreach (DataRow item in dcl.Rows)
                                {
                                    AddDataGridViewRows(item);

                                }
                            }


                            catch (Exception ex)
                            {
                                c.Close();
                                MessageBox.Show(ex.Message);
                                this.Show();
                            }
                        }
                        break;


                    case "Specialty":
                        searchCommandlabel.Text = "Enter the Specialty.";
                        if (dsearch.Text != "")
                        {
                            try
                            {
                                searchCommandlabel.Text = "";
                                SqlDataAdapter csp = new SqlDataAdapter("SELECT * FROM doctor WHERE Speciality = '" + dsearch.Text + "' ", c);

                                DataTable dsp = new DataTable();

                                csp.Fill(dsp);

                                dataGridView1.Rows.Clear();

                                foreach (DataRow item in dsp.Rows)
                                {
                                    AddDataGridViewRows(item);

                                }
                            }


                            catch (Exception ex)
                            {
                                c.Close();
                                MessageBox.Show(ex.Message);
                                this.Show();
                            }
                        }
                        break;


                    default:
                        searchCommandlabel.Text = "First select a search Catagoy then Type your requirment.";
                        break;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (did.Text == "")
                {
                    MessageBox.Show("Select an id first.");
                }
                else
                {
                    c.Open();
                    SqlCommand cm = new SqlCommand("DELETE  FROM doctor WHERE (d_id = '" + did.Text + "') ", c);
                    cm.ExecuteNonQuery();
                    c.Close();

                    MessageBox.Show("Successfully Deleted.");
                    Display();
                }
            }
            catch (Exception ex)
            {
                c.Close();
                MessageBox.Show(ex.Message);
            }
        }

        

        private void button7_Click_1(object sender, EventArgs e)
        {
            doctorRoom = new DoctorsRoom();
            doctorRoom.Did.Text = did.Text;

            doctorRoom.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreatSchedule = new Schedule();
            CreatSchedule.category.Text = "Doctor";
            CreatSchedule.ID.Text = did.Text;
            CreatSchedule.ShowDialog();
        }

       

        
    }
}
