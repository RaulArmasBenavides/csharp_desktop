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
    public partial class reset : Form
    {


        SqlConnection c = new SqlConnection(@"Data Source=ANUPAM\ANUPAM;Initial Catalog=hospitalManagementSystem;Integrated Security=True");
        bool st = false;
        string[] em = new string[4];
        public reset()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter cp = new SqlDataAdapter(@" SELECT   Email
FROM         register", c);

                DataTable dpt = new DataTable();

                cp.Fill(dpt);


                foreach (DataRow item in dpt.Rows)
                {

                    int n = 0;
                    
                    em[n] = item[0].ToString();



                    if (textBox1.Text == em[n])
                    {
                        st = true;
                        break;

                    }

                }

                if (st)
                {

                    this.Hide();
                    newpass n = new newpass(textBox1.Text);
                    n.Show();
                }
                else
                {
                    MessageBox.Show("Sorry this Email is not Exist.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login r = new Login();
            r.Show();
        }

        private void reset_Load(object sender, EventArgs e)
        {

        }
    }
}
