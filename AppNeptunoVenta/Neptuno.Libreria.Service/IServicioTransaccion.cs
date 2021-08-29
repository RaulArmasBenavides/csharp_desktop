using System.Data.SqlClient;

namespace Neptuno.Libreria.Service
{
    public interface IServicioTransaccion<T>
    {
        #region Firmas
        int registrar(SqlConnection c, T t);
        #endregion
    }
}
