using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webapi.Models
{

    public class Cupon
    {
        [key]
        [Column("idcupon", TypeName = "bigint")]
        public Guid CuponId { get; set; }

        [Column("valor", TypeName = "numeric(18,0)")]
        public int Valor { get; set; }

        [Column("estado", TypeName = "char(1)")]
        public string Estado { get; set; }

        [Column("entregado", TypeName = "char(1)")]
        public string Entregado { get; set; }

        [Column("fechavence", TypeName = "datetime")]
        public DateTime FechaVence { get; set; }
    }
}