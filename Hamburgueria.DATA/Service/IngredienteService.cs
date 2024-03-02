using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Models;

namespace Hamburgueria.DATA.Service
{
    public class IngredienteService 
    {

        private readonly IIngredienteRepository _ingredienteRepository;

        public IngredienteService(IIngredienteRepository ingredienteRepository)
        {
            _ingredienteRepository = ingredienteRepository;
        }

        public void CadastrarIngrediente(Ingrediente ingrediente)
        {

            _ingredienteRepository.CadastrarIngrediente(ingrediente);
        }

        public void DeletarIngrediente(Ingrediente ingrediente)
        {
            _ingredienteRepository.DeletarIngrediente(ingrediente);
        }

        public void EditarIngrediente(Ingrediente ingrediente)
        {
            _ingredienteRepository.EditarIngrediente(ingrediente);
        }

        public Ingrediente GetIngredienteById(int ingredienteId)
        {
            return _ingredienteRepository.GetIngredienteById(ingredienteId);
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
