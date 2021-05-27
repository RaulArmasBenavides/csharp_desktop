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
    public class ActividadBll
    {
        //variable de la clase actividadeDAO
        ActividadDAO dao;
        //constructor
        public ActividadBll()
        {
            dao = new ActividadDAO();
        }

        //metodos de persistencia de datos en sqlserver
        public void actividadeAdicionar(usp_actividades_listar_all_Result pro)
        {
            try
            {
                dao.create(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void actividadeActualizar(usp_actividades_listar_all_Result pro)
        {
            try
            {
                dao.update(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void actividadeEliminar(usp_actividades_listar_all_Result pro)
        {
            try
            {
                dao.delete(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public usp_actividades_listar_all_Result actividadeBuscar(usp_actividades_listar_all_Result pro)
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

        public List<usp_actividades_listar_all_Result> actividadeListar()
        {
            try
            {
                return dao.readAll();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
