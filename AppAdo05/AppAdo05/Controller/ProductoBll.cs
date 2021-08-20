using AppAdo05.DataBase;
using AppAdo05.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo05.Controller
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
        public void ProductoAdicionar(Producto p)
        {
            try
            {
                dao.create(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        public void ProductoActualizar(Producto p)
        {
            try
            {
                dao.update(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ProductoEliminar(Producto p)
        {
            try
            {
                dao.delete(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Producto ProductoBuscar(Producto p)
        {
            try
            {
                return dao.findForId(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Producto> ProductoListar()
        {
            try
            {
                return dao.readAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Categorías> CategoriaListar()
        {
            return dao.readAllCategorias();
        }
        public List<Proveedore> ProveedorListar()
        {
            return dao.readAllProveedores();
        }
    }
}
