using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;
public class Configuracao : BaseModel
{
    public string NomeConfiguracao { get; set; }
    public bool Escolha { get; set; }
}
