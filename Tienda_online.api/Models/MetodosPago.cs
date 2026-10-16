
using System.ComponentModel.DataAnnotations;

namespace Tienda_online.api.Models
{
    public class MetodosPago
    {
        [Key]
        [Required]
        public int IdMetodoPago { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; } = string.Empty;
    }
}
