using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace Hamburgueria.DATA.Context
{
    public class IngredienteContext : DbContext
    {
        public DbSet<Ingrediente> Ingrediente { get; set; }

        public IngredienteContext(DbContextOptions<IngredienteContext> options) :
            base(options)
        {
        }
    }
}
