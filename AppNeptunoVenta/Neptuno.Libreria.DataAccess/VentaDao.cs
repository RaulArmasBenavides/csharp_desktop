using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Neptuno.Libreria.Entity;
using Neptuno.Libreria.Service;

namespace Neptuno.Libreria.DataAccess
{
    public class VentaDao : IServicioTransaccion<Ventas>
    {
        public DataTable ListarTablaClientes(SqlConnection con)
        {
            SqlDataAdapter dap = new SqlDataAdapter("usp_Cliente_Listar", con);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            dap.Fill(tabla);
            tabla.TableName = "Clientes";
            return tabla;
        }//end

        public DataTable ListarTablaEmpleados(SqlConnection con)
        {
            SqlDataAdapter dap = new SqlDataAdapter("usp_Empleados_Listar", con);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            dap.Fill(tabla);
            tabla.TableName = "Empleados";
            return tabla;
        }//end


        public DataTable ListarTablaProductos(SqlConnection con)
        {
            SqlDataAdapter dap = new SqlDataAdapter("usp_Producto_Listar", con);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            dap.Fill(tabla);
            tabla.TableName = "Productos";
            return tabla;
        }//end

        public Producto ConsultarPorCodigo(SqlConnection con, int id)
        {
            Producto pro = null;
            SqlCommand cmd = new SqlCommand("usp_Producto_Datos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", id);
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

        //metodo registra las ventas
        public int registrar(SqlConnection con, Ventas t)
        {
            int IdVenta = -1;
            SqlTransaction trx = null;
            try
            {
                trx = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand("usp_Registra_Venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente", t.IdCliente);
                cmd.Parameters.AddWithValue("@IdEmpleado", t.IdEmpleado);
                cmd.Parameters.AddWithValue("@Fecha", t.FechaVenta);
                cmd.Parameters.AddWithValue("@Monto", t.Monto);
                SqlParameter par = cmd.Parameters.Add("@IdVenta", SqlDbType.Int);
                par.Direction = ParameterDirection.Output;
                cmd.Transaction = trx;
                //ejecuta SP
                int n = cmd.ExecuteNonQuery();

                if (n > 0) IdVenta = (int)par.Value;
                //
                SqlCommand cmdd = new SqlCommand("usp_Registra_Detalle", con);
                cmdd.CommandType = CommandType.StoredProcedure;
                cmdd.Transaction = trx;

                SqlCommand cmdp = new SqlCommand("usp_Actualiza_Stock", con);
                cmdp.CommandType = CommandType.StoredProcedure;
                cmdp.Transaction = trx;

                foreach (Detalle item in t.Item)
                {
                    cmdd.Parameters.Clear();
                    cmdd.Parameters.AddWithValue("@Idventa", IdVenta);
                    cmdd.Parameters.AddWithValue("@IdProducto", item.IdProducto);
                    cmdd.Parameters.AddWithValue("@Precio", item.Precio);
                    cmdd.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                    //ejecuta SP
                    cmdd.ExecuteNonQuery();
                    cmdp.Parameters.Clear();
                    cmdp.Parameters.AddWithValue("@IdProducto", item.IdProducto);
                    cmdp.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                    //
                    cmdp.ExecuteNonQuery();
                }
                trx.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    trx.Rollback();
                }
                catch (Exception ex1)
                {
                    throw ex1;
                }
                throw ex;
            }
            return IdVenta;

        }

    }
}
