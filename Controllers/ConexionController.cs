using Microsoft.AspNetCore.Mvc;

namespace prueba_tome.Controllers;

[ApiController]
[Route("[controller]")]
public class ConexionController : ControllerBase
{
    [HttpGet(Name = "Conexion")]
    public IResult Get([FromServices] FachadaContext dbContext)
    {
        dbContext.Database.EnsureCreated();
        return Results.Ok("DB conectada");
    }
}