using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appcongreso.Clases
{
    public class ImpresionSala
    {

        public ImpresionSala()
        {
            this.Codigo = string.Empty;
            this.Ubicacion = string.Empty;
            this.Capacidad = 0;
        }
        public string Codigo { get; set; }
        public string Ubicacion { get; set; }

        public int Capacidad { get; set; }
    }
}
