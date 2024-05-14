using System.ComponentModel;

namespace Hamburgueria.DATA.DTO
{
    public class PratosDTO
    {
        public int Codigo { get; set; }
        [DisplayName("Valor Prato")]
        public string ValorPrato { get; set; }
        [DisplayName("Valor Promocional")]
        public string ValorPratoPromocional { get; set; }
        [DisplayName("Nome Prato")]
		public string NomePrato { get; set; }
        [DisplayName("Data Cadastro")]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
