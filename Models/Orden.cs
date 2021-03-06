using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Orden
{
    [Key]
    public int OrdenId { get; set; }
    public DateTime Fecha { get; set; }

    [ForeignKey("OrdenId")]
    public virtual List<OrdenDetalle> OrdenDetalle { get; set; }

public Orden()
    {
        OrdenId = 0;
        Fecha = DateTime.Now;

        OrdenDetalle = new List<OrdenDetalle>();
    }
}