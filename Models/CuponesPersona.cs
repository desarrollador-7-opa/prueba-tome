using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webapi.Models;

public class CuponesCliente
{
    [primarykey]
    public Guid CuponClienteId {get;set;}
    public Cliente.ClienteId ClienteId {get;set;}
    public Cupon.CuponId CuponId {get;set;}
}