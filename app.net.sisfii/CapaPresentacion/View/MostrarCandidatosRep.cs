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
    public partial class MostrarCandidatosRep : Form
    {
        public MostrarCandidatosRep()
        {
            InitializeComponent();
        }

        private void MostrarCandidatosRep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCasting.MostrarPerfilesReport' table. You can move, or remove it, as needed.
            this.MostrarPerfilesReportTableAdapter.Fill(this.dbCasting.MostrarPerfilesReport);
            // TODO: This line of code loads data into the 'dbCasting.Candidatos' table. You can move, or remove it, as needed.
            this.CandidatosTableAdapter.Fill(this.dbCasting.Candidatos);
            
            this.reportViewer1.RefreshReport();
            reportViewer1.ShowBackButton=true;
        }
    }
}
