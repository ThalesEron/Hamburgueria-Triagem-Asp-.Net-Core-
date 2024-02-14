using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace Hamburgueria.DATA.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        //public DbSet<Login> Logins { get; set; }
        //public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<IngredienteDTO> Ingredientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "ConnectionContext");
        }
    }
}
