namespace Hamburgueria.DATA.DTO
{
    public class PratosDTO
    {
        public int Codigo { get; set; }
        public decimal ValorPrato { get; set; }
        public decimal ValorPratoPromocional { get; set; }
        public string NomePrato { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
