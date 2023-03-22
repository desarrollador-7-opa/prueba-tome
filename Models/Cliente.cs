using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prueba_tome.Models
{
    public class Cliente
    {
        [Key]
        [Column("idcliente",TypeName = "bigint")]
        public long ClienteId { get; set; }

        [Required]
        [Column("nombreintegrado", TypeName = "varchar(100)")]
        public string? Nombre { get; set; }

        [Required]
        [Column("cedula", TypeName = "bigint")]
        public long Cedula { get; set; }

        [Required]
        [Column("telefono", TypeName = "varchar(20)")]
        public string? Telefono { get; set; }
    }
}