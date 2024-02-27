using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;
[Table("tb_pratos")]
public class Pratos
{
    [Key]
    [Column("id")]
    [Required]
    public int Codigo { get; set; }

    [Column("num_valor")]
    [Required]
    public decimal ValorPrato { get; set; }

    [Column("num_valor_promocional")]
    [Required]
    public decimal ValorPratoPromocional { get; set; }

    [Column("nome_prato")]
    [Required]
    public string NomePrato { get; set; }

    [Column("ind_ativo")]
    [Required]
    public bool Ativo { get; set; }

    [Column("dat_cadastro")]
    [Required]
    public DateTime DataCadastro { get; set; }






}
