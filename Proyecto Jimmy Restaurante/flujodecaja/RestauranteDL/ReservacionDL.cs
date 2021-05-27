using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RestauranteDL
{
    public class ReservacionDL
    {
        int idReservacion;

        public int IdReservacion
        {
            get { return idReservacion; }
            set { idReservacion = value; }
        }
        int idCliente;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        DateTime fechaReservacion;

        public DateTime FechaReservacion
        {
            get { return fechaReservacion; }
            set { fechaReservacion = value; }
        }
        string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlCommand comando;
        DataSet dsDatos = new DataSet();
        string sentencia;

        public ReservacionDL()
        {
             conexion = new SqlConnection("Data Source=localhost;Initial Catalog=RestauranteMicrosoft;Integrated Security=True");
        } 

        public void Insertar()
        {
            try
            {
                // sentencia = "insert into RESERVACION values (" + idReservacion + "," + idCliente + ",'" + fechaReservacion + "','" + estado + "')";
                sentencia = "insert into Reservacion values (" + idCliente + ",'" + fechaReservacion + "','" + estado + "')";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
                conexion.Dispose();
            }
        }

        public DataSet BuscarTodo()
        {
            try
            {
                sentencia = "Select a.idReservacion, a.idCliente, b.nombreCliente, a.estado from Reservacion a , Cliente b where a.idCliente = b.idCliente";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "Reservacion");

                return dsDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
                conexion.Dispose();
            }
        }

        public int generarId() 
        {
            int idGenerado;
            sentencia = "select max (idReservacion) from Reservaccion";
            conexion.Open();
            comando = new SqlCommand(sentencia, conexion);
            comando.CommandType = CommandType.Text;
            idGenerado =(Int32)comando.ExecuteScalar();
            return idGenerado + 1;
        }
    }
}
