
using Neptuno.Libreria.Entity;
using Neptuno.Libreria.SqlServer;
using Neptuno.Libreria.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Neptuno.Libreria.Bussines
{
    public class ProductoBll : AccesoDB
    {

        #region Metodos de Persistencia
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    ProductoDao dao = new ProductoDao();
                    lista = dao.readAll(cn);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return lista;
        }//end

        public DataTable ListarTabla()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    ProductoDao dao = new ProductoDao();
                    tabla = dao.ListarTabla(cn);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return tabla;
        }//end

        public DataTable ListarProveedores()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    ProductoDao dao = new ProductoDao();
                    tabla = dao.ListarTablaProveedores(cn);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return tabla;
        }//end

        public DataTable ListarCategorias()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    ProductoDao dao = new ProductoDao();
                    tabla = dao.ListarTablaCategorias(cn);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return tabla;
        }//end

        public Producto ConsultarProductosPorCodigo(Producto p)
        {
            Producto pro = null;
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    ProductoDao dao = new ProductoDao();
                    pro = dao.FindForId(cn,p);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return pro; 
        }//end

        public int ProductoAdicionar(Producto p)
        {
            int ok = -1;
           using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    ProductoDao dao = new ProductoDao();
                    dao.create(cn, p);
                    ok = 1;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return ok;
        }//end

        public int ProductoActualizar(Producto p)
        {
            int ok =-1;
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    ProductoDao dao = new ProductoDao();
                    dao.update(cn, p);
                    ok = 1;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return ok;
        }//end

        public int ProductoEliminar(Producto p)
        {
            int ok = -1;
            using (SqlConnection cn = new SqlConnection(CadenaConexion))
            {
                try
                {
                    cn.Open();
                    ProductoDao dao = new ProductoDao();
                    dao.delete(cn, p);
                    ok = 1;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return ok;
        }//end

        #endregion

    }
}
