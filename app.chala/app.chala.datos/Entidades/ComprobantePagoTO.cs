using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.app.comprobante.entity
{
    public class ComprobantePagoTO
    {

        public ComprobantePagoTO()
        {
            this.IdCPago = 0;
            this.Serie = string.Empty;
            this.TasaCambio = 0;
            this.TipoCP = string.Empty;

        }


        public int IdCPago { get; set; }

        public string RUC { get; set; }

        public string RazSoc { get; set; }

        public DateTime FecEmision { get; set; }

        public string TipoCP { get; set; }

        public string Serie { get; set; }

        public string Numero { get; set; }

        public string TipoMoneda { get; set; }

        public decimal TasaCambio { get; set; }

        public DateTime FecTCambio { get; set; }

        public decimal MontoUSD { get; set; }

        public decimal MontoSoles { get; set; }


    }
}
