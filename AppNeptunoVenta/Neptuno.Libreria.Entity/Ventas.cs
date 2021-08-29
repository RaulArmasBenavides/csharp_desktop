
using System;
using System.Collections.Generic;

namespace Neptuno.Libreria.Entity
{
   public class Ventas
    {
        #region Propidades
        // propiedades
       public int Idventa { get; set; }
       public string IdCliente { get; set; }
       public int IdEmpleado { get; set; }
       public DateTime FechaVenta { get; set; }
       public decimal Monto { get; set; }
       public List<Detalle> Item { get; set; }
       #endregion
    }
}
