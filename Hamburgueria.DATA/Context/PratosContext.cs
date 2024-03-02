using Hamburgueria.DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace Hamburgueria.DATA.Context
{
    public class PratosContext : DbContext
    {
        public DbSet<Pratos> Pratos { get; set; }

        public PratosContext(DbContextOptions<PratosContext> options) :
            base(options)
        {
        }
    }
}
