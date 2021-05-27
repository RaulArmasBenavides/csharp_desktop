using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alumnos.Entity
{
    public class Curso
    {
        public int codigocurso { get; set; }
        public string nombrecurso { get; set; }
        public string docente { get; set; }
        public int creditaje { get; set; }
        public int seccion { get; set; }
    }
}
