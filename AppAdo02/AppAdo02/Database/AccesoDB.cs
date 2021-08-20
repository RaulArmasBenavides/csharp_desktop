using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppAdo02.Database
{
    public class AccesoDB
    {
        public static SqlConnection getConnection()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWind"].ConnectionString);
            return cn;
        }
    }
}
