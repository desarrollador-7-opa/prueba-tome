namespace webapi.Dal
{
    public class ProductoDto
    {
        public string? Nombre { get; set; }
        public int Valor { get; set; }
        public int TipoId { get; set; }
        public int Cantidad { get; set; }
    }
}