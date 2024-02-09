using Hamburgueria.DATA.Infrastructure;
using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Models.DTO;

namespace Hamburgueria.DATA.Repository
{
    public class IngredienteRepository : IIngredienteRepository
    {
        private readonly ConnectionContext _context = new();

        public string CadastrarIngrediente(IngredienteDTO ingrediente)
        {

            _context.Ingredientes.Add(ingrediente);
            _context.SaveChanges();

            return string.Empty;
            //throw new NotImplementedException();
        }

        public IList<IngredienteDTO> ListarIngredientes()
        {

            return _context.Ingredientes.ToList();
        }
    }
}
