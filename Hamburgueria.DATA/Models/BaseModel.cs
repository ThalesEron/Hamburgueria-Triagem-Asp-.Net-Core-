using System.ComponentModel.DataAnnotations;

namespace Hamburgueria.DATA.Models;
public class BaseModel
{
    [Key]
    public int Codigo { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataCadastro { get; set; }
}
