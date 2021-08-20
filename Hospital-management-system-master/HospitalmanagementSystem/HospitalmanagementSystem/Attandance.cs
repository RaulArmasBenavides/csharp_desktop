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
    public partial class Attandance : Form
    {
        SqlConnection c = new SqlConnection(Constantes.RUTA);
        public Attandance()
        {
            InitializeComponent();
            Display();
        }

        void Display()
        {

            SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM attendance ", c);

            DataTable dt = new DataTable();

            cm.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                AddDataGridViewRows(item);

            }

        }

        private void AddDataGridViewRows(DataRow item)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
            dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
            dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
            dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (category.Text)
                {

                    case "Category":


                        SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM attendance  WHERE category like ('%" + search.Text + "%')", c);

                        DataTable dt = new DataTable();

                        cm.Fill(dt);

                        dataGridView1.Rows.Clear();

                        foreach (DataRow item in dt.Rows)
                        {
                            AddDataGridViewRows(item);

                        }
                        break;


                    case "ID":

                        SqlDataAdapter cmid = new SqlDataAdapter("SELECT * FROM attendance  WHERE ID Like('%" + search.Text + "%')", c);

                        DataTable dtid = new DataTable();

                        cmid.Fill(dtid);

                        dataGridView1.Rows.Clear();

                        foreach (DataRow item in dtid.Rows)
                        {
                            AddDataGridViewRows(item);

                        }
                        break;


                    case "Date":

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM attendance  WHERE LogInDate Like ('%" + search.Text + "%')", c);

                        DataTable dtd = new DataTable();

                        cmd.Fill(dtd);

                        dataGridView1.Rows.Clear();

                        foreach (DataRow item in dtd.Rows)
                        {
                            AddDataGridViewRows(item);

                        }
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Attandance_Load(object sender, EventArgs e)
        {

        }
    }
}
