using Hamburgueria.DATA.Infrastructure;
using Hamburgueria.DATA.Interfaces;

namespace Hamburgueria.DATA.Repository
{
    public class PratosRepository : IPratosRepository
    {

        private readonly ConnectionContext _context = new();

    }
}
