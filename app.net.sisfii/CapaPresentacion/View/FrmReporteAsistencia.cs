using appcongreso.EF;
using appcongreso.Reportes;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.View
{
    public partial class FrmReporteAsistencia : Form
    {
        string _codigo;
        private ReportDocument RD = new ReportDocument();
        private ParameterDiscreteValue parameterDV = new ParameterDiscreteValue();
        public FrmReporteAsistencia(string Codigo)
        {
            InitializeComponent();
            _codigo = Codigo;
            txtCodigo.Text = _codigo;
        }

        private void FrmReporteAsistencia_Load(object sender, EventArgs e)
        {
            try
            {
                string ruta = @"C:\Users\RAUL\Desktop\app.net.sisfii\CapaDatos\Reportes\ReportAsistencias.rpt";
                RD.Load(ruta);
                RD.DataSourceConnections[0].SetConnection("DESKTOP-7POB2NJ", "bdcongreso",true);
                parameterDV.Value = _codigo;
                RD.SetParameterValue("@codigo", parameterDV);
                cvt.ReportSource = RD;
                //ReportViewerAsisntecia.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReportViewerAsistencia_Load(object sender, EventArgs e)
        {

        }
    }
}
