using appcongreso.EF;
using appcongreso.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appcongreso.Controller
{
    public class AsistenciasBll
    {

        //variable de la clase usuarioeDAO
        AsistenciasDAO dao;
        //constructor
        public AsistenciasBll()
        {
            dao = new AsistenciasDAO();
        }

        public List<usp_asistencias_Result> ListaAsistenciaCodigo(usp_asistencias_Result pro)
        {
            try
            {
                return dao.find(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<usp_asistencias_oficial_Result> ListaAsistenciaOficial(usp_asistencias_oficial_Result pro)
        {
            try
            {
                return dao.find2(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public usp_asistencias_datos_codigo_Result Leer_asistencia_cabecera(usp_asistencias_Result pro)
        {
            try
            {
                return dao.Leer_asistencia_cabecera(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }



        
        public List<usp_asistencias_listar_all_Result> ListarAll2()
        {
            try
            {
                return dao.readAll2();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public void RegistrarListaAsistentes(string codigo , List<usp_asistencias_Result> pro, bool Esnuevo)
        {
            try
            {
               dao.RegistrarListaAsistentes(codigo, pro, Esnuevo);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


    }
}
