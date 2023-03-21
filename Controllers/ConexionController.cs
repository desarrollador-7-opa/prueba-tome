using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using prueba_tome;

namespace prueba_tome.Controllers;

[ApiController]
[Route("[controller]")]
public class ConexionController : ControllerBase
{
    [HttpGet(Name = "Conexion")]
    public void Get([FromServices] FachadaContext dbContext)
    {
        dbContext.Database.EnsureCreated();
        Console.WriteLine(Results.Ok("Base de datos Conectada"));
    }

}