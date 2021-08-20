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
    public partial class newpass : Form
    {
        SqlConnection c = new SqlConnection(Constantes.RUTA);
        string NewEmail = "";


        bool notEnd = true;
        string[] fs = new string[4];
        string[] ls = new string[4];
        string[] em = new string[4];
        string[] us = new string[4];
        string[] ps = new string[4];
        

        public newpass(string Email)
        {
            InitializeComponent();
            NewEmail = Email;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (notEnd)
          {
            
                SqlDataAdapter cp = new SqlDataAdapter(@" SELECT        First_name, Last_name, Email, username, passward
FROM            register WHERE (Email = '" + NewEmail + "') ", c);

            DataTable dpt = new DataTable();

            cp.Fill(dpt);


            foreach (DataRow item in dpt.Rows)
            {

                int n = 0;
                
                fs[n] = item[0].ToString();
                ls[n] = item[1].ToString();
                em[n] = item[2].ToString();
                us[n] = item[3].ToString();
                ps[n] = item[4].ToString();


                if (usr.Text == us[n])
                {
                    

                    UpdatePassword(usr.Text);
                    notEnd = false;

                    this.Close();
            Login r = new Login();
            r.Show();

                    break;

                }
                else
                {
                    MessageBox.Show("There some Problems in changing password.");
                    this.Refresh();
               }
               
            }
          }

            
            

        }

        private void UpdatePassword(string user)
        {
            c.Open();
            SqlCommand cm = new SqlCommand(@"UPDATE       register
          SET   username = '" + user + "' ,passward = '" + textBox2.Text + "' WHERE (Email = '" + NewEmail + "')", c);
            cm.ExecuteNonQuery();
            c.Close();

            MessageBox.Show("Password reset successfull.");
        }

        private void newpass_Load(object sender, EventArgs e)
        {

        }
    }
}
