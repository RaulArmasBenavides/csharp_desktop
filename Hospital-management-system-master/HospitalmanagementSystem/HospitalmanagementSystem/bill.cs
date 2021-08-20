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
    public partial class bill : Form
    {

        SqlConnection c = new SqlConnection(Constantes.RUTA);
        public String User = "";
        
        bool st = true;
        bool idnotFound = true;
        public bool outpatient = false;
        public bill()
        {
            

            InitializeComponent();
            printPreviewControl1.Document = printDocument1;
           
            Display();
            setBillNo();

            doctorCharge.Text = "500";


        }

        void setBillNo()
        {
            int bno = 0;
            SqlDataAdapter sd = new SqlDataAdapter("SELECT Bill_no FROM Inpatientbill", c);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {


                String wn = item[0].ToString();

                bno = Convert.ToInt32(wn);

            }
            bno = bno + 1;
            billno.Text = bno.ToString();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!outpatient)
            {
                label7.Text = "Admit Date :";
                try
                {

                    pname.Text = "";
                    page.Text = "";
                    pgender.Text = "";
                    padmitdate.Text = "";
                    pdischargedate.Text = "";
                    proomcharge.Text = "";
                    pathologyFees.Text = "";
                    doctorCharge.Text = "";
                    others.Text = "";
                    Total.Text = "";

                    if (pid.Text == "")
                    {
                        MessageBox.Show("Load a patient ID first");
                    }
                    else
                    {
                        SqlDataAdapter cm = new SqlDataAdapter(@"SELECT        Inpatient.p_name, Inpatient.p_age, Inpatient.p_gender, Inpatient.admit_date, doctorCheckPatient.discharge_date, room.charge
FROM            Inpatient INNER JOIN
                         doctorCheckPatient ON Inpatient.p_id = doctorCheckPatient.p_id INNER JOIN
                         room ON Inpatient.room_no = room.room_no WHERE (Inpatient.p_id = '" + pid.Text + "')", c);

                        DataTable dt = new DataTable();

                        cm.Fill(dt);



                        foreach (DataRow item in dt.Rows)
                        {


                            pname.Text = item[0].ToString();
                            page.Text = item[1].ToString();
                            pgender.Text = item[2].ToString();
                            padmitdate.Text = item[3].ToString();
                            pdischargedate.Text = item[4].ToString();
                            proomcharge.Text = item[5].ToString();
                            idnotFound = false;
                        }
                        if (idnotFound)
                        {
                            MessageBox.Show("Id is not available.");
                        }
                    }
                    idnotFound = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (outpatient)
            {
                try
                {

                    pname.Text = "";
                    page.Text = "";
                    pgender.Text = "";
                    padmitdate.Text = "";
                    pdischargedate.Text = "";
                    proomcharge.Text = "";
                    pathologyFees.Text = "";
                    doctorCharge.Text = "";
                    others.Text = "";
                    Total.Text = "";

                    if (pid.Text == "")
                    {
                        MessageBox.Show("Load a patient ID first");
                    }
                    else
                    {
                        SqlDataAdapter cm = new SqlDataAdapter(@"SELECT        Outpatient.p_name, Outpatient.p_age, Outpatient.p_gender, appoinment.AppoinmentDate, room.charge
FROM            Outpatient INNER JOIN
                         appoinment ON Outpatient.p_id = appoinment.p_id INNER JOIN
                         room ON Outpatient.room_no = room.room_no WHERE (Outpatient.p_id = '" + pid.Text + "')", c);

                        DataTable dt = new DataTable();

                        cm.Fill(dt);



                        foreach (DataRow item in dt.Rows)
                        {


                            pname.Text = item[0].ToString();
                            page.Text = item[1].ToString();
                            pgender.Text = item[2].ToString();
                            padmitdate.Text = item[3].ToString();
                            pdischargedate.Text = "Null";
                            doctorCharge.Text = item[4].ToString();
                            idnotFound = false;
                        }
                        if (idnotFound)
                        {
                            MessageBox.Show("Id is not available.");
                        }
                    }
                    idnotFound = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bill_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (User)
            {
                case "Admin":

                    this.Close();
                    Main m = new Main();
                     m.Show();
                    break;
                            

                case "Administration":
                    this.Close();
                    Administration a = new Administration();
                    a.Show();

                    break;
            }

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HMSprintPreviewDialog1.Document = printDocument1;
            HMSprintPreviewDialog1.ShowDialog();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Untitled_1;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 35, 0, newImage.Width, newImage.Height);

            e.Graphics.DrawString("Patient ID        :  "+pid.Text, new Font("Arial", 12),Brushes.Black, new Point(35,150));
            e.Graphics.DrawString("Patient Name :  " + pname.Text, new Font("Arial", 12), Brushes.Black, new Point(35, 170));
            e.Graphics.DrawString("  Bill No          :  " + billno.Text, new Font("Arial", 12), Brushes.Black, new Point(400, 150));
            e.Graphics.DrawString("  Date & Time :  " + billdate.Text, new Font("Arial", 12), Brushes.Black, new Point(400, 170));
            e.Graphics.DrawString(line.Text, new Font("Arial", 12), Brushes.BurlyWood, new Point(0, 190));
            e.Graphics.DrawString(line.Text, new Font("Arial", 12), Brushes.BurlyWood, new Point(0, 195));

            e.Graphics.DrawString(line.Text, new Font("Arial", 12), Brushes.Black, new Point(0, 220));
            e.Graphics.DrawString("  Discription ", new Font("Arial", 14), Brushes.Black, new Point(80, 240));
            e.Graphics.DrawString("  Amount ", new Font("Arial", 14), Brushes.Black, new Point(500, 240));
            e.Graphics.DrawString(line.Text, new Font("Arial", 12), Brushes.Black, new Point(0, 250));

            e.Graphics.DrawString("Room Charge  " , new Font("Arial", 12), Brushes.Black, new Point(35, 280));
            e.Graphics.DrawString("Tk. "+ proomcharge.Text, new Font("Arial", 12), Brushes.Black, new Point(520, 280));

            e.Graphics.DrawString("Pathology fee   ", new Font("Arial", 12), Brushes.Black, new Point(35, 310));
            e.Graphics.DrawString("Tk. " + pathologyFees.Text, new Font("Arial", 12), Brushes.Black, new Point(520, 310));

            e.Graphics.DrawString("Doctor fee   ", new Font("Arial", 12), Brushes.Black, new Point(35, 340));
            e.Graphics.DrawString("Tk. " + doctorCharge.Text, new Font("Arial", 12), Brushes.Black, new Point(520, 340));

            e.Graphics.DrawString("Others   ", new Font("Arial", 12), Brushes.Black, new Point(35, 370));
            e.Graphics.DrawString("Tk. " + proomcharge.Text, new Font("Arial", 12), Brushes.Black, new Point(520, 370));


            e.Graphics.DrawString(line.Text, new Font("Arial", 12), Brushes.Blue, new Point(0, 400));
            e.Graphics.DrawString("  Total ", new Font("Arial", 14), Brushes.Brown, new Point(35, 420));
            e.Graphics.DrawString("Tk. " + Total.Text, new Font("Arial", 14), Brushes.Brown, new Point(520, 420));
            e.Graphics.DrawString(line.Text, new Font("Arial", 12), Brushes.Blue, new Point(0, 430));


            Bitmap bmp1 = Properties.Resources.logo_hospital;
            Image newImage1 = bmp1;
            
            e.Graphics.DrawImage(newImage1, 30, 800, newImage.Width, newImage.Height);

        }

        private void button7_Click(object sender, EventArgs e)
        {


            refresh();
            
        }

        private void refresh()
        {
            pid.Text = "";
            pname.Text = "";
            page.Text = "";
            pgender.Text = "";
            padmitdate.Text = "";
            pdischargedate.Text = "";
            proomcharge.Text = "";
            pathologyFees.Text = "";
            doctorCharge.Text = "";
            others.Text = "";
            Total.Text = "";
            setBillNo();
        }
        private void SetZerro()
        {
            if (proomcharge.Text == "")
            {
                proomcharge.Text = "0";
            }
            if (pathologyFees.Text == "")
            {
                pathologyFees.Text = "0";
            }
            if (doctorCharge.Text == "")
            {
                doctorCharge.Text = "0";
            }
            if (others.Text == "")
            {
                others.Text = "0";
            }
        }

        private void proomcharge_TextChanged(object sender, EventArgs e)
        {

           
                SetZerro();
                decimal TotalBill = Convert.ToInt32(proomcharge.Text) + Convert.ToInt32(pathologyFees.Text) + Convert.ToInt32(others.Text) + Convert.ToInt64(doctorCharge.Text);
                Total.Text = TotalBill.ToString();
            
        }

     

        private void pathologyFees_TextChanged(object sender, EventArgs e)
        {
           
             
                SetZerro();
                decimal TotalBill = Convert.ToInt32(proomcharge.Text) + Convert.ToInt32(pathologyFees.Text) + Convert.ToInt32(others.Text) + Convert.ToInt64(doctorCharge.Text);
                Total.Text = TotalBill.ToString();
            
        }

        private void doctorCharge_TextChanged(object sender, EventArgs e)
        {
          
                SetZerro();
                decimal TotalBill = Convert.ToInt32(proomcharge.Text) + Convert.ToInt32(pathologyFees.Text) + Convert.ToInt32(others.Text) + Convert.ToInt64(doctorCharge.Text);
                Total.Text = TotalBill.ToString();
            
               
            
        }

        private void others_TextChanged(object sender, EventArgs e)
        {
                 SetZerro();
                decimal TotalBill = Convert.ToInt32(proomcharge.Text) + Convert.ToInt32(pathologyFees.Text) + Convert.ToInt32(others.Text) + Convert.ToInt64(doctorCharge.Text);
                Total.Text = TotalBill.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        void Display()
        {

            SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM Inpatientbill ", c);

            DataTable dt = new DataTable();

            cm.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
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
                dataGridView1.Rows[n].Cells[11].Value = item[11].ToString();
                dataGridView1.Rows[n].Cells[12].Value = item[12].ToString();
                
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlDataAdapter cc = new SqlDataAdapter(" SELECT Bill_no FROM Inpatientbill", c);

            DataTable dw = new DataTable();

            cc.Fill(dw);


            foreach (DataRow item in dw.Rows)
            {

                int n = 0;
                string[] wn = new string[4];
                wn[n] = item[0].ToString();


                if (pid.Text == wn[n])
                {
                    MessageBox.Show("This is am old bill \n Add new");
                    
                    st = false;
                }
            }

            if (st)
            {
                if (pid.Text == "" || pname.Text == "" || pgender.Text == "" || padmitdate.Text == "" || pdischargedate.Text == "" || proomcharge.Text == "" || pathologyFees.Text == "" || doctorCharge.Text == "" || others.Text == "" || Total.Text == "")
                {
                    MessageBox.Show("Fill all boxes");
                    this.Close();
                    bill b = new bill();
                    b.Show();

                }
                else
                {
                    c.Open();

                    SqlCommand cm = new SqlCommand("INSERT INTO Inpatientbill (Bill_no, bDate, p_id, p_name, p_age, p_gender, admit_date, Discharge_date, Room_Charges, Pathology_fees, Doctor_Fees, Miscellaneous, Total_Amount) VALUES ('" + billno.Text + "','" + billdate.Text + "','" + pid.Text + "','" + pname.Text + "','" + page.Text + "','" + pgender.Text + "','" + padmitdate.Text + "','" + pdischargedate.Text + "','" + proomcharge.Text + "','" + pathologyFees.Text + "','" + doctorCharge.Text + "','" + others.Text + "','" + Total.Text + "')", c);
                    cm.ExecuteNonQuery();
                    c.Close();


                    MessageBox.Show("Successfully Saved.");

                    setBillNo();
                    Display();
                    pid.Text = "";
                    pname.Text = "";
                    page.Text = "";
                    pgender.Text = "";
                    padmitdate.Text = "";
                    pdischargedate.Text = "";
                    proomcharge.Text = "";
                    pathologyFees.Text = "";
                    others.Text = "";
                    doctorCharge.Text = "";
                    Total.Text = "0";
                    
                    st = false;
                }

            }
            
        }

        private void bill_MouseClick(object sender, MouseEventArgs e)
        {
            
            
                
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (pid.Text == "")
            {
                MessageBox.Show("Select an patient's bill information to update");
            }
            else
            {

                c.Open();
                SqlCommand cm = new SqlCommand(@"UPDATE Inpatientbill
              SET Bill_no = '" + billno.Text + "', bDate = '" + billdate.Text + "', p_id = '" + pid.Text + "', p_name = '" + pname.Text + "', p_age = '" + page.Text + "', p_gender = '" + pgender.Text + "', admit_date = '" + padmitdate.Text + "', Discharge_date = '" + pdischargedate.Text + "', Room_Charges = '" + proomcharge.Text + "', Pathology_fees = '" + pathologyFees.Text + "', Doctor_Fees = '" + doctorCharge.Text + "', Miscellaneous = '" + others.Text + "', Total_Amount = '" + Total.Text + "' WHERE (Bill_no  = '" + billno.Text + "')", c);
                cm.ExecuteNonQuery();
                c.Close();

                MessageBox.Show("Successfully Updated.");
                Display();
            }
        }

        private void printPreviewControl3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (pid.Text == "")
            {
                MessageBox.Show("Select an patient's bill information to update");
            }
            else
            {

                c.Open();
                SqlCommand cm = new SqlCommand(@"DELETE FROM Inpatientbill
                    WHERE (Bill_no  = '" + billno.Text + "')", c);
                cm.ExecuteNonQuery();
                c.Close();

                MessageBox.Show("Successfully Updated.");
                Display();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                billno.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                billdate.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                pid.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                pname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                page.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                pgender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                padmitdate.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                pdischargedate.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                proomcharge.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                pathologyFees.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                doctorCharge.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                others.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                Total.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

     

      

       

        

        

        

        
        
    }
}
