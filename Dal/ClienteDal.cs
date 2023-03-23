using prueba_tome.Dto;

namespace prueba_tome.Dal 
{
    public class ClienteDal
    {
//********************************************************
        public IResult Create(FachadaContext dbContext)
        {
            return Results.Ok(dbContext.Clientes);
        }
        public IResult Read(FachadaContext dbContext,long id)
        {
            return Results.Ok(dbContext.Clientes);
        }
// Falta el where en el read
//********************************************************
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