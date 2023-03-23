using prueba_tome.Dto;

namespace prueba_tome.Dal
{
    public class CuponesClienteDal
    {
        public CuponesCliente Create(CuponesCliente cuponesCliente)
        {
            return cuponesCliente;
        }
        public CuponesCliente Read(int id)
        {
            return new CuponesCliente();
        }
        public CuponesCliente Update(CuponesCliente cuponesCliente, int id)
        {
            return cuponesCliente;
        }
        public int Delete(int id)
        {
            return id;
        }
    }
}