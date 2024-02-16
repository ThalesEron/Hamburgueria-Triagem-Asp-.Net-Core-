using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Models;

namespace Hamburgueria.DATA.ViewModel;
public class ListarIngredientesViewModel
{
    public IList<IngredienteDTO> IngredientesL { get; set; } = new List<IngredienteDTO>();
    public IngredienteDTO Ingrediente { get; set; }

    public ListarIngredientesViewModel()
    {
    }
}



