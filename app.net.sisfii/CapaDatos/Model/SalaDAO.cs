using appcongreso.EF;
using CapaDatos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appcongreso.Model
{
    public class SalaDAO : Service<usp_salas_listar_all_Result>
    {
        bdcongresoEntities e = new bdcongresoEntities();
        public void create(usp_salas_listar_all_Result t)
        {
            //throw new NotImplementedException();
            e.usp_registrar_sala(t.nombre, t.ubicacion, t.capacidad, t.rol_creacion);
        }

        public void delete(usp_salas_listar_all_Result t)
        {
            throw new NotImplementedException();
        }

        public usp_salas_listar_all_Result find(usp_salas_listar_all_Result t)
        {
            throw new NotImplementedException();
        }

        public List<usp_salas_listar_all_Result> readAll()
        {
            return e.usp_salas_listar_all().ToList();
        }

        public void update(usp_salas_listar_all_Result t)
        {
            throw new NotImplementedException();
        }
    }
}
