using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//en esta capa se crearon las entidades 
namespace com.app.comprobante.entity
{
    public class ActaComprobanteTO
    {
        #region
        public ActaComprobanteTO()
        {
            NumAC = string.Empty;
            RDNum = string.Empty;
            RDFec = DateTime.Today;
            FecFin = DateTime.Today;
            FecIni = DateTime.Today;
            TipoGasto = string.Empty;
            Monto = 0;
            Motivo = string.Empty;
            NumDias = 0;

        }
        #endregion


        public int IdActaCompromiso { get; set; }

        public string NumAC { get; set; }

        public string RDNum { get; set; }

        public DateTime RDFec { get; set; }

        public string TipoGasto { get; set; }

        public decimal Monto { get; set; }

        public string Motivo { get; set; }

        public int NumDias { get; set; }

        public DateTime FecIni { get; set; }

        public DateTime FecFin { get; set; }

        public string Personal { get; set; }

        public int idPersonal { get; set; }

    }
}
