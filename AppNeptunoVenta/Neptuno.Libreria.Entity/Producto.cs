
namespace Neptuno.Libreria.Entity
{
    public class Producto
    {
      #region Propiedades
        // propiedades
      public int IdProducto { get; set; }
      public string NombreProducto { get; set; }
      public int IdProveedor { get; set; }
      public int IdCategoria { get; set; }
      public decimal PrecioUnidad { get; set; }
      public short Stock { get; set; }
      #endregion
    }

}
