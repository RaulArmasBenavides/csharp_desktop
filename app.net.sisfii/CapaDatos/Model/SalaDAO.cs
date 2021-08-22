using appcongreso.EF;
using CapaDatos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appcongreso.Model
{
    public class SalaDAO : Service<usp_sala_listar_all_Result>
    {
        bdcongresoEntities e = new bdcongresoEntities();
        public void create(usp_sala_listar_all_Result t)
        {
            try
            {
                e.usp_registrar_sala(t.nombre, t.ubicacion, t.capacidad, t.rol_creacion,t.tipo_sala);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public void delete(usp_sala_listar_all_Result t)
        {
            try
            {
                e.usp_eliminar_sala(t.idsala);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public usp_sala_listar_all_Result find(usp_sala_listar_all_Result t)
        {
            usp_sala_listar_all_Result dato = null;
            var pro = e.usp_sala_datos(t.nombre);
            foreach (var item in pro)
            {
                dato = new usp_sala_listar_all_Result()
                {
                    idsala = item.idsala,
                    nombre = item.nombre,
                    capacidad = item.capacidad,
                    tipo_sala = item.tipo_sala
                    //IdProducto = item.IdProducto,
                    //NombreProducto = item.NombreProducto,
                    //IdProveedor = item.IdProveedor,
                    //IdCategoría = item.IdCategoría,
                    //PrecioUnidad = item.PrecioUnidad,
                    //UnidadesEnExistencia = item.UnidadesEnExistencia
                };
            }
            return dato;
        }

        public List<usp_sala_listar_all_Result> readAll()
        {
            return e.usp_sala_listar_all().ToList();
        }

        public void update(usp_sala_listar_all_Result t)
        {
            try
            {
                e.usp_actualiza_sala(t.idsala, t.nombre, t.ubicacion, t.capacidad, t.tipo_sala);
            }
            catch (Exception)
            {

                throw;
            }
         
        }
    }
}
