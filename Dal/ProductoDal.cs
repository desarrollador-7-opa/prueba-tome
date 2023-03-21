namespace webapi.Dal 
{
    public class ProductoDal
    {
        public Producto Create(Producto producto)
        {
            return Producto;
        }
        public Producto Read(int id)
        {
            return new Producto();
        }
        public Producto Update(Producto producto, int id)
        {
            return Producto;
        }
        public Producto Delete(int id)
        {
            return id;
        }
    }
}