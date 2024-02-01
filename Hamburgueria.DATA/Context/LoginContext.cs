using Hamburgueria.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hamburgueria.DATA.Context
{
    public class LoginContext : DbContext
    {
        public DbSet<Login> Login { get; set; }

        public LoginContext(DbContextOptions<LoginContext> options) :
            base(options)
        {
        }

    }
}
