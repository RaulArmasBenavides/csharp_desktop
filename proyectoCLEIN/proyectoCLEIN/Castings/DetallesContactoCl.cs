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
    public partial class DetallesContactoCl : Form
    {
        int Id;
        Cliente_Agente c;
        public DetallesContactoCl(int Id, Cliente_Agente c)
        {
            InitializeComponent();
            this.Id = Id;
            this.c = c;
        }

        private void DetallesContactoCl_Load(object sender, EventArgs e)
        {
            MetodosCasting m = new MetodosCasting();
            m.InfoTextBox(Id, idCliente, nombre, apellido, ced);
            idCliente.Enabled = false;
            nombre.Enabled = false;
            apellido.Enabled = false;
            ced.Enabled = false;
        }
    }
}
