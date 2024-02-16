using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Infrastructure;
using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Models;

namespace Hamburgueria.DATA.Repository
{
    public class IngredienteRepository : IIngredienteRepository
    {
        private readonly ConnectionContext _context = new();

        public string CadastrarIngrediente(Ingrediente ingrediente)
        {

            _context.Ingredientes.Add(ingrediente);
            _context.SaveChanges();

            return string.Empty;
            //throw new NotImplementedException();
        }

        public Ingrediente GetIngredienteByName(string nomeIngrediente)
        {

           return _context.Ingredientes.Where(a => a.NomeIngrediente.ToLower() == nomeIngrediente.ToLower()).ToList().FirstOrDefault();
        }

        public IList<Ingrediente> ListarIngredientes()
        {

            return _context.Ingredientes.ToList();
        }
    }
}
