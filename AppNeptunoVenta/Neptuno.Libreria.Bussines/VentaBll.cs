

using Neptuno.Libreria.Entity;
using Neptuno.Libreria.SqlServer;
using Neptuno.Libreria.DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Neptuno.Libreria.Negocio
{
    public class VentaBll : AccesoDB
    {

        #region Metodos de Negocio
        public DataTable ClienteListar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    VentaDao dao = new VentaDao();
                    tabla = dao.ListarTablaClientes(cn);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return tabla;
        }//end

        public DataTable EmpleadoListar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    VentaDao dao = new VentaDao();
                    tabla = dao.ListarTablaEmpleados(cn);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return tabla;
        }//end

        public DataTable ProductoListar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    VentaDao dao = new VentaDao();
                    tabla = dao.ListarTablaProductos(cn);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return tabla;
        }//end

        public Producto ProductosPorCodigo(int id)
        {
            Producto pro = null;
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    VentaDao dao = new VentaDao();
                    pro = dao.ConsultarPorCodigo(cn, id);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return pro;
        }//end

        public int RegistraVenta(Ventas ve)
        {
            int ok = 0;
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();                  
                    VentaDao dao = new VentaDao();
                    ok = dao.registrar(cn, ve);                    
                }
                catch (Exception ex)
                {                                            
                 throw ex;
                }
                finally
                {
                    cn.Close();
                }
            }
            return ok;
        }//end
        #endregion

    }
}

