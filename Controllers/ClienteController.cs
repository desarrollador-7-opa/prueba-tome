using Microsoft.AspNetCore.Mvc;
using prueba_tome.Models;

namespace prueba_tome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController
    {
        [HttpGet(Name = "Cliente")]
        public IResult Get([FromServices] FachadaContext dbContext)
        { return Results.Ok(dbContext.Clientes); }

        //public IResult GetById([FromServices] FachadaContext dbContext, long id)
        //{ return Results.Ok(dbContext.Clientes.Where(p => p.ClienteId == id)); }

        [HttpPost(Name = "Cliente")]
        public IResult post([FromServices] FachadaContext dbContext, [FromBody] Cliente cliente)
        {
            dbContext.Add(cliente);
            dbContext.SaveChanges();
            return Results.Ok("Cliente Almacenado");
        }

        [HttpPut(Name = "Cliente")]
        public string put(long id, string? nombre, long cedula, string? telefono)
        {
            return "NicePUT";
        }

        [HttpDelete(Name = "Cliente")]
        public string HttpDelete(int id)
        {
            return "NiceDELETE";
        }
    }
}
