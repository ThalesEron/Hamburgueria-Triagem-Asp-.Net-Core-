using Hamburgueria.DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace Hamburgueria.DATA.Context
{
    public class PedidoContext : DbContext
    {
        public DbSet<Pedido> Pedido { get; set; }

        public PedidoContext(DbContextOptions<PedidoContext> options) :
            base(options)
        {
        }
    }
}
