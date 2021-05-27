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
    public partial class Pruebas : Form
    {

        MetodosCasting m;
        int Id;
        Fases f;
        verCastings v;
        public Pruebas(int Id, Fases f)
        {
            InitializeComponent();
            this.Id = Id;
            this.f = f;
        }

        public Pruebas(int Id, verCastings v){
            InitializeComponent();
            this.Id = Id;
            this.v= v;
    }

        private void Pruebas_Load(object sender, EventArgs e)
        {
            m = new MetodosCasting();
            m.MostrarFase(Id, dataGridView1);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos = 0;

            try {

                pos = dataGridView1.CurrentCell.RowIndex;
                int d = (int)dataGridView1[2, pos].Value;
                
                AgregarPruebas a = new AgregarPruebas(d, this);
                a.MdiParent = this.MdiParent;
                a.Show();
            }
            catch { MessageBox.Show("Primero seleccione a alguien de la tabla"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
                int d = (int)dataGridView1[2, pos].Value;

                verPruebas a = new verPruebas(d, this);
                a.MdiParent = this.MdiParent;
                a.Show();
                this.Hide();
            }
            catch { MessageBox.Show("Primero seleccione a alguien de la tabla"); }

        }
    }
}
