namespace webapi.Dal 
{
    public class TipoProductoDal
    {
        public Categoria Create(Categoria categoria)
        {
            return Categoria;
        }
        public Categoria Read(int id)
        {
            return new Categoria();
        }
        public Categoria Update(Categoria categoria, int id)
        {
            return Categoria;
        }
        public Categoria Delete(int id)
        {
            return id;
        }
    }
}