using Microsoft.AspNetCore.Mvc;

namespace prueba_tome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController
    {
        [HttpGet(Name = "Cliente")]
        public IResult Get([FromServices] FachadaContext dbContext) 
            { return Results.Ok(dbContext.Clientes); }
        
        [HttpGet(Name = "Cliente{ID:int}")]
        public IResult GetById<ID>([FromServices] FachadaContext dbContext) 
            { return Results.Ok(dbContext.Clientes); }

        [HttpPost(Name = "Cliente")]
        public string post(long id, string? nombre, long cedula, string? telefono)
        {
            return "NicePOST";
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
