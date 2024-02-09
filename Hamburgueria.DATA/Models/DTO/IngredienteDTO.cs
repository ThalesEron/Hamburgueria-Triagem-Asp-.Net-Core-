using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hamburgueria.DATA.Models.DTO
{
    [Table("tb_ingrediente")]
    public class IngredienteDTO
    {
        [Key]
        public int Id_ingrediente { get; set; }
        public string Nom_ingrediente { get; set; }
        public bool Ind_ativo { get; set; }
        public DateTime Dat_cadastro { get; set; }
    }
}
