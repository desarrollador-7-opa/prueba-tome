using webapi.Funtions;
namespace webapi
{
    public class Fachada
    {
        public string FunEntregarCupones()
        {
            var entregarCupon = new EntregarCupon();
            return entregarCupon.EntregarCupones();
        }
        public string FunGenerarCompra()
        {
            var generarCompra = new GenerarCompra();
            return generarCompra.GenerarCompras();
        }
        public string FunGenerarCupones()
        {
            var generarCupones = new GenerarCupones();
            return generarCupones.GenerarCuponesMasivos();
        }
        public string FunIngresarCliente()
        {
            var ingresarCliente = new IngresarCliente();
            return ingresarCliente.IngresarClientes();
        }
        public string FunRedimirCupon()
        {
            var redimirCupon = new RedimirCupon();
            return redimirCupon.RedimirCupones();
        }
        public string FunValidarCupon()
        {
            var validarCupon = new ValidarCupon();
            return validarCupon.ValidarCupones();
        }
        public string FunValidarExisteCliente()
        {
            var validarExisteCliente = new ValidarExisteCliente();
            return validarExisteCliente.ValidarExisteClientes();
        }
    }
}