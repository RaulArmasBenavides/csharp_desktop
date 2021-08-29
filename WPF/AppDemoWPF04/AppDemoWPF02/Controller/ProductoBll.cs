using AppDemoWPF02.Entity;
using AppDemoWPF02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemoWPF02.Controller
{
    public class ProductoBll
    {
        //variable de la clase ProductoDaoFile
        ProductoDaoFile dao;

        // constructor
        public ProductoBll()
        {
            dao = new ProductoDaoFile();
        }

        // metodos de negocio
        public void ProductoAdicionar(Producto pro)
        {
            dao.create(pro);
        }

        public void ProductoActualizar(Producto pro)
        {
            dao.update(pro);
        }

        public void ProductoEliminar(Producto pro)
        {
            dao.delete(pro);
        }

        public List<Producto> ProductoListar()
        {
            return dao.readAll();
        }

        public Producto ProductoBuscar(int id)
        {
            return dao.findForId(id);
        }


    }
}
