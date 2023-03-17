using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webapi.Models
{
    public class Producto
    {
        [Key]
        public Guid ProductoId { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; }
        public int TipoId { get; set; }
        public int Cantidad { get; set; }
    }
}