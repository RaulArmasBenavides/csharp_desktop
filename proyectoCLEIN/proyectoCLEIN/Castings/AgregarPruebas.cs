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
    public partial class AgregarPruebas : Form
    {

        int Id;
        Pruebas p;
        public AgregarPruebas(int Id, Pruebas p)
        {
            InitializeComponent();
            this.Id = Id;
            this.p = p;
        }

        private void AgregarPruebas_Load(object sender, EventArgs e)
        {
            MessageBox.Show(""+Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodosCasting m = new MetodosCasting();
            if (sala.Text.Length == 0 || descrip.Text.Length == 0)
            {
                MessageBox.Show("Complete la información de los campos","", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m.GuardarPrueba(Id, sala.Text, descrip.Text, maskedTextBox1.Text);
                this.Dispose();
            }
        }
    }
}
