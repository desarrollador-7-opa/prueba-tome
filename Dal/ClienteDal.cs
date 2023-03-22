using prueba_tome.Models;

namespace prueba_tome.Dal 
{
    public class ClienteDal
    {
        public Cliente Create(Cliente cliente)
        {
            return cliente;
        }
        public Cliente Read(int id)
        {
            return new Cliente();
        }
        public Cliente Update(Cliente cliente, int id)
        {
            return cliente;
        }
        public int Delete(int id)
        {
            return id;
        }
    }
}