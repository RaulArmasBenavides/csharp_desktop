using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AppAdo02.Database;

namespace AppAdo02.Model
{
    public class ProductoDao
    {
        //metodos de consulta
        public DataTable listaProductos()
        {
            DataTable dt;
            using (var cn=AccesoDB.getConnection())
            {
                SqlDataAdapter dap = new SqlDataAdapter("usp_Producto_Listar", cn);
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                dap.Fill(dt);
            }
            return dt;
        }

        public DataTable listaProductos(int idcat)
        {
            DataTable dt;
            using (var cn = AccesoDB.getConnection())
            {
                SqlDataAdapter dap = new SqlDataAdapter("usp_Producto_Listar_Por_Categoria", cn);
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                //preparar valor de parametro a pasar al sp
                dap.SelectCommand.Parameters.AddWithValue("@IdCategoria",idcat);
                dt = new DataTable();
                dap.Fill(dt);
            }
            return dt;
        }

        public DataTable listaProductos(string nombre)
        {
            DataTable dt;
            using (var cn = AccesoDB.getConnection())
            {
                SqlDataAdapter dap = new SqlDataAdapter("usp_Producto_Listar_Por_Nombre", cn);
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                //preparar valor de parametro a pasar al sp
                dap.SelectCommand.Parameters.AddWithValue("@Nombre", nombre);
                dt = new DataTable();
                dap.Fill(dt);
            }
            return dt;
        }

        public DataTable listaCategorias()
        {
            DataTable dt;
            using (var cn = AccesoDB.getConnection())
            {
                SqlDataAdapter dap = new SqlDataAdapter("usp_Categoria_Listar", cn);
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt = new DataTable();
                dap.Fill(dt);
            }
            return dt;
        }

    }
}
