using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RestauranteDL
{
    public class SucursalDL
    {
        int idSuc;

        public int IdSuc
        {
            get { return idSuc; }
            set { idSuc = value; }
        }
        string nombreSuc;

        public string NombreSuc
        {
            get { return nombreSuc; }
            set { nombreSuc = value; }
        }
        int capacidadSuc;

        public int CapacidadSuc
        {
            get { return capacidadSuc; }
            set { capacidadSuc = value; }
        }
        string establecimientoSuc;

        public string EstablecimientoSuc
        {
            get { return establecimientoSuc; }
            set { establecimientoSuc = value; }
        }
        string ciudadSuc;

        public string CiudadSuc
        {
            get { return ciudadSuc; }
            set { ciudadSuc = value; }
        }
        string direccionSuc;

        public string DireccionSuc
        {
            get { return direccionSuc; }
            set { direccionSuc = value; }
        }
        string telefonoSuc;

        public string TelefonoSuc
        {
            get { return telefonoSuc; }
            set { telefonoSuc = value; }
        }
        int serieSuc;

        public int SerieSuc
        {
            get { return serieSuc; }
            set { serieSuc = value; }
        }
        int numAutorizacionSuc;

        public int NumAutorizacionSuc
        {
            get { return numAutorizacionSuc; }
            set { numAutorizacionSuc = value; }
        }
        int inicioFactSuc;

        public int InicioFactSuc
        {
            get { return inicioFactSuc; }
            set { inicioFactSuc = value; }
        }
        int finFactSuc;

        public int FinFactSuc
        {
            get { return finFactSuc; }
            set { finFactSuc = value; }
        }
        DateTime fechaVigenciaFactSuc;

        public DateTime FechaVigenciaFactSuc
        {
            get { return fechaVigenciaFactSuc; }
            set { fechaVigenciaFactSuc = value; }
        }


        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlCommand comando;
        DataSet dsDatos = new DataSet();
        string sentencia;

        public SucursalDL()
        {
             conexion = new SqlConnection("Data Source=localhost;Initial Catalog=RestauranteMicrosoft;Integrated Security=True");
        } 

        public void Insertar()
        {
            try
            {
                //sentencia = "insert into SUCURSAL values (" + idSuc + ",'" + nombreSuc + "'," + capacidadSuc + ",'" + establecimientoSuc + "','" + ciudadSuc + "','" + direccionSuc + "','" + telefonoSuc + "'," + serieSuc + "," + numAutorizacionSuc + "," + inicioFactSuc + "," + finFactSuc + ",'" + fechaVigenciaFactSuc + "')";
                sentencia = "insert into SUCURSAL values (" + nombreSuc + "'," + capacidadSuc + ",'" + establecimientoSuc + "','" + ciudadSuc + "','" + direccionSuc + "','" + telefonoSuc + "'," + serieSuc + "," + numAutorizacionSuc + "," + inicioFactSuc + "," + finFactSuc + ",'" + fechaVigenciaFactSuc + "')";
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
                sentencia = "Update SUCURSAL Set NOMBRESUCURSAL ='" + nombreSuc + "',CAPACIDADSUCURSAL=" +capacidadSuc + ",ESTABLECIMIENTOSUCURSAL ='" + establecimientoSuc + "',CIUDADSUCURSAL='" + ciudadSuc + "',DIRECCIONSUCURSAL='"+direccionSuc+"',TELEFONOSUCURSAL='"+telefonoSuc+"', SERIEFACTSUCURSAL="+serieSuc+",NUMAUTORIZACIONFACTSUCURSAL="+numAutorizacionSuc+",INICIOFACTSUCURSAL="+inicioFactSuc+",FINFACTSUCURSAL="+finFactSuc+",FECHAVIGENCIAFACTSUCURSAL='"+fechaVigenciaFactSuc+"' Where IDSUCURSAL =" + idSuc;
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
                sentencia = "Delete from SUCURSAL Where IDSUCURSAL ="+idSuc;

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
                sentencia = "Select * from Sucursal";
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "Sucursal");
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
                sentencia = "Select * from SUCURSAL Where IDSUCURSAL =" + idSuc;
                conexion.Open();
                comando = new SqlCommand(sentencia, conexion);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dsDatos, "SUCURSAL");
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
        
    }
}