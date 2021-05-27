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
    public partial class Cliente_Agente : Form
    {
        int IdCliente;
        int IdAgente;
        ContratarCasting casting;

        public Cliente_Agente(int IdCliente, int IdAgente)
        {
            InitializeComponent();
            this.IdCliente = IdCliente;
            this.IdAgente = IdAgente;
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Cliente_Agente_Load(object sender, EventArgs e)
        {
            MetodosCasting m = new MetodosCasting();
            LoadData();
            m.LlenarCliente(IdCliente, textBox1, textBox2, textBox3, textBox4);
            m.LlenarAgente(IdAgente, textBox7, textBox8, textBox9, textBox10);
            
        }

        public void LoadData()
        {
            textBox5.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox5.Text = IdCliente.ToString();
            textBox6.Text = IdAgente.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea regresar al formulario anterior?","", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Dispose();
                casting = new ContratarCasting();
                casting.MdiParent = this.MdiParent;
                casting.Show();
            }//
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            CastingRegistro c = new CastingRegistro(IdCliente, IdAgente);
            c.MdiParent = this.MdiParent;
            c.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int IdCliente = Convert.ToInt32(textBox5.Text);
            DetallesContactoCl c = new DetallesContactoCl(IdCliente, this);
            c.MdiParent = this.MdiParent;
            c.Show();
        }//


    }
}
