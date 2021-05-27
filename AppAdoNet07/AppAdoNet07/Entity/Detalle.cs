using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdoNet07.Entity
{
    public class Detalle
    {
        // propiedades
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int Descuento { get; set; }
    }
}
