using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;
[Table("tb_ingrediente")]
public class Ingrediente 
{
    [Key]
    [Column("Id")]
    public int Codigo { get; set; }
    [Column("Ind_ativo")]
    public bool Ativo { get; set; }
    [DisplayName("Data Cadastro")]
    [Column("Dat_cadastro")]
    public DateTime DataCadastro { get; set; }

    [DisplayName("Nome Ingrediente")]
    [Column("Nom_ingrediente")]
    public string NomeIngrediente { get; set; }

}
