using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstTaller.Models;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18,2)")]
    public decimal Precio { get; set; }
    
    public int Stock { get; set; }
}