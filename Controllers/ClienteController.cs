using Microsoft.AspNetCore.Mvc;
using prueba_tome.Dal;

namespace prueba_tome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController
    {
        [HttpGet(Name = "Cliente/{id}")]
        public IResult Get([FromServices] FachadaContext dbContext,  [FromRoute] long id)
        {
            if (id != 0)
            {
                return Results.Ok(dbContext.Clientes.Where(p => p.ClienteId == id));
            }
            else
            {
                return Results.Ok(dbContext.Clientes);
            }
        }
        [HttpPost(Name = "Cliente")]
        public IResult post([FromServices] FachadaContext dbContext, [FromBody] Cliente cliente)
        {
            dbContext.Add(cliente);
            dbContext.SaveChanges();
            return Results.Ok("Cliente Almacenado");
        }

        [HttpPut(Name = "Cliente")]
        public IResult put([FromServices] FachadaContext dbContext)
        {
            return Results.Ok("Cliente Modificado");
        }

        [HttpDelete(Name = "Cliente")]
        public string HttpDelete(int id)
        {
            return "NiceDELETE";
        }
    }
}
