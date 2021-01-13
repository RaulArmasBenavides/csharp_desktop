using app.cochachi.datos;
using app.cochachi.datos.Entidades;
using com.app.comprobante.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.chala.negocios
{
    public class ChalaBo
    {
        ChalaDo _doChala = new ChalaDo();




        public void InsertarPersonal(Personal pe)
        {
            try
            {
                _doChala.InsertarPersonal(pe);
        
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataSet LeerTodoPersonal()
        {
            try
            {
                return _doChala.LeerTodoPersonal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
   
        }



        public void Insertar(ActaComprobanteTO comp)
        {
            try
            {
                _doChala.InsertarActaComprobante(comp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet LeerTodoActa()
        {

            return _doChala.LeerTodoActa();
        }
    }
}
