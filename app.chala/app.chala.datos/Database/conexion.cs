using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.cochachi.datos.Database
{
    public class conexion
    {   
        string cadena = "Data Source=localhost;Initial Catalog=dbEncargos;Integrated Security=True";

        public conexion()
        {

        }
        public SqlConnection getConexion()
        {
            try
            {
                //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Neptuno"].ConnectionString);
                SqlConnection cn = new SqlConnection(cadena);
                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

    }
}
