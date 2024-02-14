using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hamburgueria.DATA.Models;
public class BaseModel
{
    public int Codigo { get; set; }
    public bool Ativo { get; set; }
    [DisplayName("Data Cadastro")]
    public DateTime DataCadastro { get; set; }
}
