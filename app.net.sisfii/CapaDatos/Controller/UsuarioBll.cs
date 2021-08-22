using appcongreso.EF;
using CapaDatos.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Controller
{
    public  class UsuarioBll
    {
            //variable de la clase usuarioeDAO
            UsuarioDAO dao;
            //constructor
            public UsuarioBll()
            {
                dao = new UsuarioDAO();
            }
            //metodos de persistencia de datos en sqlserver
            public void usuarioAdicionar(usp_usuarios_listar_all_Result pro)
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
            public void usuarioActualizar(usp_usuarios_listar_all_Result pro)
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
            public void usuarioEliminar(usp_usuarios_listar_all_Result pro)
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

            public usp_usuarios_listar_all_Result usuarioBuscar(usp_usuarios_listar_all_Result pro)
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
            public List<usp_usuarios_listar_all_Result> usuarioListar()
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

        public ObjectResult<usp_ValidaUsuario_Result> UsuarioValidar(usp_usuarios_listar_all_Result usuario)
        {
            try
            {
                return dao.validar(usuario);
            }
            catch (Exception)
            {

                return null;
            }
        
        }

    } 
}
