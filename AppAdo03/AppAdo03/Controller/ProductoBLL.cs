using AppAdo03.Entity;
using AppAdo03.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo03.Controller
{
    public class ProductoBLL
    {
        // variable de la clase ProductoDAO
        ProductoDAO dao;
        //constructor
        public ProductoBLL()
        {
            dao = new ProductoDAO();
        }
        // metodos de negocio
        public int ProductoAdicionar(ProductoTO p)
        {
            return dao.create(p);
        }

        public int ProductoActualizar(ProductoTO p)
        {
            return dao.update(p);
        }

        public int ProductoEliminar(ProductoTO p)
        {
            return dao.delete(p);
        }

        public ProductoTO ProductoBuscar(object p)
        {
            return dao.findForId(p);
        }

        public List<ProductoTO> ProductoListar()
        {
            return dao.readAll();
        }

        public DataTable CategoriaListar()
        {
            return dao.readAllCategorias();
        }

        public DataTable ProveedorListar()
        {
            return dao.readAllProveedores();
        }

    }
}
