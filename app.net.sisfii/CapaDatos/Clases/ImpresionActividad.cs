using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appcongreso.Clases
{
    public class ImpresionActividad
    {
        public ImpresionActividad()
        {
            this.Nombre = string.Empty;
            this.Descripcion = string.Empty;
        }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

    }
}
