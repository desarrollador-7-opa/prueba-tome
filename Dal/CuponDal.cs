using prueba_tome.Models;

namespace prueba_tome.Dal 
{
    public class CuponDal
    {
        public Cupon Create(Cupon cupon)
        {
            return cupon;
        }
        public Cupon Read(int id)
        {
            return new Cupon();
        }
        public Cupon Update(Cupon cupon, int id)
        {
            return cupon;
        }
        public int Delete(int id)
        {
            return id;
        }
    }
}