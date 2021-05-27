using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo03.Entity
{
    public class EmpleadoTO
    {
        // propiedades
        public int IdEmpleado { get; set; }
        public string Apellidos { get; set; } //clave
        public string Nombre { get; set; } //usuario
        public string  Cargo { get; set; }
    }

}
