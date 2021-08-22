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



        //public List<usp_sala_listar_all_Result> SalaListar()
        //{
        //    try
        //    {
        //        return dao.readAll();
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
