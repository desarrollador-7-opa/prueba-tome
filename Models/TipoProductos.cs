using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace webapi.Models;

public class TipoProducto
{
    [Key]
    [Column("TipoId", TypeName = ("bigint"))]
    public Guid TipoId {get;set;}

    [Column("Nombre",TypeName  = ("Varchar(100"))]
    public string Nombre {get;set; } = string.Empty;

    [Column("Descripcion", TypeName = ("Varchar(100"))]
    public string Descripcion {get;set; } = string.Empty;
}