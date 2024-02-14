

using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Models.DTO;

namespace Hamburgueria.DATA.ViewModel
{
    public class ListarIngredientesViewModel
    {
        public IList<IngredienteDTO> IngredientesL { get; set; } = new List<IngredienteDTO>();
        public Ingrediente Ingrediente { get; set; }

        public ListarIngredientesViewModel()
        {
        }
    }


}
