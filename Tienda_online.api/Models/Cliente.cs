using System.ComponentModel.DataAnnotations;

namespace Tienda_online.api.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int IdCliente { get; set; }
        [Required]
        [MaxLength(150)]

        public string Nombre { get; set; } = string.Empty;
        [Required]
        [MaxLength(150)]

        public string Email { get; set; } = string.Empty;
        [Required]
        [MaxLength(20)]

        public string? Telefono { get; set; }
    }
}
