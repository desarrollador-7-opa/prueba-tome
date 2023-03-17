using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webapi.Models;

public class Cupon
{
    [primarykey]
    public Guid CuponId {get;set;}
    public int Valor {get;set;}
    public string Estado {get;set;}
    public string Entregado {get;set;}
    public string QR {get;set;}
    public DateTime fechaVence {get;set;}
}