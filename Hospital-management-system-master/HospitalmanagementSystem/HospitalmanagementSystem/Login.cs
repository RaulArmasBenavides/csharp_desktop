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

    public partial class Login : Form
    {
        SqlConnection c = new SqlConnection(Constantes.RUTA);
        Timer t = new Timer();
        Administration administrator;
        DoctorForm doctor;
        String GetId = "";
        String ID = "";
        String GetPassword = "";
        String wn = "";

        bool t1 = false;
        bool t2 = false;


        public Login()
        {

            InitializeComponent();
            getID();
            

        }

        

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            if (hh > 12)
            {
                hh = hh - 12;
                AmPm.Text = "Pm";
            }
            else
            {
                AmPm.Text = "Am";
            }

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }



            timeLabel.Text = time;
        }



        private void Login_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void getID()
        {
            

            SqlDataAdapter cr = new SqlDataAdapter(" SELECT Id FROM register WHERE( username = 'rarmas')", c);

            DataTable drt = new DataTable();

            cr.Fill(drt);


            foreach (DataRow item in drt.Rows)
            {

                ID = item[0].ToString();

            }


        }

        private void MatchUsername()
        {
            SqlDataAdapter cr = new SqlDataAdapter(" SELECT username FROM register WHERE( Category = '"+Category.Text+"')", c);

            DataTable drt = new DataTable();

            cr.Fill(drt);


            foreach (DataRow item in drt.Rows)
            {
              
                wn = item[0].ToString();

            }
                if (username.Text == wn)
                {
                    t1 = true;
                    

                }

            
        }

        private void MatchPassword()
        {
            SqlDataAdapter cp = new SqlDataAdapter(" SELECT passward FROM register WHERE( Category = '" + Category.Text + "')", c);

            DataTable dpt = new DataTable();

            cp.Fill(dpt);


            foreach (DataRow item in dpt.Rows)
            {

                GetPassword = item[0].ToString();

            }
                if (password.Text == GetPassword)
                {
                    t2 = true;
                    

                }

            
        }

        void GetAttandance()
        {

            try
            {
                SqlDataAdapter cm1 = new SqlDataAdapter(@"SELECT Id FROM register WHERE (username = '" + username.Text + "')", c);

                DataTable dt = new DataTable();
                cm1.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    GetId = item[0].ToString();
                }

                c.Open();
                SqlCommand cm = new SqlCommand(@"INSERT INTO attendance
                         (category, ID, LogInDate, LogInTime, LogOutTime)
VALUES        ('" + Category.Text + "','" + GetId + "','" + dateTimePicker1.Text + "','" + timeLabel.Text + "','" + "Null" + "')", c);
                cm.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                

                MatchUsername();

                MatchPassword();
                

                if (t1 && t2)
                {
                    switch (Category.Text) 
                    {
                        case "Admin":
                            
                            this.Hide();
                            Main m = new Main();
                            m.Show();
                            
                            break;


                        case "Administration":
                           
                            this.Hide();
                            GetAttandance();
                            administrator = new Administration();
                            administrator.GetIdLebel.Text = GetId;
                            administrator.getLoginTimeLebel.Text = timeLabel.Text+AmPm.Text;
                            administrator.Show();
                            
                            break;

                        case "Doctor":
                            getID();
                            GetAttandance();
                            
                            doctor = new DoctorForm(ID);
                            
                            this.Hide();
                            doctor.Show();

                            break;


                        default : MessageBox.Show("Select User Category first.");
                            break;


                    }
                    
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password \n or you are not registerd.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            reset r = new reset();
            r.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            register r = new register();
            r.Show();
        }

        


    }
}
