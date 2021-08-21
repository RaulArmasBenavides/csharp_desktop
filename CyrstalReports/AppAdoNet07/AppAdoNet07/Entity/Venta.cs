using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdoNet07.Entity
{
    public class Venta
    {
        // propiedades
        public int IdVenta { get; set; }
        public string IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public List<Detalle> Item { get; set; }
    }
}
