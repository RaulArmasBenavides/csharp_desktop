using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestauranteDL;
using System.Data;
using System.Globalization;

namespace RestauranteBL
{
    public class EmpleadoBL
    {
        EmpleadoDL empleado = new EmpleadoDL();

        public void insertar(string nombre, string genero, string cargo, DateTime fechaNac)
        {
           // empleado.IdEmp = id;
            empleado.NombreEmp = nombre;
            empleado.GeneroEmp = genero;
            //  empleado.FechaNacEmp = DateTime.ParseExact(fechaNac,"dd-mm-yyy",System.Globalization.CultureInfo.InvariantCulture);
            empleado.FechaNacEmp = DateTime.Parse(fechaNac.ToShortDateString());
           // empleado.FechaNacEmp = (DateTime.Parse(fechaNac, new CultureInfo("en-CA")));
            // empleado.FechaNacEmp = fechaNac;
            empleado.CargoEmp = cargo;
            empleado.Insertar();            
        }

        public void actualizar(int id, string nombre, string genero, string cargo, DateTime fechaNac)
        {
            empleado.IdEmp = id;
            empleado.NombreEmp = nombre;
            empleado.GeneroEmp = genero;
            empleado.FechaNacEmp = Convert.ToDateTime(fechaNac);
            empleado.CargoEmp = cargo;
            empleado.Actualizar();
        }

        public void eliminar(int id)
        {
            empleado.IdEmp = id;
            empleado.Eliminar();
        }

        public DataSet buscarTodo()
        {
            return empleado.buscarTodo();
        }

        public DataSet buscarId(int id)
        {
            empleado.IdEmp = id;
            return empleado.buscarId();
        }

    }
}
