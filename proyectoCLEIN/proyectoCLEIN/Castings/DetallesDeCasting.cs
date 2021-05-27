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
    public partial class DetallesDeCasting : Form
    {
        int Id;
        verCastings v;
        public DetallesDeCasting(int Id, verCastings v)
        {
            InitializeComponent();
            this.Id = Id;
            this.v = v;
             MetodosCasting m = new MetodosCasting();
             m.MostrarDetalles(Id, nombre, dir, tipo, tel, numEmp, ced, agente, agenteApellido, dirAgente);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DetallesDeCasting_Load(object sender, EventArgs e)
        {
            nombre.Enabled = false;
            dir.Enabled = false;
            tipo.Enabled = false;
            tel.Enabled = false;
            numEmp.Enabled = false;
            ced.Enabled = false;
            agente.Enabled = false;
            agenteApellido.Enabled = false;
            dirAgente.Enabled = false;

        }
    }
}
