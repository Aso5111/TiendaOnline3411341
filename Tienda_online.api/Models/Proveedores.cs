using System.ComponentModel.DataAnnotations;

namespace Tienda_online.api.Models
{
    public class Proveedores
    {
        [Key]
        [Required]
        public int IdProveedor { get; set; }
        [Required]
        [MaxLength(150)]

        public string Nombre { get; set; } = string.Empty;
        [Required]
        [MaxLength(150)]

        public string? Telefono { get; set; }
    }
}
