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
    public class EquipoBll
    {
        //variable de la clase EquipoDAO
        EquipoDAO dao;

        public EquipoBll()
        {
            dao = new EquipoDAO();
        }


        //metodos de persistencia de datos en sqlserver
        public void EquipoAdicionar(usp_equipo_listar_all_Result pro)
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

        public void EquipoActualizar(usp_equipo_listar_all_Result pro)
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

        public void EquipoEliminar(usp_equipo_listar_all_Result pro)
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


        public usp_equipo_listar_all_Result EquipoBuscar(usp_equipo_listar_all_Result pro)
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



        public List<usp_equipo_listar_all_Result> EquipoListar()
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
