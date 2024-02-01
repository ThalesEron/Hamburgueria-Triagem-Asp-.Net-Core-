using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;
public class PedidoXPratos
{
    public Pratos Pratos { get; set; }  
    public Pedido Pedido { get; set; }  
}
