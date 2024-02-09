using Hamburgueria.DATA.Models.DTO;

namespace Hamburgueria.DATA.Interfaces.IServices
{
    public interface IIngredienteService
    {
        string CadastrarIngrediente(IngredienteDTO ingrediente);
        IList<IngredienteDTO> ListarIngredientes();
    }
}
