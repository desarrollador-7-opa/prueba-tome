using Microsoft.EntityFrameworkCore;
using prueba_tome.Models;

namespace prueba_tome;

public class FachadaContext: DbContext
{
    public DbSet<Cliente> Categorias {get;set;}
    public DbSet<Cupon> Cupones {get;set;}
    public DbSet<CuponesCliente> CuponesClientes {get;set;}
    public DbSet<Producto> Productos {get;set;}
    public DbSet<TipoProducto> TipoProductos {get;set;}
    public FachadaContext(DbContextOptions<FachadaContext> options) :base(options) { }
}