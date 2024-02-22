using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hamburgueria.DATA.Models;
[Table("tb_ingrediente")]
public class Ingrediente 
{
    [Key]
    [Column("id")]
    [Required]
    public int Codigo { get; set; }
    [Column("ind_ativo")]
    [Required]
    public bool Ativo { get; set; }
    [DisplayName("Data Cadastro")]
    [Column("dat_cadastro")]
    [Required]
    public DateTime DataCadastro { get; set; }

    [DisplayName("Nome Ingrediente")]
    [Column("nom_ingrediente")]
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Nome do ingrediente obrigatório."), MaxLength(50)]
    public string NomeIngrediente { get; set; }

}
