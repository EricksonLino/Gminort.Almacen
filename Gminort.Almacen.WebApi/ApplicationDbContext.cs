using Gminort.Almacen.WebApi.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Gminort.Almacen.WebApi
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
