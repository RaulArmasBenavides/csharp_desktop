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
    public partial class StuffRegistration : Form
    {

        SqlConnection c = new SqlConnection(Constantes.RUTA);

        
        public StuffRegistration()
        {
            InitializeComponent();
            setStuffId();
            Display();
            setWord();
        }

        void Display()
        {

            SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM stuffs ", c);

            DataTable dt = new DataTable();

            cm.Fill(dt);

            DatagridViewRows(dt);

        }

        private void DatagridViewRows(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }


        void setStuffId()
        {
            int IdNo = 400000;
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT Stuff_id FROM stuffs", c);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {


                    String wn = item[0].ToString();

                    IdNo = Convert.ToInt32(wn);

                }

                IdNo = IdNo + 1;
                id.Text =IdNo.ToString();

                
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

            foreach (DataRow item in dt.Rows)
            {


                stuffWord.Items.Add(item[0].ToString());

            }
        }

        private void RefreshAll()
        {
            
            name.Text = "";
            gender.SelectedIndex = -1;
           
            parmanentAddress.Text = "";
            presentAddress.Text = "";
            mobile.Text = "";
            title.Text = "";
            BloodGroup.SelectedIndex = -1;
            nid.Text = "";
            search.Text = "";
            searchType.SelectedIndex = 0;
            stuffWord.SelectedIndex = -1;
            stuffSalary.Text = "";
            setStuffId();
            Display();
       
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
          
        }

        

        private void InsertStuff()
        {
            try
            {
                c.Open();

                SqlCommand cm = new SqlCommand(@"INSERT INTO stuffs
                         (StuffTitle, Stuff_Id, Stuff_name, Gender, NID, Stuff_PresentAddress, Stuff_ParmanentAddress, Stuff_mobile, Stuff_password, Blood_group,w_no,salary)
VALUES        ('" + title.Text + "','" + id.Text + "','" + name.Text + "','" + gender.Text + "','" + nid.Text + "','" + presentAddress.Text + "','" + parmanentAddress.Text + "','" + mobile.Text + "','" + password.Text + "','" + BloodGroup.Text + "','" + stuffWord.Text + "','" + stuffSalary.Text + "')", c);
                cm.ExecuteNonQuery();
                c.Close();


                MessageBox.Show("Successfully Added.");
            }
            catch (Exception ex)
            {
                c.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateStuff()
        {
            try
            {
                c.Open();
                SqlCommand cm = new SqlCommand(@" UPDATE     stuffs
SET                StuffTitle = '" + title.Text + "' , Stuff_Id = '" + id.Text + "', Stuff_name = '" + name.Text + "', Gender = '" + gender.Text + "', NID = '" + nid.Text + "', Stuff_PresentAddress = '" + presentAddress.Text + "', Stuff_ParmanentAddress = '" + parmanentAddress.Text + "', Stuff_mobile = '" + mobile.Text + "', Stuff_password = '" + password.Text + "', Blood_group = '" + BloodGroup.Text + "',w_no = '" + stuffWord.Text + "',salary = '" + stuffSalary.Text + "' WHERE (Stuff_id = '" + id.Text + "')", c);
                cm.ExecuteNonQuery();
                c.Close();

                MessageBox.Show("Successfully Updated.");
                Display();
            }
            catch (Exception ex)
            {
                c.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteStuff()
        {

            try
            {
                c.Open();
                SqlCommand cm = new SqlCommand(@"DELETE FROM stuffs WHERE (Stuff_id = '" + id.Text + "') ", c);
                cm.ExecuteNonQuery();
                c.Close();

                MessageBox.Show("Successfully Deleted.");
            }
            catch (Exception ex)
            {
                c.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try {

                title.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                id.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                gender.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                nid.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                presentAddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                parmanentAddress.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                mobile.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                password.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                BloodGroup.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                stuffWord.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                stuffSalary.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            switch (searchType.Text)
            {
                case "Title":
                    SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM stuffs WHERE StuffTitle like ('%" + search.Text + "%')", c);

                    DataTable dt = new DataTable();

                    cm.Fill(dt);

                    DatagridViewRows(dt);
                    break;

                case "Name":
                    SqlDataAdapter cm1 = new SqlDataAdapter("SELECT * FROM stuffs WHERE Stuff_name like ('%" + search.Text + "%')", c);

                    DataTable dt1 = new DataTable();

                    cm1.Fill(dt1);

                    DatagridViewRows(dt1);
                    break;


                case "ID":
                    SqlDataAdapter cmid = new SqlDataAdapter("SELECT * FROM stuffs WHERE Stuff_Id like ('%" + search.Text + "%')", c);

                    DataTable dtid = new DataTable();

                    cmid.Fill(dtid);

                    DatagridViewRows(dtid);
                    break;

                

                case "Gender":
                    SqlDataAdapter cg = new SqlDataAdapter("SELECT * FROM stuffs WHERE Gender like ('%" + search.Text + "%')", c);

                    DataTable dg = new DataTable();

                    cg.Fill(dg);

                    DatagridViewRows(dg);
                    break;

                
                

                case "NID":
                    SqlDataAdapter cci = new SqlDataAdapter("SELECT * FROM stuffs WHERE NID like ('%" + search.Text + "%')", c);

                    DataTable dci = new DataTable();

                    cci.Fill(dci);

                    DatagridViewRows(dci);
                    break;


                case "Blood Group":
                    SqlDataAdapter cbg = new SqlDataAdapter("SELECT * FROM stuffs WHERE Blood_group like ('%" + search.Text + "%')", c);

                    DataTable dbg = new DataTable();

                    cbg.Fill(dbg);

                    DatagridViewRows(dbg);
                    break;

                case "Word":
                    SqlDataAdapter cbgw = new SqlDataAdapter("SELECT * FROM stuffs WHERE w_no like ('%" + search.Text + "%')", c);

                    DataTable dbgw = new DataTable();

                    cbgw.Fill(dbgw);

                    DatagridViewRows(dbgw);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertStuff();
            RefreshAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateStuff();
            RefreshAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteStuff();
            RefreshAll();
        }


        private void StuffRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }


    }
}
