using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Models.DTO;

namespace Hamburgueria.DATA.Service
{
    public class IngredienteService : IIngredienteService
    {

        private readonly IIngredienteRepository _ingredienteRepository;

        public IngredienteService(IIngredienteRepository ingredienteRepository)
        {
            _ingredienteRepository = ingredienteRepository;
        }

        public string CadastrarIngrediente(IngredienteDTO ingrediente)
        {

            _ingredienteRepository.CadastrarIngrediente(ingrediente);

            return string.Empty;
        }

        public IList<IngredienteDTO> ListarIngredientes()
        {
            return _ingredienteRepository.ListarIngredientes();
        }
    }
}
