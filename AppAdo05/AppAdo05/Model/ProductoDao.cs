using AppAdo05.DataBase;
using AppAdo05.Service;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AppAdo05.Model
{
    public class ProductoDao : ICrudDao<Producto>
    {
        //instanciar objeto de la clase contexto
        NeptunoEntities dc = new NeptunoEntities();

        public void create(Producto t)
        {
            dc.Productos.Add(t);
            dc.SaveChanges();
        }

        public void delete(Producto t)
        {
            var producto = (from p in dc.Productos where p.IdProducto == t.IdProducto
                            select p).SingleOrDefault();
            dc.Productos.Remove(producto);
            dc.SaveChanges();
        }

        public Producto findForId(Producto t)
        {
            var producto = (from p in dc.Productos where p.IdProducto==t.IdProducto select p).SingleOrDefault();
            return producto;
        }

        public List<Producto> readAll()
        {
            return dc.Productos.ToList();
        }

        public void update(Producto t)
        {
            var producto = (from p in dc.Productos
                            where p.IdProducto == t.IdProducto
                            select p).SingleOrDefault();

            producto.IdProducto = t.IdProducto;
            producto.NombreProducto = t.NombreProducto;
            producto.IdProveedor = t.IdProveedor;
            producto.IdCategoría = t.IdCategoría;
            producto.PrecioUnidad = t.PrecioUnidad;
            producto.UnidadesEnExistencia = t.UnidadesEnExistencia;
            dc.SaveChanges();
        }

        public List<Categorías> readAllCategorias()
        {
            return dc.Categorías.ToList();
        }

        public List<Proveedore> readAllProveedores()
        {
            return dc.Proveedores.ToList();
        }
    }
}
