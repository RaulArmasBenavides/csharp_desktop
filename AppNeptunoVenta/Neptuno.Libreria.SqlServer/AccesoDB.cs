using System.Configuration;

namespace Neptuno.Libreria.SqlServer
{
    public class AccesoDB
    {

        #region Conexion a BD

        //propiedad
        public string CadenaConexion { get; set; }

        //constructor
        public AccesoDB()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["neptuno"].ConnectionString;
        }
        #endregion

    }
}
