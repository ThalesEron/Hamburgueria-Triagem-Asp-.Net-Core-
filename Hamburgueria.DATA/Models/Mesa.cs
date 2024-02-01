using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;
public class Mesa : BaseModel
{
    public Pedido Pedido { get; set; }
    public Funcionario Funcionario { get; set; }   
}
