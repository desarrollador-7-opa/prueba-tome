using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webapi.Models
{
    public class CuponesCliente
    {
        [key]
        [Column("idcuponescliente", TypeName = "bigint")]
        public long CuponClienteId { get; set; }

        [Column("idcliente", TypeName = "bigint")]
        public long ClienteId { get; set; }

        [Column("idcupon", TypeName = "bigint")]
        public long CuponId { get; set; }
    }
}