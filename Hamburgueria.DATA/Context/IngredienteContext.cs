using Hamburgueria.DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace Hamburgueria.DATA.Context
{
    public class IngredienteContext : DbContext
    {
        public DbSet<IngredienteDto> Ingrediente { get; set; }

        public IngredienteContext(DbContextOptions<IngredienteContext> options) :
            base(options)
        {
        }
    }
}
