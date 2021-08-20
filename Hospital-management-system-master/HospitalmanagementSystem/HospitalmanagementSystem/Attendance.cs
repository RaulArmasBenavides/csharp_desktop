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
    public partial class Attendance : Form
    {
        SqlConnection c = new SqlConnection(Constantes.RUTA);
        
        public Attendance()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter(@"SELECT        category, ID, LogInDate, LogInTime, LogOutTime
FROM            attendance WHERE(category = '" + category.Text + "')", c);

                DataTable dt = new DataTable();
                sd.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();

                    if (item[2].ToString() != "")
                    {
                        
                        dataGridView1.Rows[n].Cells[4].Value = "Active";

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Text;
        }

        private void searchCategory_TextChanged(object sender, EventArgs e)
        {
            if (searchCategory.Text == "Date")
            {
                dateTimePicker1.Show();
            }
            else
            {
                dateTimePicker1.Hide();
            }
        }

        private void Attendance_Load(object sender, EventArgs e)
        {

        }

        
    }
}
