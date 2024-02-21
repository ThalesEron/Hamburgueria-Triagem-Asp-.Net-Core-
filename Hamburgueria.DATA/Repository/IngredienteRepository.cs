using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Infrastructure;
using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Models;
using Microsoft.EntityFrameworkCore;

namespace Hamburgueria.DATA.Repository
{
    public class IngredienteRepository : IIngredienteRepository
    {
        private readonly ConnectionContext _context = new();

        public void CadastrarIngrediente(Ingrediente ingrediente)
        {
            _context.Ingredientes.Add(ingrediente);
            _context.SaveChanges();
            
        }

        public void DeletarIngrediente(Ingrediente ingrediente)
        {
            _context.Entry(ingrediente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void EditarIngrediente(Ingrediente ingrediente)
        {
            _context.Entry(ingrediente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Ingrediente GetIngredienteById(int ingredienteId)
        {
            return _context.Ingredientes.Where(a => a.Codigo == ingredienteId && a.Ativo == true).ToList().FirstOrDefault();
        }

        public Ingrediente GetIngredienteByName(string nomeIngrediente)
        {
           return _context.Ingredientes.Where(a => a.NomeIngrediente.ToLower() == nomeIngrediente.ToLower() && a.Ativo == true).ToList().FirstOrDefault();
        }

        public IList<Ingrediente> ListarIngredientes()
        {
            return _context.Ingredientes.Where(a => a.Ativo == true).ToList();
        }
    }
}
