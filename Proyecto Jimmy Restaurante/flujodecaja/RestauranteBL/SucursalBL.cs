using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestauranteDL;
using System.Data;

namespace RestauranteBL
{
   public class SucursalBL
    {
        SucursalDL suc = new SucursalDL();

        public void Insertar(int id, string nombre, int capacidad, string establecimiento, string ciudad, string dir, string telefono, int serie, int numAutorizacion, int inicioFact, int finFact, DateTime fechaVigenciaFact)
        {
            suc.IdSuc = id;
            suc.NombreSuc = nombre;
            suc.CapacidadSuc = capacidad;
            suc.EstablecimientoSuc = establecimiento;
            suc.CiudadSuc = ciudad;
            suc.DireccionSuc = dir;
            suc.TelefonoSuc = telefono;
            suc.SerieSuc = serie;
            suc.NumAutorizacionSuc = numAutorizacion;
            suc.InicioFactSuc = inicioFact;
            suc.FinFactSuc = finFact;
            suc.FechaVigenciaFactSuc = fechaVigenciaFact; 
            suc.Insertar();
        }

        public void Actualizar(int id, string nombre, int capacidad, string establecimiento, string ciudad, string dir, string telefono, int serie, int numAutorizacion, int inicioFact, int finFact, DateTime fechaVigenciaFact)
        {
            suc.IdSuc = id;
            suc.NombreSuc = nombre;
            suc.CapacidadSuc = capacidad;
            suc.EstablecimientoSuc = establecimiento;
            suc.CiudadSuc = ciudad;
            suc.DireccionSuc = dir;
            suc.TelefonoSuc = telefono;
            suc.SerieSuc = serie;
            suc.NumAutorizacionSuc = numAutorizacion;
            suc.InicioFactSuc = inicioFact;
            suc.FinFactSuc = finFact;
            suc.FechaVigenciaFactSuc = fechaVigenciaFact;
            suc.Actualizar();
        }

        public void Eliminar(int id)
        {
            suc.IdSuc = id;
            suc.Eliminar();
        }

        public DataSet BuscarTodo()
        {
            return suc.BuscarTodo();
        }

        public DataSet BuscarId(int id)
        {
            suc.IdSuc = id;
            return suc.BuscarId();
        }
    }
}
