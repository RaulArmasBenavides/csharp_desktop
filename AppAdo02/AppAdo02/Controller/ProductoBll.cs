using AppAdo02.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo02.Controller
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

        //metodos de negocio
        public DataTable ProductoListar()
        {
            try
            {
                return dao.listaProductos();
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }

        public DataTable ProductoListar(string nombre)
        {
            try
            {
                return dao.listaProductos(nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ProductoListar(int id)
        {
            try
            {
                return dao.listaProductos(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable CategoriaListar()
        {
            try
            {
                return dao.listaCategorias();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
