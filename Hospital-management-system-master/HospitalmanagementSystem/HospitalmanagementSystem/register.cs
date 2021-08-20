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
    public partial class register : Form
    {
        SqlConnection c = new SqlConnection(Constantes.RUTA);
        
        bool IdMatched = false;
        public register()
        {
            InitializeComponent();
        }

        private void Resister()
        {
            try
            {
                if (registerPassword.Text == confirmRegisterPassword.Text)
                {
                    c.Open();
                    SqlCommand cm = new SqlCommand(@"INSERT INTO register
                         (Category, Id, First_name, Last_name, Email, username, passward)
VALUES        ('" + registerCategory.Text + "','" + registerId.Text + "','" + firstName.Text + "','" + lastName.Text + "','" + registerEmail.Text + "','" + registerUsername.Text + "','" + confirmRegisterPassword.Text + "')", c);

                    cm.ExecuteNonQuery();
                    c.Close();
                    MessageBox.Show("Registration Successfull.");

                    updatePassword(registerCategory.Text, registerId.Text, confirmRegisterPassword.Text);
                    this.Close();
                    Login r = new Login();
                    r.Show();
                }
                else
                {
                    MessageBox.Show("Passward does mot mach.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matchID()
        {
            switch (registerCategory.Text)
            {

                case "Admin":

                     SqlDataAdapter cp = new SqlDataAdapter(" SELECT ID FROM admin_ID", c);

                        DataTable dpt = new DataTable();

                         cp.Fill(dpt);


                        foreach (DataRow item in dpt.Rows)
                         {

                 
                           if (registerId.Text == item[0].ToString())
                            {
                            IdMatched = true;
                            break;


                            }

                        }
           
                    
                    break;

                case "Administration":

                    SqlDataAdapter cpa = new SqlDataAdapter(" SELECT ID FROM administration", c);

                    DataTable dpta = new DataTable();

                    cpa.Fill(dpta);


                    foreach (DataRow item in dpta.Rows)
                    {


                        if (registerId.Text == item[0].ToString())
                        {
                            IdMatched = true;
                            break;


                        }

                    }


                    break;


                case "Stuff":

                    SqlDataAdapter cps = new SqlDataAdapter(" SELECT Stuff_Id FROM stuffs", c);

                    DataTable dpts = new DataTable();

                    cps.Fill(dpts);


                    foreach (DataRow item in dpts.Rows)
                    {


                        if (registerId.Text == item[0].ToString())
                        {
                            IdMatched = true;
                            break;


                        }

                    }


                    break;

                case "Doctor":

                    SqlDataAdapter cpd = new SqlDataAdapter(" SELECT d_id FROM doctor", c);

                    DataTable dptd = new DataTable();

                    cpd.Fill(dptd);


                    foreach (DataRow item in dptd.Rows)
                    {


                        if (registerId.Text == item[0].ToString())
                        {
                            IdMatched = true;
                            break;


                        }

                    }


                    break;


               


                default: MessageBox.Show("Select User Category first \n or you do not have parmission");

                    break;



            }
  

        }


        public void updatePassword(String Category, String Id, String Password)
        {
           
                String category = Category;
                String ID = Id;
                String password = Password;

                switch (category)
                {

                    //
                    //Receptionist
                    //Stuff

                    case "Doctor":

                        try
                        {
                            c.Open();
                            SqlCommand cm = new SqlCommand(@"UPDATE       doctor
                            SET   d_password = '" + password + "' WHERE (d_id = '" + ID + "') ", c);

                            cm.ExecuteNonQuery();
                            c.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;



                    case "Nourse":

                        try
                        {
                            c.Open();
                            SqlCommand cm = new SqlCommand(@"UPDATE       nourse
                            SET   n_password = '" + password + "' WHERE (n_id = '" + ID + "') ", c);

                            cm.ExecuteNonQuery();
                            c.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                    case "Admin":

                        try
                        {
                            c.Open();
                            SqlCommand cm = new SqlCommand(@"UPDATE       admin_ID
                            SET   password = '" + password + "' WHERE (ID = '" + ID + "') ", c);

                            cm.ExecuteNonQuery();
                            c.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;


                    case "Administration":

                        try
                        {
                            c.Open();
                            SqlCommand cm = new SqlCommand(@"UPDATE       administration
                            SET   password = '" + password + "' WHERE (ID = '" + ID + "') ", c);

                            cm.ExecuteNonQuery();
                            c.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                    case "Stuff":

                        try
                        {
                            c.Open();
                            SqlCommand cm = new SqlCommand(@"UPDATE       stuffs
                            SET   Stuff_password = '" + password + "' WHERE (Stuff_Id = '" + ID + "') ", c);

                            cm.ExecuteNonQuery();
                            c.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;


                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                   if(registerCategory.Text != "" && registerId.Text != "")
                   {
                       matchID();
                       Resister();
                //    if (IdMatched)
                //{
                //    Resister();

                //}
                //else
                //{
                //    MessageBox.Show("You do not have permission");
                //}


            }

                   else
                   {
                    MessageBox.Show("Select User Category first and Enter your ID.");
                   }
   

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login r = new Login();
            r.Show();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
    
}
