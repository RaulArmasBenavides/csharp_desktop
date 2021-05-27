using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RestauranteDL
{
    public class ClienteDL
    {
        int idCliente;
        string nombreCliente;
        string cedulaCliente;
        string dirCliente;
        string telefonoCliente;
        int edadCliente;
        string generoCliente;
        
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlCommand comando;
        DataSet dsDatos = new DataSet();
        string sentencia;

        public ClienteDL()
        {
             conexion = new SqlConnection("Data Source=localhost;Initial Catalog=RestauranteMicrosoft;Integrated Security=True");
        } 

        public void Insertar()
        {
            try
            {
                // sentencia = "insert into Cliente values (" + idCliente + ",'" + nombreCliente + "','" + cedulaCliente + "','" + dirCliente + "','" + telefonoCliente + "'," + edadCliente + ",'" + generoCliente + "')";
                sentencia = "insert into Cliente values ('" + nombreCliente + "','" + cedulaCliente + "','" + dirCliente + "','" + telefonoCliente + "'," + edadCliente + ",'" + generoCliente + "')";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                conexion.Close();
            }
        }

        public void Actualizar()
        {
            try
            {
                sentencia = "Update Cliente Set nombreCliente ='" + nombreCliente + "',cedulaCliente='" + cedulaCliente + "', dirCliente='" + dirCliente + "',telefonoCliente='" + telefonoCliente + "',edadCliente = " + edadCliente + ", generoCliente='" + generoCliente + "' Where idCliente =" + idCliente;
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

        public void Eliminar()
        {
            try
            {
                sentencia = "Delete from Cliente Where idCliente =" + idCliente;

                conexion.Open();
                comando = new SqlCommand (sentencia, conexion);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }

        public DataSet BuscarTodo()
        {
            try
            {
                sentencia = "Select * from Cliente";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "CLIENTE");
                conexion.Dispose();
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
            }
        }

        public DataSet BuscarId()
        {
            try
            {
                sentencia = "Select * from Cliente Where idCliente =" + idCliente;
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "Cliente");
                conexion.Dispose();
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
            }
        }
        
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }

        public string CedulaCliente
        {
            get { return cedulaCliente; }
            set { cedulaCliente = value; }
        }

        public string DirCliente
        {
            get { return dirCliente; }
            set { dirCliente = value; }
        }

        public string TelefonoCliente
        {
            get { return telefonoCliente; }
            set { telefonoCliente = value; }
        }

        public int EdadCliente
        {
            get { return edadCliente; }
            set { edadCliente = value; }
        }

        public string GeneroCliente
        {
            get { return generoCliente; }
            set { generoCliente = value; }
        }
    }
}
