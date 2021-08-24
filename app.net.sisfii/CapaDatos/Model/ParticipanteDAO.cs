using appcongreso.EF;
using CapaDatos.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos.Model
{
    class ParticipanteDAO : Service<usp_participantes_listar_all_Result>
    {
        bdcongresoEntities e = new bdcongresoEntities();
        public void create(usp_participantes_listar_all_Result t)
        {
            e.usp_registrar_participante(t.ap_paterno, t.ap_materno, t.nombre, t.telefono, t.sexo, t.correo, t.DNI, t.carrera, t.direccion, t.tipo_participante);
        }

        public void delete(usp_participantes_listar_all_Result t)
        {
            e.usp_eliminar_participante(t.DNI);
        }

        public usp_participantes_listar_all_Result find(usp_participantes_listar_all_Result t)
        {
            usp_participantes_listar_all_Result dato = null;
            var pro = e.usp_participantes_datos(t.DNI);
            foreach (var item in pro)
            {
                dato = new usp_participantes_listar_all_Result()
                {
                    idparticipante = item.idparticipante,
                    nombre = item.nombre,
                    ap_paterno = item.ap_paterno,
                    ap_materno = item.ap_materno,
                    DNI = item.DNI,
                    correo = item.correo,
                    direccion = item.direccion,
                    tipo_participante = item.tipo_participante,
                    carrera = item.carrera,
                    sexo = item.sexo,
                    telefono = item.telefono
                };
            }
            return dato;
        }

        public List<usp_participantes_listar_all_Result> readAll()
        {
            return e.usp_participantes_listar_all().ToList();
        }

        public void update(usp_participantes_listar_all_Result t)
        {
            try
            {
                e.usp_actualiza_participante_oficial(t.ap_paterno, t.ap_materno, t.nombre, t.telefono, t.sexo, t.correo, t.DNI, t.direccion, t.tipo_participante);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
          //  e.SaveChanges();
        }

        //lista solo los estudiantes
        public List<usp_participantes_listar_estudiantes_Result> readAlumnos()
        {
            return e.usp_participantes_listar_estudiantes().ToList();  
        }

        //lista solo los profesionales
        public List<usp_participantes_listar_profesionales_Result> readProfesionales()
        {
            return e.usp_participantes_listar_profesionales().ToList();
        }

        public List<usp_participantes_listar_ponentes_Result> readPonentes()
        {
            return e.usp_participantes_listar_ponentes().ToList();
        }




    }
}
