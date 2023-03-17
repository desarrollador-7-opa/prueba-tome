using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webapi.Models;

public class Cliente
{
    [key]
    public Guid ClienteId {get;set;}
    public string Nombre {get;set;}
    public int Cedula {get;set;}
    public string Telefono {get;set;}
}