namespace webapi.Dal
{
    public class CuponDto
    {
        public int Valor { get; set; }
        public string? Estado { get; set; }
        public string? Entregado { get; set; }
        public DateTime FechaVence { get; set; }
    }
}
