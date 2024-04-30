using Hamburgueria.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Context
{
    public class PratoXIngredienteContext : DbContext
    {

        public DbSet<PratosXIngrediente> PratosXIngrediente { get; set; }

        public PratoXIngredienteContext(DbContextOptions<PratoXIngredienteContext> options) :
            base(options)
        {
        }
    }
}

