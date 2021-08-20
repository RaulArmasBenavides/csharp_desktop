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
            throw new NotImplementedException();
        }

        public List<usp_participantes_listar_all_Result> readAll()
        {
            return e.usp_participantes_listar_all().ToList();
        }

        public void update(usp_participantes_listar_all_Result t)
        {
            e.usp_actualiza_participante(t.ap_paterno, t.ap_materno, t.nombre, t.telefono, t.sexo, t.correo, t.DNI, t.direccion, t.tipo_participante);
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
