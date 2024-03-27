using Hamburgueria.DATA.Infrastructure;
using Hamburgueria.DATA.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Repository
{
    public class PedidoRepository: IPedidoRepository
    {
        private readonly ConnectionContext _context = new();
    }
}
