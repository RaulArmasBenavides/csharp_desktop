using appcongreso.EF;
using CapaDatos.DataBase;
using CapaDatos.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos.Model
{
    public class UsuarioDAO : Service<usp_usuarios_listar_all_Result>
    {

        //clases 
        //SqlCommand cmd;
        //SqlDataReader dr;

        bdcongresoEntities e = new bdcongresoEntities();
        
        //crear usuario
        public void create(usp_usuarios_listar_all_Result t)
        {
            //throw new NotImplementedException();
            e.usp_registrar_usuario(t.usuario, t.clave);

        }
        //eliminar usuario
        public void delete(usp_usuarios_listar_all_Result t)
        {
            //throw new NotImplementedException();
            e.usp_eliminar_usuario(t.usuario);
        }
        //encontrar usuarios
        public usp_usuarios_listar_all_Result find(usp_usuarios_listar_all_Result t)
        {
            throw new NotImplementedException();
        }
        //listar usuarios
        public List<usp_usuarios_listar_all_Result> readAll()
        {
            return e.usp_usuarios_listar_all().ToList();
        }
        //actualizar usuarios
        public void update(usp_usuarios_listar_all_Result t)
        {
            e.usp_actualizar_usuario(t.usuario, t.clave);
        }


        //string usuario, string clave

        public ObjectResult<usp_ValidaUsuario_Result> validar(usp_usuarios_listar_all_Result t)
        {

            return  e.usp_ValidaUsuario(t.usuario, t.clave);
            //try
            //{
            //    if (Convert.ToInt32(e.usp_ValidaUsuario(t.usuario, t.clave)) == 1)
            //        return 1;
            //    else
            //        return 0;
            //}
            //catch (SqlException ex)
            //{
            //    throw ex;
            //}

        }

        /* public usp_usuarios_listar_all_Result validar(usp_usuarios_listar_all_Result t)
            {   
                MessageBox.Show(" 1 " + t.usuario);
                MessageBox.Show(" 2 " + t.clave);


                return e.ValidaUsuario(t.usuario, t.clave);
                //return e.ValidaUsuario(t.usuario, t.clave);
                //MessageBox.Show(" el x es " + x);

                /*if(x==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               

    }*/

    }
}
