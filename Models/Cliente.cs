using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webapi.Models;

public class Cliente
{
    public Guid ClienteId {get;set;}
    public string Nombre {get;set;}
    public bigint Cedula {get;set;}
    public bigint Telefono {get;set;}
}