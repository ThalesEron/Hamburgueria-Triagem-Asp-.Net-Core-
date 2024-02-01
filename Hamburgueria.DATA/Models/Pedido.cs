using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;
public class Pedido : BaseModel
{
    public string NomeCliente { get; set; }
    public int Valor { get; set; }
    public int NumeroMesa { get; set; }

}
