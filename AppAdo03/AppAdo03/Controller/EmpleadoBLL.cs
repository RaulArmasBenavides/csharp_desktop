using AppAdo03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo03.Controller
{
    public class EmpleadoBLL
    {
        EmpleadoDAO dao;

        public EmpleadoBLL()
        {
            dao = new EmpleadoDAO();
        }

        public bool EmpleadoValidar(string usu,string pas)
        {
            return dao.validar(usu, pas);
        }
    }
}
