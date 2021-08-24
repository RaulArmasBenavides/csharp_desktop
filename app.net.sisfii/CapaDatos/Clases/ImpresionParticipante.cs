using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appcongreso.Clases
{
    class ImpresionParticipante
    {

        public ImpresionParticipante()
        {
            this.Nombre = string.Empty;
            this.ap_materno = string.Empty;
            this.ap_paterno = string.Empty;
            this.DNI = string.Empty;

        }
        public string Nombre { get; set; }

        public string ap_paterno { get; set; }

        public string ap_materno { get; set; }

        public string DNI { get; set; }
    }
}
