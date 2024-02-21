using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Models;

namespace Hamburgueria.DATA.Interfaces.IServices
{
    public interface IIngredienteService
    {
        void CadastrarIngrediente(Ingrediente ingrediente);
        IList<Ingrediente> ListarIngredientes();
        Ingrediente GetIngredienteByName(string nomeIngrediente);
        Ingrediente GetIngredienteById(int ingredienteId);
        void EditarIngrediente(Ingrediente ingrediente);
        void DeletarIngrediente(Ingrediente ingrediente);
    }
}
