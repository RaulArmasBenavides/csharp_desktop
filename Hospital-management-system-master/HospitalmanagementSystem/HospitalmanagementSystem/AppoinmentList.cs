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
    public partial class AppoinmentList : Form
    {
        SqlConnection c = new SqlConnection(Constantes.RUTA);
        public String Did = "";
        String date = (DateTime.Today).ToString();
        public AppoinmentList( String id)
        {
            InitializeComponent();
            Did = id;
            Display();
        }

        void Display()
        {
            SqlDataAdapter sd = new SqlDataAdapter(@"SELECT  tokenNo, p_id, AppoinmentDate, roomNo
FROM            appoinment WHERE(d_id = '"+Did+"')",c);

            DataTable dt = new DataTable();

            sd.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void checkInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Out_Patient op = new Out_Patient(1,dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            
            op.ShowDialog();

        }
    }
}
