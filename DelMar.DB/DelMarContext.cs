using DelMar.Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DelMar.DB
{
    public class DelMarContext : DbContext
    {

        public DelMarContext(DbContextOptions<DelMarContext> options) :base(options)
        {

        }

        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet <Proveedor> Proveedores { get; set; }
        public DbSet <Categoria> Categorias { get; set; }
    }
}
