using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestauranteDL;
using System.Data;

namespace RestauranteBL
{
    public class MenuBL
    {
        MenuDL menu = new MenuDL();

        public void Insertar( string nombre, string descripcion, decimal precio, string disponibilidad)
        {
           try
            {
               // menu.IdMenu = id;
                menu.NombreMenu = nombre;
                menu.DescripcionMenu = descripcion;
                menu.PrecioMenu = precio;
                menu.DisponibilidadMenu = disponibilidad;
                menu.Insertar();
           }
           catch (Exception ex)
           {
              throw ex;
           }
        }

        public void Actualizar(int id, string nombre, string descripcion, decimal precio, string disponibilidad)
        {
            menu.IdMenu = id;
            menu.NombreMenu = nombre;
            menu.DescripcionMenu = descripcion;
            menu.PrecioMenu = precio;
            menu.DisponibilidadMenu = disponibilidad;
            menu.Actualizar();
        }

        public void Eliminar(int id)
        {
            menu.IdMenu = id;
            menu.Eliminar();
        }

        public DataSet BuscarTodo()
        {
            return menu.BuscarTodo();
        }

        public DataSet BuscarId(int id)
        {
            menu.IdMenu= id;
            return menu.BuscarId();
        }
    }
}
