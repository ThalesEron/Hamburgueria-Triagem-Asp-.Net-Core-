using Hamburgueria.DATA.DTO;

namespace Hamburgueria.DATA.ViewModel
{
    public class ListarPratosViewModel
    {
        public IList<PratosDTO> PratosL { get; set; } = new List<PratosDTO>();
        public PratosDTO Prato { get; set; }
        public IList<IngredienteDTO> IngredienteL { get; set; } = new List<IngredienteDTO>();
    }
}
