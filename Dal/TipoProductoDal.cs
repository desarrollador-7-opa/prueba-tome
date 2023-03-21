using webapi.Models;

namespace webapi.Dal 
{
    public class TipoProductoDal
    {
        public TipoProducto Create(TipoProducto categoria)
        {
            return categoria;
        }
        public TipoProducto Read(int id)
        {
            return new TipoProducto();
        }
        public TipoProducto Update(TipoProducto categoria, int id)
        {
            return categoria;
        }
        public int Delete(int id)
        {
            return id;
        }
    }
}