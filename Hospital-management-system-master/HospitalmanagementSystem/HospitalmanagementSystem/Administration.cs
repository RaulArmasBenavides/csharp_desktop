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
    
    public partial class Administration : Form
    {

        SqlConnection c = new SqlConnection(Constantes.RUTA);
        Timer t = new Timer();
        patient patientAdministration;
        bill InpatientBill;
        bill OutpatientBill;
        StuffRegistration stuff;
        Attandance StuffAttendance;
        public Administration()
        {
            InitializeComponent();
        }

        void UpdateLogOut()
        {
            c.Open();
            SqlCommand cm = new SqlCommand(@"UPDATE       attendance
SET                LogOutTime = '" + timeLabel.Text + AmPm.Text + "' WHERE (Category = '" + "Administration" + "' && ID = '" + GetIdLebel.Text + "' && LogInTime = '" + getLoginTimeLebel.Text + "' ) ", c);
            cm.ExecuteNonQuery();
            c.Close();
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

       

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            word w = new word();
            this.Hide();
            w.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            room r = new room();
            this.Hide();
            r.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBed ab = new AddBed();
            ab.ShowDialog();
        }

        private void inpatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientAdministration = new patient();
            patientAdministration.Home = "Administration";
            patientAdministration.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateLogOut();
            this.Close();
            
            Login l = new Login();
            l.Show();
        }

        private void checkStatusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BedSelection b = new BedSelection();
            b.ShowDialog();
        }

        private void outpatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Out_Patient p = new Out_Patient(0,"");
            p.ShowDialog();
        }

        
        private void inpatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InpatientBill = new bill();
            InpatientBill.ShowDialog();
        }

        private void stuffRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stuff = new StuffRegistration();
            stuff.ShowDialog();
        }

        private void stuffAttandanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StuffAttendance = new Attandance();
            StuffAttendance.ShowDialog();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void outpatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OutpatientBill = new bill();
            OutpatientBill.PatientCateogtyLeble.Text = " Outpatient's Bill";
            OutpatientBill.proomcharge.Text = "0";
            OutpatientBill.outpatient = true;
            OutpatientBill.label7.Text = "Appoinment Date :";
            OutpatientBill.ShowDialog();
        }

        

        
       
        

        
    }
}
