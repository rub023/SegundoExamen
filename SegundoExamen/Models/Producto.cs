using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegundoExamen.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        public Decimal Precio { get; set; }
        public string? Foto { get; set; }
    }
}
