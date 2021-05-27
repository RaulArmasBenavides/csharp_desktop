using AppAdo03.Entity;
using AppAdo03.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AppAdo03.DataBase;

namespace AppAdo03.Model
{
    public class ProductoDAO : ICrudDao<ProductoTO>
    {
        // variables
        SqlCommand cmd;
        SqlDataReader dr;
        int ok;

        public int create(ProductoTO t)
        {
            try
            {
                using (var cn=AccesoDB.Conexion())
                {
                    cmd = new SqlCommand("usp_Producto_Adicionar",cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // prepar parametros con su valores para el sp
                    cmd.Parameters.AddWithValue("@Nombre",t.NombreProducto);
                    cmd.Parameters.AddWithValue("@IdProveedor", t.IdProveedor);
                    cmd.Parameters.AddWithValue("@IdCategoria", t.IdCategoria);
                    cmd.Parameters.AddWithValue("@Precio", t.Precio);
                    cmd.Parameters.AddWithValue("@Stock", t.Stock);
                    cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //ejecutar sp
                    cn.Open();
                    ok = cmd.ExecuteNonQuery() == 1 ? 1 : -1;
                    t.IdProducto = (int)cmd.Parameters["@IdProducto"].Value;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return ok;         
        }

        public int delete(ProductoTO t)
        {
            try
            {
                using (var cn = AccesoDB.Conexion())
                {
                    cmd = new SqlCommand("usp_Producto_Eliminar", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // prepar parametro con su valor para el sp                   
                    cmd.Parameters.AddWithValue("@IdProducto", t.IdProducto);
                    //ejecutar sp
                    cn.Open();
                    ok = cmd.ExecuteNonQuery() == 1 ? 1 : -1;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return ok;
        }

        public ProductoTO findForId(object t)
        {
            ProductoTO pro = null;
            try
            {
                using (var cn = AccesoDB.Conexion())
                {
                    cmd = new SqlCommand("usp_Producto_Datos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdProducto", Convert.ToInt32(t));
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        pro = new ProductoTO()
                        {
                            IdProducto = Convert.ToInt32(dr[0]),
                            NombreProducto = dr[1].ToString(),
                            IdProveedor = Convert.ToInt32(dr[2]),
                            IdCategoria = Convert.ToInt32(dr[3]),
                            Precio = Convert.ToDecimal(dr[4]),
                            Stock = Convert.ToInt32(dr[5]),
                        };                       
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return pro;
        }

        public List<ProductoTO> readAll()
        {
            List<ProductoTO> lista = new List<ProductoTO>();
            try
            {
                using (var cn = AccesoDB.Conexion())
                {
                    cmd = new SqlCommand("usp_Productos_Listar", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                    while (dr.Read())
                    {
                        ProductoTO pro = new ProductoTO()
                        {
                            IdProducto = Convert.ToInt32(dr[0]),
                            NombreProducto=dr[1].ToString(),
                            IdProveedor= Convert.ToInt32(dr[2]),
                            IdCategoria= Convert.ToInt32(dr[3]),
                            Precio= Convert.ToDecimal(dr[4]),
                            Stock= Convert.ToInt32(dr[5]),
                        };
                        lista.Add(pro);
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                //throw ex;
            }
            return lista;
        }

        public int update(ProductoTO t)
        {
            try
            {
                using (var cn = AccesoDB.Conexion())
                {
                    cmd = new SqlCommand("usp_Producto_Actualizar", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // prepar parametros con su valores para el sp
                    cmd.Parameters.AddWithValue("@Nombre", t.NombreProducto);
                    cmd.Parameters.AddWithValue("@IdProveedor", t.IdProveedor);
                    cmd.Parameters.AddWithValue("@IdCategoria", t.IdCategoria);
                    cmd.Parameters.AddWithValue("@Precio", t.Precio);
                    cmd.Parameters.AddWithValue("@Stock", t.Stock);
                    cmd.Parameters.AddWithValue("@IdProducto",t.IdProducto);
                    //ejecutar sp
                    cn.Open();
                    ok = cmd.ExecuteNonQuery() == 1 ? 1 : -1;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return ok;
        }
        //otros metodos
        public DataTable readAllProveedores()
        {
            DataTable dt;
            SqlDataAdapter dap;                 
            try
            {
                using (var cn = AccesoDB.Conexion())
                {
                    dap = new SqlDataAdapter("usp_Proveedor_Listar", cn);
                    dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dt = new DataTable();
                    dap.Fill(dt);                               
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable readAllCategorias()
        {
            DataTable dt;
            SqlDataAdapter dap;
            try
            {
                using (var cn = AccesoDB.Conexion())
                {
                    dap = new SqlDataAdapter("usp_Categoria_Listar", cn);
                    dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dt = new DataTable();
                    dap.Fill(dt);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dt;
        }

    }
}
