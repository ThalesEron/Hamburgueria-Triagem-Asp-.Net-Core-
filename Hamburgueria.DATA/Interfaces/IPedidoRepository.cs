using Hamburgueria.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Interfaces
{
    public interface IPedidoRepository
    {
        void CadastrarPedido(Pedido pedido);
    }
}
