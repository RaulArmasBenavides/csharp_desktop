using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appcongreso.EF;
using CapaDatos.Service;

namespace appcongreso.Model
{
    public class EquipoDAO : Service<usp_equipo_listar_all_Result>
    {
        // entidades  usando ENTITY FRAMEWORK
        bdcongresoEntities e = new bdcongresoEntities();
        public void create(usp_equipo_listar_all_Result t)
        {
            try
            {
                e.usp_registrar_Equipo(t.Nombre,t.Procesador,t.RAM,t.SO,t.TarjetaMadre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(usp_equipo_listar_all_Result t)
        {
            e.usp_eliminar_Equipo(t.idEquipo);
        }

        public usp_equipo_listar_all_Result find(usp_equipo_listar_all_Result t)
       {
            //usp_participantes_listar_all_Result dato = null;
            //var pro = e.usp_participantes_datos(t.DNI);
            //foreach (var item in pro)
            //{
            //    dato = new usp_participantes_listar_all_Result()
            //    {
            //        idparticipante = item.idparticipante,
            //        nombre = item.nombre,
            //        ap_paterno = item.ap_paterno,
            //        ap_materno = item.ap_materno,
            //        DNI = item.DNI,
            //        correo = item.correo,
            //        direccion = item.direccion,
            //        tipo_participante = item.tipo_participante,
            //        carrera = item.carrera,
            //        sexo = item.sexo,
            //        telefono = item.telefono
            //    };
            //}
            //    return dato;
            throw new NotImplementedException();
        }

        public List<usp_equipo_listar_all_Result> readAll()
        {
            return e.usp_equipo_listar_all().ToList();
        }

        public void update(usp_equipo_listar_all_Result t)
        {
            throw new NotImplementedException();
        }
    }
}
