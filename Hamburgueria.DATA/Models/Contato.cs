using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;
public class Contato : BaseModel
{
    public string Email { get; set; }
    public string NumeroCelular { get; set; }
    public string NumeroTelefone { get; set; }
    public string Endereco { get; set; }
}
