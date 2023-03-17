using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webapi.Models
{
    public class CuponesCliente
    {
        [key]
        public Guid CuponClienteId { get; set; }
        public int ClienteId { get; set; }
        public int CuponId { get; set; }
    }
}