using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appcongreso.EF;

namespace appcongreso.Model
{
    public class ListaEquiposDAO
    {

        // entidades  usando ENTITY FRAMEWORK
        bdcongresoEntities entidades = new bdcongresoEntities();


        public List<usp_lista_equipos_oficial_Result> find(usp_lista_equipos_oficial_Result t)
        {

            //usp_asistencias_Result dato = null;
            var pro = entidades.usp_lista_equipos_oficial(t.codigo);
            //foreach (var item in pro)
            //{
            //    dato = new usp_asistencias_Result()
            //    {
            //        ap_materno =item.ap_materno,
            //        ap_paterno = item.ap_paterno,
            //        DNI = item.DNI
            //        //IdProducto = item.IdProducto,
            //        //NombreProducto = item.NombreProducto,
            //        //IdProveedor = item.IdProveedor,
            //        //IdCategoría = item.IdCategoría,
            //        //PrecioUnidad = item.PrecioUnidad,
            //        //UnidadesEnExistencia = item.UnidadesEnExistencia
            //    };
            //}
            return pro.ToList();
            //hrow new NotImplementedException();
        }

        public void RegistrarListaEquipos(string codigo, List<usp_lista_equipos_oficial_Result> lista, bool Esnuevo)
        {


            if (Esnuevo)
            {  //registro nuevo
                entidades.usp_registrar_lista_equipos(codigo);
            }
            if (lista.Count > 0)
            RegistrarDetalleCabecera(codigo, lista,Esnuevo);
        }
        public void RegistrarDetalleCabecera(string codigo, List<usp_lista_equipos_oficial_Result> lista, bool Esnuevo)
        {
            if (!Esnuevo)
            {
                entidades.usp_borrar_det_asistencia(codigo);
            }
            foreach (var item in lista)
            {

               entidades.usp_registrar_det_list_equipos(item.idEquipo, item.codigo);
            }
        }
    }
}
