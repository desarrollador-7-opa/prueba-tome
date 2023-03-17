using webapi.Funtions;
namespace webapi
{
    public class Fachada 
    {
        public string EntregarCupones () 
        {
            var entregarCupon = new EntregarCupon();
            return entregarCupon.EntregarCupones();
        }
        public string GenerarCompra () 
        {
            var generarCompra = new GenerarCompra();
            return generarCompra.GenerarCompras();
        }
    }
}