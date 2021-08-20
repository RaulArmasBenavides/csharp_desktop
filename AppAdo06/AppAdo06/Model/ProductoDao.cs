using AppAdo06.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppAdo06.Model;
using System.Data.Entity.Core.Objects;
using AppAdo06.DataBase;

namespace AppAdo06.Model
{
    public class ProductoDao : ICrudDao<usp_Productos_Listar_Result>
    {
        //instanciar objeto de la clase contexto
        NeptunoEntities dc = new NeptunoEntities();

        public void create(usp_Productos_Listar_Result t)
        {
            //objeto de tipo objectparameter para guardar el idproduto que devuelve el store
            ObjectParameter cod = new ObjectParameter("idproducto",typeof(Int32));
            dc.usp_Producto_Adicionar(t.NombreProducto, t.IdProveedor, t.IdCategoría, t.PrecioUnidad, t.UnidadesEnExistencia,cod);
            t.IdProducto = Convert.ToInt32(cod.Value.ToString()); // opcional
            //dc.SaveChanges();
        }

        public void delete(usp_Productos_Listar_Result t)
        {
            dc.usp_Producto_Eliminar(t.IdProducto);
            //dc.SaveChanges();
        }

        public usp_Productos_Listar_Result find(usp_Productos_Listar_Result t)
        {
            usp_Productos_Listar_Result dato = null;
            var pro = dc.usp_Productos_Datos(t.IdProducto);
            foreach (var item in pro)
            {
                dato = new usp_Productos_Listar_Result()
                {
                    IdProducto=item.IdProducto,
                    NombreProducto=item.NombreProducto,
                    IdProveedor=item.IdProveedor,
                    IdCategoría=item.IdCategoría,
                    PrecioUnidad=item.PrecioUnidad,
                    UnidadesEnExistencia=item.UnidadesEnExistencia
                };
            }
            return dato; 
        }

        public List<usp_Productos_Listar_Result> readAll()
        {
            return dc.usp_Productos_Listar().ToList();
        }

        public void update(usp_Productos_Listar_Result t)
        {
            dc.usp_Producto_Actualizar(t.NombreProducto, t.IdProveedor, t.IdCategoría, t.PrecioUnidad, t.UnidadesEnExistencia, t.IdProducto);
            //dc.SaveChanges();
        }

        public List<usp_Proveedor_Listar_Result> listaProveedores()
        {
            return dc.usp_Proveedor_Listar().ToList();
        }

        public List<usp_Categoria_Listar_Result> listaCategoria()
        {
            return dc.usp_Categoria_Listar().ToList();
        }
    }
}
