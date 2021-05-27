using AppAdoNet07.Entity;
using AppAdoNet07.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdoNet07.Controller
{
    public class VentaBll
    {
        //VentaDao dap = new VentaDao();

        public static DataTable ClienteListar()
        {
            return new VentaDao().ListarCliente();
        }

        public static DataTable EmpleadoListar()
        {
            return new VentaDao().EmpleadoListar();
        }

        public static DataTable ProductoListar()
        {
            return new VentaDao().ProductoListar();
        }

        public static int RegistarVenta(Venta o)
        {
            return new VentaDao().Registrar(o);
        }

        public static SqlDataReader DatosProducto(int id)
        {
            return new VentaDao().ProductoDatos(id);
        }


    }
}
