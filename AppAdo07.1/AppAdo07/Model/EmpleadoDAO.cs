using AppAdo07.Database;
using AppAdo07.Entity;
using AppAdo07.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo07.Model
{
    public class EmpleadoDAO : ICrudDao<EmpleadoTO>
    {

        //variables
        Conexion oCon = new Conexion();
        bool ok;

        public bool create(EmpleadoTO t)
        {
            throw new NotImplementedException();
        }

        public bool delete(EmpleadoTO t)
        {
            throw new NotImplementedException();
        }

        public EmpleadoTO findForId(object t)
        {
            throw new NotImplementedException();
        }

        public List<EmpleadoTO> readAll()
        {
            throw new NotImplementedException();
        }

        public bool update(EmpleadoTO t)
        {
            throw new NotImplementedException();
        }

        public int validar(string nombre, string apellido)
        {
            int sw =0;
            try
            {
                List<SqlParameter> lista = new List<SqlParameter>();
                //crear objetos parametros
                SqlParameter nom = new SqlParameter("@Usuario", nombre);
                SqlParameter ape = new SqlParameter("@Clave", apellido);

                //agregar los objetos parametros a la coleccion list
                lista.Add(nom);
                lista.Add(ape);

                //ejecutar el sp
                SqlDataReader dr = oCon.runCursorStore("usp_Empleado_validar", lista);
                if (dr.Read())
                {
                    sw =Convert.ToInt32(dr[0].ToString());
                }
                dr.Close();
            }
            catch ( Exception ex)
            {
                throw ex;
            }
            return sw;
        }

    }
}

