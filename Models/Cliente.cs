using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace webapi.Models
{

    public class Cliente
    {
        [Key]
        [Column("idcliente",TypeName = "bigint")]
        public long ClienteId { get; set; }

        [Column("nombreintegrado", TypeName = "varchar(100)")]
        public string Nombre { get; set; }

        [Column("cedula", TypeName = "bigint")]
        public long Cedula { get; set; }

        [Column("telefono", TypeName = "varchar(20)")]
        public string Telefono { get; set; }
    }

}