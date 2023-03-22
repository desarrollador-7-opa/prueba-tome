using prueba_tome.Models;

namespace prueba_tome.Dal 
{
    public class ProductoDal
    {
        public Producto Create(Producto producto)
        {
            return producto;
        }
        public Producto Read(int id)
        {
            return new Producto();
        }
        public Producto Update(Producto producto, int id)
        {
            return producto;
        }
        public int Delete(int id)
        {
            return id;
        }
    }
}