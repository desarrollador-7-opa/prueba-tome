using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prueba_tome.Models
{
    public class Cupon
    {
        [Key]
        [Column("idcupon", TypeName = "bigint")]
        public long CuponId { get; set; }

        [Required]
        [Column("valor", TypeName = "numeric(18,0)")]
        public int Valor { get; set; }

        [Column("estado", TypeName = "char(1)")]
        public string? Estado { get; set; } = string.Empty;

        [Column("entregado", TypeName = "char(1)")]
        public string? Entregado { get; set; } = string.Empty;

        [Required]
        [Column("fechavence", TypeName = "datetime")]
        public DateTime FechaVence { get; set; }
    }
}