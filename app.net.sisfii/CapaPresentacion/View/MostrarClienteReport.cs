using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting.Reportes
{
    public partial class MostrarClienteReport : Form
    {
        public MostrarClienteReport()
        {
            InitializeComponent();
        }

        private void MostrarClienteReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCasting.ReporteClienteAct' table. You can move, or remove it, as needed.
            this.ReporteClienteActTableAdapter.Fill(this.dbCasting.ReporteClienteAct);
            // TODO: This line of code loads data into the 'dbCasting.Clientes' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
