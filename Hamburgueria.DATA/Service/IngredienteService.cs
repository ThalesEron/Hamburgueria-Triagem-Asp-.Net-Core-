using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Models;

namespace Hamburgueria.DATA.Service
{
    public class IngredienteService : IIngredienteService
    {

        private readonly IIngredienteRepository _ingredienteRepository;

        public IngredienteService(IIngredienteRepository ingredienteRepository)
        {
            _ingredienteRepository = ingredienteRepository;
        }

        public string CadastrarIngrediente(Ingrediente ingrediente)
        {

            _ingredienteRepository.CadastrarIngrediente(ingrediente);

            return string.Empty;
        }

        public Ingrediente GetIngredienteByName(string nomeIngrediente)
        {
            return _ingredienteRepository.GetIngredienteByName(nomeIngrediente);
        }

        public IList<Ingrediente> ListarIngredientes()
        {
            return _ingredienteRepository.ListarIngredientes();
        }
    }
}
