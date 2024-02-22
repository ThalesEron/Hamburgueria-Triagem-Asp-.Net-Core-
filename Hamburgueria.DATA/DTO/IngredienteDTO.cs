using System.ComponentModel;

namespace Hamburgueria.DATA.DTO
{

    public class IngredienteDTO
    {
        public int Id { get; set; }
        public string NomeIngrediente { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
