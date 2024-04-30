using Hamburgueria.DATA.Infrastructure;
using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Models;
using Microsoft.EntityFrameworkCore;

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

        public void DeletarPrato(Pratos prato)
        {
            _context.Entry(prato).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EditarPrato(Pratos prato)
        {
            var buscarPrato = _context.Pratos.Find(prato.Codigo);

            if(buscarPrato != null)
            {
                _context.Entry(buscarPrato).CurrentValues.SetValues(prato);
                _context.Entry(buscarPrato).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public Pratos GetPratoById(int pratoId)
        {
            return _context.Pratos.Where(a => a.Codigo == pratoId && a.Ativo == true).ToList().FirstOrDefault();
        }

        public Pratos GetPratoByName(string nomePrato)
        {
            return _context.Pratos.Where(a => a.NomePrato.ToLower() == nomePrato.ToLower() && a.Ativo == true).ToList().FirstOrDefault();
        }

        public IList<Pratos> ListarPratos()
        {
            return _context.Pratos.Where(a => a.Ativo == true).ToList();
        }

        public void CadastrarPratosXIngrediente(PratosXIngrediente pratosXIngrediente)
        {
            _context.PratosXIngrediente.Add(pratosXIngrediente);
            _context.SaveChanges();
        }
    }
}
