using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestauranteDL
{
    public class Movimiento
    {
        public Movimiento()
        {
            this.Concepto = string.Empty;
            //this.Descripcion = string.Empty;
            this.Fecha = string.Empty;
            this.Mes = string.Empty;
            this.Monto = 0;
            this.SubTipo = string.Empty;
            this.Tipo = string.Empty;

        }

        public int idMovimiento { get; set; }
        public string Concepto { get; set; }

        public string Tipo { get; set; }
        public string SubTipo { get; set; }

        public string Fecha { get; set; }
       // public string Descripcion { get; set; }


        public decimal Monto { get; set; }
        public string Mes { get; set; }
  
    }
}
