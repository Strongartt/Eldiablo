using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Introduccion.Models
{
    public class Pais
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [AllowNull]

    }
}
