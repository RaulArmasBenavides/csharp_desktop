using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno.Libreria.Entity
{
    public class Cliente
    {
        #region Propiedades
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        #endregion
    }
}
