using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestauranteDL;
using System.Data;

namespace RestauranteBL
{
    public class ReservacionBL
    {
        ReservacionDL reservacion = new ReservacionDL();

        public void Insertar(int idReservacion, int idCliente, DateTime fechaReservacion, string estado)
        {
            try
            {
            reservacion.IdCliente = idCliente;
            reservacion.IdReservacion = idReservacion;
            reservacion.FechaReservacion = fechaReservacion;
            reservacion.Estado = estado;

            reservacion.Insertar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet BuscarTodo()
        {
            return reservacion.BuscarTodo();
        }
    }
}
