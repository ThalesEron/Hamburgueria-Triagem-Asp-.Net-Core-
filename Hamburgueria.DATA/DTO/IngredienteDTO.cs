using System.ComponentModel;

namespace Hamburgueria.DATA.DTO
{

    public class IngredienteDTO
    {
        public int Id { get; set; }
        [DisplayName("Nome Ingrediente")]
        public string NomeIngrediente { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime DataCadastro { get; set; }
        [DisplayName("Ativo")]
        public bool Ativo { get; set; }
    }
}
