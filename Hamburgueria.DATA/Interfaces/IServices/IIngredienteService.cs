using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Models;

namespace Hamburgueria.DATA.Interfaces.IServices
{
    public interface IIngredienteService
    {
        string CadastrarIngrediente(Ingrediente ingrediente);
        IList<Ingrediente> ListarIngredientes();
        Ingrediente GetIngredienteByName(string nomeIngrediente);
    }
}
