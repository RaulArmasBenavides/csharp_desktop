using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting.Castings
{
    public partial class verCastings : Form
    {
        MetodosCasting m;
        public verCastings()
        {
            InitializeComponent();
        }

        private void verCastings_Load(object sender, EventArgs e)
        {
            m = new MetodosCasting();
            m.VerCastings(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
                     
            }
            catch
            {
                MessageBox.Show("Elija a alguien de la tabla");
                return;
            }

            int id=(int)dataGridView1[7, pos].Value;
            Fases f = new Fases(id, this);
            f.MdiParent = this.MdiParent;
            f.Show();    
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try {
                pos = dataGridView1.CurrentCell.RowIndex;
                int v = (int)dataGridView1[5, pos].Value;
                MessageBox.Show(""+v);
                DetallesDeCasting d = new DetallesDeCasting(v, this);
                d.MdiParent = this.MdiParent;
                d.Show();
            }
            catch { MessageBox.Show("Seleccione un casting primero"); }


        }

        private void button3_Click(object sender, EventArgs e)
        {      }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;

            }
            catch
            {
                MessageBox.Show("Elija a alguien de la tabla");
                return;
            }

            int Id = (int)dataGridView1[7, pos].Value;
            Pruebas p = new Pruebas(Id, this);
            p.MdiParent = this.MdiParent;
            p.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
                m = new MetodosCasting();
                m.VerCastings(dataGridView1);
                return;
            }
            else
            {
                String Cad = "%"+textBox1.Text+"%";

                if (comboBox1.SelectedIndex == 0)
                {
                    String Query = "SELECT *FROM VistaCasting WHERE [Nombre] like '" +Cad+ "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(Query, dataGridView1);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    String Query = "SELECT *FROM VistaCasting WHERE [Costo] like '" +Cad+ "'";
                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(Query, dataGridView1);
                }
             
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
                int v = (int)dataGridView1[5, pos].Value;
               
                EditarCasting cast= new EditarCasting(v, this);
                cast.MdiParent = this.MdiParent;
                cast.Show();
            }
            catch { MessageBox.Show("Seleccione un casting primero"); }

        }//
    }
}
