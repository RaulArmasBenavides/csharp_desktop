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
    public partial class DoctorForm : Form
    {
        SqlConnection c = new SqlConnection(Constantes.RUTA);
        patient Inpatient;
        Out_Patient Outpatient;
        
        public String MyID = "";
        public DoctorForm(String id)
        {
            MyID = id;
            InitializeComponent();
        }

        private void patientRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inpatient = new patient();

            Inpatient.ShowDialog();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appoinmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppoinmentList List = new AppoinmentList(MyID);
             
            List.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void inpatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inpatient = new patient();
            Inpatient.Show();
        }

        private void outpaientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Outpatient = new Out_Patient(0,"");
            Outpatient.Show();
        }

        private void dischargePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inpatient = new patient();
            Inpatient.DischargeButton.Enabled = true;
            Inpatient.dateTimePicker2.Enabled = true;
            Inpatient.DoctorId.Text = MyID;
            Inpatient.ShowDialog();
        }
    }
}
