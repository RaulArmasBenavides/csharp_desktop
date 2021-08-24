using appcongreso.EF;
using CapaDatos.Service;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos.Model
{
    public class ActividadDAO : Service<usp_actividades_listar_all2_Result>
    {   // entidades  usando ENTITY FRAMEWORK
        bdcongresoEntities e = new bdcongresoEntities();
        

        public void create(usp_actividades_listar_all2_Result t)
        {
            try
            {
                e.usp_registrar_actividad_oficial(t.Nombre, t.descripcion, t.rol_responsable, t.rol_creacion, t.fec_inicio, t.fec_Fin, t.idasistencias, t.idlistaeq, t.idsala);
            }
            catch (System.Exception ex )
            {

                throw ex;
            }
            // objeto de tipo objectparameter para guardar el idproduto que devuelve el store
            //ObjectParameter cod = new ObjectParameter("idactividad", typeof(Int64));
            // dc.usp_Producto_Adicionar(t.NombreProducto, t.IdProveedor, t.IdCategoría, t.PrecioUnidad, t.UnidadesEnExistencia, cod);
            // e.usp_registrar_actividad(t.descripcion,t.rol_creacion,t.
         
           // t.idactividad = Convert.ToInt32(cod.Value.ToString()); // opcional
            //dc.SaveChanges();
        }

        public void delete(usp_actividades_listar_all2_Result t)
        {
            //   dc.usp_Producto_Eliminar(t.IdProducto);
            //dc.SaveChanges();
            e.usp_eliminar_actividad(t.idactividad);
            //e.SaveChanges();
        }

        public usp_actividades_listar_all2_Result find(usp_actividades_listar_all2_Result t)
        {

               /* usp_actividades_listar_all2_Result dato = null;
               var pro = dc.usp_Productos_Datos(t.idactividad);
               var aux = e - usp_actividades_listar_all2_Result(t.idactividad);
               foreach (var item in pro)
               {
                   dato = new usp_actividades_listar_all2_Result()
                   {
                       /*IdProducto = item.IdProducto,
                       NombreProducto = item.NombreProducto,
                       IdProveedor = item.IdProveedor,
                       IdCategoría = item.IdCategoría,
                       PrecioUnidad = item.PrecioUnidad,
                       UnidadesEnExistencia = item.UnidadesEnExistencia
                       idactividad = irwm
                   };
               }
               return dato; */
            return null;
        }


        public usp_actividades_listar_all2_Result BuscarporDescripcion(usp_actividades_listar_all2_Result t)
        {
            //return e.usp_BusquedaActividadforDescripcion(t.descripcion);
            //return e.usp_participantes_listar_ponentes().ToList();
            usp_actividades_listar_all2_Result dato = null;
            var pro = e.usp_BusquedaActividadforDescripcion(t.descripcion);
            foreach (var item in pro)
            {
                dato = new usp_actividades_listar_all2_Result()
                {
                    idactividad = item.idactividad,
                    descripcion = item.descripcion,
                    fecha_creacion = item.fecha_creacion
                    /*  IdProducto=item.IdProducto,
                      NombreProducto=item.NombreProducto,
                      IdProveedor=item.IdProveedor,
                      IdCategoría=item.IdCategoría,
                      PrecioUnidad=item.PrecioUnidad,
                      UnidadesEnExistencia=item.UnidadesEnExistencia*/
                };
            }
            return dato;
        }
        public usp_actividades_listar_all2_Result BuscarporFecha(usp_actividades_listar_all2_Result t)
        {
          //  return e.usp_BusquedaActividadforDescripcion(t.fecha.ToString()).ToString();
            //return e.usp_participantes_listar_ponentes().ToList();


      usp_actividades_listar_all2_Result dato = null;
      var pro = e.usp_BusquedaActividadforFecha(t.fecha_creacion);
      foreach (var item in pro)   
          {
                dato = new usp_actividades_listar_all2_Result()
                { idactividad = item.idactividad,
                  descripcion = item.descripcion,
                  fecha_creacion = item.fecha_creacion
                  };
           }
           return dato; 

}

            public List<usp_actividades_listar_all2_Result> readAll()
            {
                return e.usp_actividades_listar_all2().ToList();
            }

            public void update(usp_actividades_listar_all2_Result t)
            {
            //dc.usp_Producto_Actualizar(t.NombreProducto, t.IdProveedor, t.IdCategoría, t.PrecioUnidad, t.UnidadesEnExistencia, t.IdProducto);
            //dc.SaveChanges();
            e.usp_actualizar_actividad(t.idactividad, t.descripcion, t.fecha_creacion);

            }
}
}
