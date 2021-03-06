using System.ComponentModel.DataAnnotations;

public class OrdenDetalle
{
    [Key]
    public int OrdenDetalleId { get; set; }
    public int OrdenId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }

    public OrdenDetalle()
    {
        OrdenDetalleId = 0;
        OrdenId = 0;
        ProductoId = 0;
        Cantidad = 0;
    }

    public OrdenDetalle(int ordenId, int productoId, int cantidad)
    {
        OrdenDetalleId = 0;
        OrdenId = 0;
        ProductoId = 0;
        Cantidad = 0;
    }
}