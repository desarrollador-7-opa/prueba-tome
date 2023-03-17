using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Schema;

namespace webapi.Models
{

    public class Producto
    {
        [Key]
        [Column("ProductoId", TypeName = ("bigint"))]
        public Guid ProductoId { get; set; }

        [Column("Nombre", TypeName = ("varchar(100)"))]
        public string? Nombre { get; set; } = string.Empty;

        [Column("Valor", TypeName = ("decimal(18,2)"))]
        public int Valor { get; set; }

        [Column("TipoId", TypeName = ("numeric(18,0)"))]

        public int TipoId { get; set; }

        [Column("Cantidad", TypeName = ("numeric(18,0)"))]
        public int Cantidad { get; set; }
    }
}