using Hamburgueria.DATA.Infrastructure;
using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Models;

namespace Hamburgueria.DATA.Repository
{
    public class PratosRepository : IPratosRepository
    {

        private readonly ConnectionContext _context = new();

        public void CadastrarPrato(Pratos prato)
        {
            _context.Pratos.Add(prato);
            _context.SaveChanges();
        }

        public Pratos GetPratoByName(string nomePrato)
        {
            return _context.Pratos.Where(a => a.NomePrato.ToLower() == nomePrato.ToLower() && a.Ativo == true).ToList().FirstOrDefault();
        }
    }
}
