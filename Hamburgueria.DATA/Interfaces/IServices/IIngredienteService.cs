using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Models.DTO;

namespace Hamburgueria.DATA.Interfaces.IServices
{
    public interface IIngredienteService
    {
        string CadastrarIngrediente(Ingrediente ingrediente);
        IList<IngredienteDTO> ListarIngredientes();
    }
}
