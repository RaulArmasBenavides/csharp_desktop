using AppAdoNet07.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdoNet07.Controller
{
    public class EmpleadoBLL
    {

        public int EmpleadoValidar(string usu,string pas)
        {
            return new EmpleadoDAO().validar(usu, pas);
        }
    }
}
