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
    public partial class EditarCasting : Form
    {
        int IdCasting;
        verCastings v;
        public EditarCasting(int IdCasting, verCastings v)
        {
            InitializeComponent();
            this.IdCasting = IdCasting;
            this.v = v;
        }

        private void EditarCasting_Load(object sender, EventArgs e)
        {
            nombre.Enabled = false;
            desc.Enabled = false;
            Coste.Enabled = false;
            MetodosNav m = new MetodosNav();
            m.MostrarDetCasting(IdCasting, nombre, desc, Coste);
            desc.MaxLength = 100;
            Coste.MaxLength = 8;
            nombre.MaxLength = 30;

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            MetodosNav m = new MetodosNav();
            if(nombre.Text.Length==0 || desc.Text.Length==0 || Coste.Text.Length==0){}else{

            if (m.ActualizarCasting(IdCasting, nombre.Text, desc.Text, Convert.ToDouble(Coste.Text)) == true)
            {
                this.Hide();

            }
            else if (m.ActualizarCasting(IdCasting, nombre.Text, desc.Text, Convert.ToDouble(Coste.Text)) == false)
            {
                return;

            }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { nombre.Enabled = true; } else { nombre.Enabled = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { desc.Enabled = true; } else { desc.Enabled = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { Coste.Enabled = true; } else { Coste.Enabled = false; }
        }

        private void Coste_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char caracter = e.KeyChar;
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (caracter == '.')
            {
                e.Handled = false;

            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }//
    }
}
