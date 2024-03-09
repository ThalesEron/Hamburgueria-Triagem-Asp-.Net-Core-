using Hamburgueria.DATA.Infrastructure;
using Hamburgueria.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

