using webapi.Models;

namespace webapi.Dal 
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