using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prueba_tome.Models
{
    public class CuponesCliente
    {
        [Key]
        [Column("idcuponescliente", TypeName = "bigint")]
        public long CuponClienteId { get; set; }

        [Required]
        [Column("idcliente", TypeName = "bigint")]
        public long ClienteId { get; set; }

        [Required]
        [Column("idcupon", TypeName = "bigint")]
        public long CuponId { get; set; }
    }
}