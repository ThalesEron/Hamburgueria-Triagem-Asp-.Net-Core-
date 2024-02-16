using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Models;

namespace Hamburgueria.DATA.Interfaces
{
    public interface IIngredienteRepository
    {
        string CadastrarIngrediente(Ingrediente ingrediente);
        IList<Ingrediente> ListarIngredientes();
        Ingrediente GetIngredienteByName(string nomeIngrediente);

    }
}
