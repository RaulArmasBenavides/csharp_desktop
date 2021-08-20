using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo07.Entity
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public string IdProveedor { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public List<Detalle> Item { get; set; }
    }
}
