using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Models.DTO;

namespace Hamburgueria.DATA.Interfaces
{
    public interface IIngredienteRepository
    {
        string CadastrarIngrediente(IngredienteDTO ingrediente);
        IList<IngredienteDTO> ListarIngredientes();

    }
}
