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
    public partial class Agente : Form
    {
        public Agente()
        {
            InitializeComponent();
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodosCasting m = new MetodosCasting();

            if (nombre.Text.Length == 0 || apellido.Text.Length == 0 || numEmpleado.Text.Length == 0 || ced.Text.Trim().Length < 16)
            {
                MessageBox.Show("Complete los campos obligatorios", "Lo sentimos...");
                pic1.Visible = true;
                pic2.Visible = true;
                pic3.Visible = true;
                pic4.Visible = true;
            }
            else
            {
                m.GuardarAgente(nombre.Text, apellido.Text, dir.Text, ced.Text, numEmpleado.Text);
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Está seguro que desea deshacer todos los cambios?","",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No){
                  return;
            }
            else
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                nombre.Clear();
                apellido.Clear();
                dir.Clear();
                numEmpleado.Clear();
                ced.Clear();
            }
        }

        private void Agente_Load(object sender, EventArgs e)
        {

        }//


    }
}
