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
    public partial class CastingRegistro : Form
    {
        int IdAgente;
        int IdCliente;

        public CastingRegistro(int IdCliente, int IdAgente)
        {
            InitializeComponent();
            this.IdCliente = IdCliente;
            this.IdAgente = IdAgente;
        }

        public CastingRegistro() { }

        private void CastingRegistro_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToString();
            maskedTextBox1.Enabled = false;
            nper.Value = 1;
            nombre.MaxLength = 28;
            descrip.MaxLength = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MetodosCasting m = new MetodosCasting();
            if (nombre.Text.Length == 0 || descrip.Text.Length == 0 || coste.Text.Length == 0 || nper.Value == 0)
            {
                MessageBox.Show("Complete toda la información antes de registrar");
            }
            else
            {
             m.GuardarCasting(IdCliente, IdAgente, nombre.Text, descrip.Text, Convert.ToDouble(coste.Text), Convert.ToInt32(nper.Value));
             this.Dispose();
            }
        }

        private void nper_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char caracter = e.KeyChar;
            if (Char.IsDigit(e.KeyChar))
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
        }

        private void coste_KeyPress(object sender, KeyPressEventArgs e)
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
        }
    }
}
