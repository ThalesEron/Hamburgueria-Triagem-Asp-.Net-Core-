using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;
public class Funcionario : BaseModel
{
    public string NomeFuncionario { get; set; }
    public Funcao Funcao { get; set; }
    public Contato Contato { get; set; }
}

