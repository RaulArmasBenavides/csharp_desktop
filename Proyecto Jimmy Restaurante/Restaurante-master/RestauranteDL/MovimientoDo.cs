using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RestauranteDL
{
    public class MovimientoDo
    {

        #region Declaración de variables
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlCommand comando;
        DataSet dsDatos = new DataSet();
        string sentencia;
        #endregion


        public MovimientoDo()
        {
            conexion = new SqlConnection("Data Source=.;Initial Catalog=CAJA;Integrated Security=True");
        }

        public void Insertar(Movimiento mov )
        {
            try
            {
            sentencia = "insert into movimientos values ('" + mov.Concepto + "','" + mov.Tipo + "','" + mov.SubTipo + "','" +  mov.Fecha + "'," + mov.Monto +",'" + mov.Mes + "')";
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

        public void Actualizar(Movimiento mov)
        {
            try
            {
                //sentencia = "Update Menu Set concepto ='" + mov.Concepto + "','" + mov.Tipo + "','" + mov.SubTipo + "','" + mov.Fecha + "'," + mov.Monto + ",'" + mov.Mes + "' Where nombreMenu =' " + NombreMenu + "'";
                sentencia = "";
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

        public void Eliminar(Movimiento mov)
        {
            try
            {
                sentencia = "Delete from movimientos Where idmovimiento = " + mov.idMovimiento.ToString();
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

        public DataSet BuscarTodo(Movimiento mov)
        {
            try
            {
                sentencia = "Select * from movimientos";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "MOVIMIENTO");

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

        public DataSet BuscarId(Movimiento mov)
        {
            try
            {
                sentencia = "Select * from Menu Where idMenu =" + mov.idMovimiento.ToString().Trim();
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "MENU");

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
    }
}
