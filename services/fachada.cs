namespace webapi
{
    public class Fachada 
    {
        public Cupon EntregarCupon () 
        {
            var entregarCupon = EntregarCupon();
            var Cupon = entregarCupon();
            return Cupon;
        }
        public int GenerarCompra () 
        {
            var generarCompra = GenerarCompra();
            var total = generarCompra();
            return total;
        }
    }
}

