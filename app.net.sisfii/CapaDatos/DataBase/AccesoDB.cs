using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.DataBase
{
    public class AccesoDB
    {
        public static SqlConnection Conexion()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bdcongresoEntities"].ConnectionString);
            return cn;
        }
    }
}
