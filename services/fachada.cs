
namespace webapi
{
    public class Fachada 
    {
        public Cupon EntregarCupones () 
        {
            var entregarCupon = EntregarCupon().EntregaCupon(RegistroCupon);
            var Cupon = entregarCupon;
            return Cupon;
        }
        public int GenerarCompras () 
        {
            var generarCompra = GenerarCompra();
            var total = generarCompra();
            return total;
        }
        public void GenerarTodosLosCupones ()
        {
            var generarCupones = GenerarCupones();
        }
    }
}

