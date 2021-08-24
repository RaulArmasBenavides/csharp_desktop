using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appcongreso.EF;
using System.Threading.Tasks;
using CapaDatos.Service;
using System.Data.Entity.Core.Objects;

namespace appcongreso.Model
{
    public class AsistenciasDAO : Service<usp_asistencias_Result>
    {
        // entidades  usando ENTITY FRAMEWORK
        bdcongresoEntities entidades = new bdcongresoEntities();
        public void create(usp_asistencias_Result t)
        {
            throw new NotImplementedException();
        }

        public void delete(usp_asistencias_Result t)
        {
            throw new NotImplementedException();
        }

        public List<usp_asistencias_Result> find(usp_asistencias_Result t)
        {

            //usp_asistencias_Result dato = null;
            var pro = entidades.usp_asistencias(t.codigo);
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







        public List<usp_asistencias_oficial_Result> find2(usp_asistencias_oficial_Result t)
        {

            //usp_asistencias_Result dato = null;
            var pro = entidades.usp_asistencias_oficial(t.codigo);
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

        public List<usp_asistencias_listar_all_Result> readAll2()
        {
            return entidades.usp_asistencias_listar_all("").ToList();
        }













        public usp_asistencias_datos_codigo_Result Leer_asistencia_cabecera (usp_asistencias_Result t)
        {


            usp_asistencias_datos_codigo_Result dato = null;
            var pro = entidades.usp_asistencias_datos_codigo(t.codigo);
            foreach (var item in pro)
            {
                dato = new usp_asistencias_datos_codigo_Result()
                {
                    idasistencias = item.idasistencias
                     
                };
            }

           return dato; 
        } 



        public void update(usp_asistencias_Result t)
        {
            throw new NotImplementedException();
        }



        public void RegistrarListaAsistentes(string codigo , List<usp_asistencias_Result> lista , bool Esnuevo)
        {

            if(Esnuevo)
            {  //registro nuevo
                entidades.usp_registrar_asistencia(codigo);
            }
             if(lista.Count >0)
             RegistrarDetalleCabecera(codigo, lista, Esnuevo);
        }
        public void RegistrarDetalleCabecera(string codigo, List<usp_asistencias_Result> lista, bool Esnuevo)
        {
            if(!Esnuevo)
            {
                entidades.usp_borrar_det_asistencia(codigo);
            }
          
            foreach (var item in lista)
            {
                entidades.usp_registrar_det_asistencia(item.DNI, item.codigo);
            }
        }

        public List<usp_asistencias_Result> readAll()
        {
            throw new NotImplementedException();
        }

        usp_asistencias_Result Service<usp_asistencias_Result>.find(usp_asistencias_Result t)
        {
            throw new NotImplementedException();
        }
    }
}
