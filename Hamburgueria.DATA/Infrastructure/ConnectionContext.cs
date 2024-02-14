using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace Hamburgueria.DATA.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        //public DbSet<Login> Logins { get; set; }
        //public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=1234");
        }
    }
}
