using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webapi.Models;

public class TipoProducto
{
    [Key]
    public Guid TipoId {get;set;}
    public string Nombre {get;set;}
    public string Descripcion {get;set;}
}