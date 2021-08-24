using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appcongreso.EF;
using System.Threading.Tasks;
using appcongreso.Model;
using System.Data.SqlClient;

namespace appcongreso.Controller
{
    public class ListaEquiposBll
    {
        ListaEquiposDAO dao = new ListaEquiposDAO();


        public List<usp_lista_equipos_oficial_Result> ListaEquipoCodigo(usp_lista_equipos_oficial_Result pro)
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
        public void RegistrarListaEquipo(string codigo, List<usp_lista_equipos_oficial_Result> pro, bool EsNuevo)
        {
            try
            {
                dao.RegistrarListaEquipos(codigo, pro, EsNuevo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<usp_listaequipos_listar_all_Result> ListarAll2()
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

    }
}
