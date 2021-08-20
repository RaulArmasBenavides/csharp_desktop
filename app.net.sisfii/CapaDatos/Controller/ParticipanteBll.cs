using appcongreso.EF;
using CapaDatos.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Controller
{
    public class ParticipanteBll
    {
        //variable de la clase ParticipanteDAO
        ParticipanteDAO dao;
        //constructor
        public ParticipanteBll()
        {
            dao = new ParticipanteDAO();
        }

        //metodos de persistencia de datos en sqlserver
        public void ParticipanteAdicionar(usp_participantes_listar_all_Result pro)
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

        public void ParticipanteActualizar(usp_participantes_listar_all_Result pro)
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

        public void ParticipanteEliminar(usp_participantes_listar_all_Result pro)
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

        public usp_participantes_listar_all_Result ParticipanteBuscar(usp_participantes_listar_all_Result pro)
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



        public List<usp_participantes_listar_all_Result> ParticipanteListar()
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

        public List<usp_participantes_listar_estudiantes_Result> ParticipanteAlumnoListar()
        {
            try
            {
                return dao.readAlumnos();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<usp_participantes_listar_ponentes_Result> ParticipantePonenteListar()
        {
            try
            {
                return dao.readPonentes();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<usp_participantes_listar_profesionales_Result> ParticipanteProfesionalListar()
        {
            try
            {
                return dao.readProfesionales();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }




        /* 
        public List<usp_Proveedor_Listar_Result> ProveedorListar()
        {
            try
            {
                return dao.listaProveedores();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<usp_Categoria_Listar_Result> CategoriaListar()
        {
            try
            {
                return dao.listaCategoria();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        */
    }
}
