using RestauranteDL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RestauranteBL
{
    public class FlujoCajaBo
    {
        //definir entidad
        Movimiento mov = null;
        MovimientoDo _doMovimiento = null;


        public void Insertar(string concepto, string tipo, string subtipo,string fecha, decimal monto , string mes)
        {

            mov = new Movimiento();
            _doMovimiento = new MovimientoDo();
            try
            {
                mov.Concepto = concepto.Trim();
                //mov.Descripcion = descripcion.Trim();
                mov.Fecha = fecha.Trim();
                mov.Monto = monto;
                mov.Tipo = tipo.Trim();
                mov.SubTipo = subtipo.Trim();
                mov.Mes = mes.Trim();
                _doMovimiento.Insertar(mov);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(int id, string concepto, string tipo, string subtipo, string fecha, decimal monto, string mes)
        {

            mov = new Movimiento();
            _doMovimiento = new MovimientoDo();
            try
            {
                //menu.IdMenu = id;
                //menu.NombreMenu = nombre;
                //menu.DescripcionMenu = descripcion;
                //menu.PrecioMenu = precio;
                //menu.DisponibilidadMenu = disponibilidad;
                //menu.Actualizar();
                mov.Concepto = concepto.Trim();
                //mov.Descripcion = descripcion.Trim();
                mov.Fecha = fecha.Trim();
                mov.Monto = monto;
                mov.Tipo = tipo.Trim();
                mov.SubTipo = subtipo.Trim();
                mov.Mes = mes.Trim();
                _doMovimiento.Actualizar(mov);

            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

        public void Eliminar(int id)
        {
            try
            {
                mov = new Movimiento();
                _doMovimiento = new MovimientoDo();
                mov.idMovimiento = id;
                _doMovimiento.Eliminar(mov);

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public DataSet BuscarTodo()
        {
            try
            {
                mov = new Movimiento();
                _doMovimiento = new MovimientoDo();
                return _doMovimiento.BuscarTodo(mov);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public DataSet BuscarId(int id)
        {
            try
            {
                mov = new Movimiento();
                _doMovimiento = new MovimientoDo();
                mov.idMovimiento = id;
                return _doMovimiento.BuscarId(mov);
            }
            catch (Exception ex)
            {
                throw ex;
            }
      
        }
    }
}
