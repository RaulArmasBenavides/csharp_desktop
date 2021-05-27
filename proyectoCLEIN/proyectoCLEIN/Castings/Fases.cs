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
    public partial class Fases : Form
    {
        int Id;
        verCastings v;
        MetodosCasting m;

        public Fases(int Id, verCastings v)
        {
            InitializeComponent();
            this.Id = Id;
            this.v = v;
        }

        private void Fases_Load(object sender, EventArgs e)
        {
            m = new MetodosCasting();
            m.MostrarFase(Id, textBox1);
            textBox1.Enabled = false;
            maskedTextBox1.Enabled = false;
            maskedTextBox1.Text = DateTime.Now.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = new MetodosCasting();
            m.GuardarFase(Id, Convert.ToInt32(textBox1.Text));
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Pruebas p = new Pruebas(Id, this);
            p.MdiParent = this.MdiParent;
            p.Show();
        }


    }
}
