using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno.Libreria.Entity
{
    public class Empleado
    {
        #region Propiedades
        public int IdEmpleado { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }

        #endregion
    }
}
