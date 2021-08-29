
namespace Neptuno.Libreria.Entity
{
    public class Detalle
    {
       #region Propiedades
        // propiedades
       public int IdVenta { get; set; }
       public int IdProducto { get; set; }
       public decimal Precio { get; set; }
       public int Cantidad { get; set; }
       public int Descuento { get; set; }
       #endregion
    }
}
