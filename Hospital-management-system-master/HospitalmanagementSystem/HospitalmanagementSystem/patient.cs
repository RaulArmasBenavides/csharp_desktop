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
    public partial class patient : Form
    {
        public String Home = "";
        
        BedSelection bed;
        Add_Doctor AddDoctor;
        String Status = "";
        SqlConnection c = new SqlConnection(@"Data Source=ANUPAM\ANUPAM;Initial Catalog=hospitalManagementSystem;Integrated Security=True");
        bool st = true;
        int IdNo = 100000;
        String Capacity = "";
        public patient()
        {
            
            
            InitializeComponent();
            setPatientId();
            psearchtype.SelectedIndex = 0;
            Display();
            Displayw();
            setWord();
            RoomInfo();
        }

        private void RefreshAll()
        {
            Displayw();
            Display();
            setPatientId();
            pid.Text = "";
            pname.Text = "";
            pgender.SelectedIndex = -1;
            page.Text = "";
            pcity.Text = "";
            pcountry.SelectedIndex = -1;
            pmobile.Text = "";
            pword.SelectedIndex = -1;
            BloodGroup.SelectedIndex = -1;
            admitdate.Text = "";
            psearch.Text = "";
            psearchtype.SelectedIndex = -1;
            proomtype.SelectedIndex = -1;
            psitcharge.SelectedIndex = -1;
            proomno.SelectedIndex = -1;
            gardianMobile.Text = "";
            gardianName.Text = "";
            relation.Text = "";
        }

        void setPatientId()
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT p_id FROM Inpatient", c);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {


                    String wn = item[0].ToString();

                    IdNo = Convert.ToInt32(wn);

                }

                
                    IdNo = IdNo + 1;
                    pid.Text =  IdNo.ToString();
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void setWord()
        {
            SqlDataAdapter sd = new SqlDataAdapter("SELECT W_no FROM Word", c);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            pword.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {


                pword.Items.Add(item[0].ToString());

            }
        }

        private void InsertPatient()
        {
            try
            {
                c.Open();

                SqlCommand cm = new SqlCommand("INSERT INTO Inpatient (p_id, p_name, p_age, p_gender, BoodGroup, city, country, p_mobile, GurdianName, Relation, G_mobile, w_no, admit_date, room_no) VALUES ('" + pid.Text + "','" + pname.Text + "','" + page.Text + "','" + pgender.Text + "','" + BloodGroup.Text + "','" + pcity.Text + "','" + pcountry.Text + "','" + pmobile.Text + "','" + gardianName.Text + "','" + relation.Text + "','" + gardianMobile.Text + "','" + pword.Text + "','" + admitdate.Text + "','" + Convert.ToInt32( proomno.Text) + "')", c);
                cm.ExecuteNonQuery();
                c.Close();


                MessageBox.Show("Successfully Added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdatePatient()
        {
            try
            {
                c.Open();
                SqlCommand cm = new SqlCommand(@"UPDATE       Inpatient
SET                p_id = '" + pid.Text + "', p_name = '" + pname.Text + "', p_age = '" + page.Text + "', p_gender = '" + pgender.Text + "', BoodGroup = '" + BloodGroup.Text + "', city = '" + pcity.Text + "', country = '" + pcountry.Text + "', p_mobile = '" + pmobile.Text + "', GurdianName = '" + gardianName.Text + "', Relation = '" + relation.Text + "', G_mobile = '" + gardianMobile.Text + "', w_no = '" + pword.Text + "', admit_date = '" + admitdate.Text + "', room_no = '" + proomno.Text + "' WHERE (p_id = '" + pid.Text + "')", c);
                cm.ExecuteNonQuery();
                c.Close();

                MessageBox.Show("Successfully Updated.");
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletePatient()
        {

            try
            {
                c.Open();
                SqlCommand cm = new SqlCommand(@"DELETE FROM Inpatient WHERE (p_id = '" + pid.Text + "') ", c);
                cm.ExecuteNonQuery();
                c.Close();

                MessageBox.Show("Successfully Deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RoomInfo()
        {
            try
            {
                
                SqlDataAdapter sd= new SqlDataAdapter(@" SELECT        room_type, charge
FROM            room WHERE (room_no = '" +proomno.Text+"')", c);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                  proomtype.Items.Add(item[0].ToString());
                  int charge = Convert.ToInt32(item[1].ToString());
                  psitcharge.Items.Add ( charge.ToString());
                }
               
                
            }
            catch (Exception ex)
            {
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
            dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();
            dataGridView1.Rows[n].Cells[10].Value = item[10].ToString();
            dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
            dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
            dataGridView1.Rows[n].Cells[13].Value = item[13].ToString();
        }

        void Display()
        {

            SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM Inpatient ", c);

            DataTable dt = new DataTable();

            cm.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                addDataGridViewRows(item);
            }

        }

       

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                pid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                pname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                pgender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                page.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                BloodGroup.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                pcity.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                pcountry.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                pmobile.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                gardianName.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                relation.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                gardianMobile.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                pword.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

                admitdate.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
              
                proomno.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
                
                
            

        }

        void Displayw()
        {

            try
            {
                SqlDataAdapter cm = new SqlDataAdapter(@"SELECT        w_no, room_no, capacity
FROM            room", c);

                DataTable dt = new DataTable();

                cm.Fill(dt);

                dataGridView2.Rows.Clear();
                int freeBeds = 0;
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item[2].ToString();
                     
                    SqlDataAdapter cm1 = new SqlDataAdapter(@"SELECT        COUNT(bed_no) AS TotalBed
FROM            AddBed2
WHERE        (room_no = '"+item[1].ToString()+"') ", c);

                    DataTable dt1 = new DataTable();
                    cm1.Fill(dt1);
                    foreach (DataRow item1 in dt1.Rows)
                    {
                        dataGridView2.Rows[n].Cells[3].Value = item1[0].ToString();
                        
                    }
                    Capacity = dataGridView2.Rows[n].Cells[3].Value.ToString();


                    SqlDataAdapter cm2 = new SqlDataAdapter(@"SELECT        COUNT(p_id) AS TotalBook
FROM            Bed
WHERE        (room_no = '" + item[1].ToString() + "') ", c);

                    DataTable dt2 = new DataTable();
                    cm2.Fill(dt2);
                    foreach (DataRow item2 in dt2.Rows)
                    {
                        String TotalAdded = item2[0].ToString();

                        freeBeds = Convert.ToInt32(Capacity) - Convert.ToInt32(TotalAdded);
                    dataGridView2.Rows[n].Cells[4].Value = freeBeds.ToString();
                        

                    }


                    
                    
                    freeBeds = 0;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter cc = new SqlDataAdapter(" SELECT p_id FROM Inpatient", c);

                DataTable dw = new DataTable();

                cc.Fill(dw);


                foreach (DataRow item in dw.Rows)
                {

                    int n = 0;
                    string[] wn = new string[4];
                    wn[n] = item[0].ToString();


                    if (pid.Text == wn[n])
                    {
                        MessageBox.Show("ID Already used.\n Select another.");

                        st = false;
                    }
                }

                if (st)
                {
                    if (pid.Text == "" || pname.Text == "" || pgender.Text == "" || pcity.Text == "" || pcountry.Text == "" || pmobile.Text == "" || pword.Text == "" || gardianName.Text == "" || admitdate.Text == "" || proomno.Text == "")
                    {
                        MessageBox.Show("Fill all boxes");

                    }
                    else
                    {

                        InsertPatient();

                        Display();
                        Displayw();
                        RefreshAll();
                        st = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (pid.Text == "")
                {
                    MessageBox.Show("Select an patient's information to update");
                }
                else
                {

                    UpdatePatient();
                    Display();
                    Displayw();
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                DeletePatient();
                Display();
                Displayw();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

          

        private void F5_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }    

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Home != "")
            {
                switch (Home)
                {
                    case "Admin":
                        this.Close();
                        Main m = new Main();
                        Home = "";
                         m.Show();
                    break;

                    case "Administration":
                    this.Close();
                    Administration am = new Administration();
                    Home = "";
                    am.Show();
                    break;

                }
            }
        }

        private void psearch_TextChanged(object sender, EventArgs e)
        {
            switch (psearchtype.Text)
            { 
            
                case "Name":
                    SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM Inpatient WHERE p_name like ('%"+psearch.Text+"%')",c);
           
            DataTable dt = new DataTable();

            cm.Fill(dt);

             dataGridView1.Rows.Clear();

            foreach(DataRow item in dt.Rows)
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
            }
                    break;


                case "ID":
                    SqlDataAdapter cmid = new SqlDataAdapter("SELECT * FROM Inpatient WHERE p_id like ('%" + psearch.Text + "%')", c);

                    DataTable dtid = new DataTable();

                    cmid.Fill(dtid);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dtid.Rows)
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
                    }
                    break;

                case "Mobile":
                    SqlDataAdapter cmobile = new SqlDataAdapter("SELECT * FROM Inpatient WHERE p_mobile like ('%" + psearch.Text + "%')", c);

                    DataTable dtmobile = new DataTable();

                    cmobile.Fill(dtmobile);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dtmobile.Rows)
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
                    }
                    break;

                case "Gender":
                    SqlDataAdapter cg = new SqlDataAdapter("SELECT * FROM Inpatient WHERE p_gender like ('%" + psearch.Text + "%')", c);

                    DataTable dg = new DataTable();

                    cg.Fill(dg);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dg.Rows)
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
                    }
                    break;

                case "Age":
                    SqlDataAdapter ce = new SqlDataAdapter("SELECT * FROM Inpatient WHERE p_age like ('%" + psearch.Text + "%')", c);

                    DataTable de = new DataTable();

                    ce.Fill(de);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in de.Rows)
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
                    }
                    break;

                case "Country":
                    SqlDataAdapter cco = new SqlDataAdapter("SELECT * FROM Inpatient WHERE country like ('%" + psearch.Text + "%')", c);

                    DataTable dco = new DataTable();

                    cco.Fill(dco);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dco.Rows)
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
                    }
                    break;

                case "City":
                    SqlDataAdapter cci = new SqlDataAdapter("SELECT * FROM Inpatient WHERE city like ('%" + psearch.Text + "%')", c);

                    DataTable dci = new DataTable();

                    cci.Fill(dci);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dci.Rows)
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
                    }
                    break;


                case "Blood Group":
                    SqlDataAdapter cbg = new SqlDataAdapter("SELECT * FROM Inpatient WHERE BloodGroup like ('%" + psearch.Text + "%')", c);

                    DataTable dbg = new DataTable();

                    cbg.Fill(dbg);

                    dataGridView1.Rows.Clear();

                    foreach (DataRow item in dbg.Rows)
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
                    }
                    break;

            }
        }

        private void proomno_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (proomno.Text != "" && pword.Text != "")
            {
                SqlDataAdapter cm = new SqlDataAdapter(@"SELECT        w_no, room_no, room_type, charge, capacity
FROM            room WHERE (room_no = '" + proomno.Text + "' and w_no = '" + pword.Text + "')", c);

                DataTable dt = new DataTable();

                cm.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    
                    if (pword.Text == item[0].ToString() && proomno.Text == item[1].ToString())
                    {
                        proomtype.Text = item[2].ToString(); 
                        psitcharge.Text = item[3].ToString(); 

                    }
                    else
                    {
                        proomtype.Text = "N/A";
                        psitcharge.Text = "0";
                    }
                }
                
            }
            
        }

        private void SelectBedButton_Click(object sender, EventArgs e)
        {

            bed  = new BedSelection();

            bed.WordNo.Text = pword.Text;
            bed.RoomNo.Text = proomno.Text;
            bed.pid.Text =  pid.Text;

            bed.ShowDialog();
        }

  

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddDoctor = new Add_Doctor();
            AddDoctor.PatientID.Text = pid.Text;
            AddDoctor.doctorWord.Text = pword.Text;
            AddDoctor.ShowDialog();
        }

        private void proomno_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try {
                proomtype.Items.Clear();
                psitcharge.Items.Clear();
                RoomInfo();
                proomtype.SelectedIndex = 0;
                psitcharge.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void patient_Load(object sender, EventArgs e)
        {

        }

        private void FreeBed()
        {
            try
            {
                c.Open();

                SqlCommand cm = new SqlCommand(@"DELETE FROM Bed WHERE(p_id = '"+pid.Text+"')", c);
                cm.ExecuteNonQuery();
                c.Close();


                MessageBox.Show("The bed is free now.");
            }
            catch (Exception ex)
            {
                c.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                c.Open();

                SqlCommand cm = new SqlCommand(@"INSERT INTO doctorCheckPatient
                         (p_id, d_id, discharge_date)
VALUES        ('"+pid.Text+"','"+DoctorId.Text+"','"+dischargeDate.Text+"')", c);
                cm.ExecuteNonQuery();
                c.Close();


                MessageBox.Show("Successfully Discharged.");
                FreeBed();
                Display();
                Displayw();
                Status = "Discharged";
                RefreshAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            admitdate.Text = dateTimePicker2.Text;
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            dischargeDate.Text = dateTimePicker1.Text;
        }

   
    }
}
