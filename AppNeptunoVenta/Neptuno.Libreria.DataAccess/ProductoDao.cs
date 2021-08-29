

using Neptuno.Libreria.Entity;
using Neptuno.Libreria.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Neptuno.Libreria.DataAccess
{
   public class ProductoDao : IServicioNeptuno<Producto>
    {

      #region Metodos de persistencia
        public void create(SqlConnection con,Producto reg)
       {
            int IdProducto = -1;
            SqlCommand cmd = new SqlCommand("usp_Producto_Adicionar",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreProducto",reg.NombreProducto);
            cmd.Parameters.AddWithValue("@IdProveedor", reg.IdProveedor);
            cmd.Parameters.AddWithValue("@IdCategoria", reg.IdCategoria);
            cmd.Parameters.AddWithValue("@Precio", reg.PrecioUnidad);
            cmd.Parameters.AddWithValue("@Stock", reg.Stock);
            SqlParameter par = cmd.Parameters.Add("@IdProducto", SqlDbType.Int);
            par.Direction = ParameterDirection.Output;
            int n = cmd.ExecuteNonQuery();
            if (n > 0) IdProducto = (int)par.Value;
            
        }//end

       public void update(SqlConnection con, Producto reg)
       {
            
            SqlCommand cmd = new SqlCommand("usp_Producto_Actualizar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", reg.IdProducto);
            cmd.Parameters.AddWithValue("@NombreProducto", reg.NombreProducto);
            cmd.Parameters.AddWithValue("@IdProveedor", reg.IdProveedor);
            cmd.Parameters.AddWithValue("@IdCategoria", reg.IdCategoria);
            cmd.Parameters.AddWithValue("@Precio", reg.PrecioUnidad);
            cmd.Parameters.AddWithValue("@Stock", reg.Stock);          
            cmd.ExecuteNonQuery();           
           
        }//end

       public void delete(SqlConnection con, Producto reg)
       {           
            SqlCommand cmd = new SqlCommand("usp_Producto_Eliminar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", reg.IdProducto);           
            cmd.ExecuteNonQuery();            
            
        }//end

        public List<Producto> readAll(SqlConnection con)
        {
            List<Producto> lista = null;
            SqlCommand cmd = new SqlCommand("usp_Productos_Listar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (dr != null)
            {
                int posId = dr.GetOrdinal("IdProducto");
                int posNom = dr.GetOrdinal("NombreProducto");
                int posProv = dr.GetOrdinal("IdProveedor");
                int posCat = dr.GetOrdinal("IdCategoría");
                int posPre = dr.GetOrdinal("PrecioUnidad");
                int posStk = dr.GetOrdinal("Stock");
                Producto pro;
                lista = new List<Producto>();
                while (dr.Read())
                {
                    pro = new Producto();
                    pro.IdProducto = dr.GetInt32(posId);
                    pro.NombreProducto = dr.GetString(posNom);
                    pro.IdProveedor = dr.GetInt32(posProv);
                    pro.IdCategoria = dr.GetInt32(posCat);
                    pro.PrecioUnidad = dr.GetDecimal(posPre);
                    pro.Stock = dr.GetInt16(posStk);
                    lista.Add(pro);
                }
                dr.Close();
            }
            return lista;
        }//end

        public DataTable ListarTabla(SqlConnection con)
        {
            SqlDataAdapter dap = new SqlDataAdapter("usp_Producto_Listar", con);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            dap.Fill(tabla);
            tabla.TableName = "Producto";
            return tabla;
        }//end

        public Producto FindForId(SqlConnection con,object pr)
        {
            Producto pro = null;
            SqlCommand cmd = new SqlCommand("usp_Producto_Datos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", Convert.ToInt32(pr));
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (dr != null)
            {
                int posId = dr.GetOrdinal("IdProducto");
                int posNom = dr.GetOrdinal("NombreProducto");
                int posProv = dr.GetOrdinal("IdProveedor");
                int posCat = dr.GetOrdinal("IdCategoría");
                int posPre = dr.GetOrdinal("PrecioUnidad");
                int posStk = dr.GetOrdinal("Stock");             
                if (dr.Read())
                {
                    pro = new Producto();
                    pro.IdProducto = dr.GetInt32(posId);
                    pro.NombreProducto = dr.GetString(posNom);
                    pro.IdProveedor = dr.GetInt32(posProv);
                    pro.IdCategoria = dr.GetInt32(posCat);
                    pro.PrecioUnidad = dr.GetDecimal(posPre);
                    pro.Stock = dr.GetInt16(posStk);                   
                }
                dr.Close();
            }
            return pro;
        }//end

        public DataTable ListarTablaProveedores(SqlConnection con)
        {
            SqlDataAdapter dap = new SqlDataAdapter("usp_Proveedores_Listar", con);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            dap.Fill(tabla);
            tabla.TableName = "Proveedores";
            return tabla;
        }//end

        public DataTable ListarTablaCategorias(SqlConnection con)
        {
            SqlDataAdapter dap = new SqlDataAdapter("usp_Categoria_Listar", con);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            dap.Fill(tabla);
            tabla.TableName = "Categorias";
            return tabla;
        }//end
        #endregion

    }
}
