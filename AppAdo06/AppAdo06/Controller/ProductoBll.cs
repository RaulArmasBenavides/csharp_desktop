using AppAdo06.DataBase;
using AppAdo06.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo06.Controller
{
    public class ProductoBll
    {
        //variable de la clase ProductoDao
        ProductoDao dao;

        //constructor
        public ProductoBll()
        {
            dao = new ProductoDao();
        }

        //metodos de persistencoia de datos en sqlserver
        public void ProductoAdicionar(usp_Productos_Listar_Result pro)
        {
            try
            {
                dao.create(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ProductoActualizar(usp_Productos_Listar_Result pro)
        {
            try
            {
                dao.update(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ProductoEliminar(usp_Productos_Listar_Result pro)
        {
            try
            {
                dao.delete(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public usp_Productos_Listar_Result ProductoBuscar(usp_Productos_Listar_Result pro)
        {
            try
            {
                return dao.find(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<usp_Productos_Listar_Result> ProductoListar()
        {
            try
            {
                return dao.readAll();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<usp_Proveedor_Listar_Result> ProveedorListar()
        {
            try
            {
                return dao.listaProveedores();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<usp_Categoria_Listar_Result> CategoriaListar()
        {
            try
            {
                return dao.listaCategoria();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
