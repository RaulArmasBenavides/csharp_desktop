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
    public partial class verPruebas : Form
    {
        Pruebas p;
        int Id;
        public verPruebas(int Id, Pruebas p)
        {
            InitializeComponent();
            this.Id = Id;
            this.p = p;
            
        }

        private void verPruebas_Load(object sender, EventArgs e)
        {
            MetodosCasting m = new MetodosCasting();
            m.MostrarPruebas(Id, dataGridView1);
            Estado.Text ="Id de fase: "+ Id.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
                int idPrueba = (int)dataGridView1[0, pos].Value;
                

                ResultadosPrueba ed = new ResultadosPrueba(idPrueba, this);
                ed.MdiParent = this.MdiParent;
                ed.Show();
                this.Hide();

            }
            catch { MessageBox.Show("Primero seleccione a una de la tabla"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
                int idPrueba = (int)dataGridView1[0, pos].Value;
                ResultadosCandidatos rc = new ResultadosCandidatos(idPrueba, this);
                rc.MdiParent = this.MdiParent;
                rc.Show();
                this.Hide();
            }
            catch { 
                MessageBox.Show("Primero seleccione a alguien de la tabla"); 
            }
           
        }
    }
}
