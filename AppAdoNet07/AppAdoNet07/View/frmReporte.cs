using AppAdoNet07.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdoNet07.View
{
    public partial class frmReporte : Form
    {
        int nFact;

        public frmReporte(int nro)
        {
            InitializeComponent();
            nFact = nro;
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            try
            {

            FacturaVenta f1 = new FacturaVenta();
            crvFactura.SelectionFormula = "{Pedidos.IdPedido}=" + nFact;
            crvFactura.ReportSource = f1;
            crvFactura.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
