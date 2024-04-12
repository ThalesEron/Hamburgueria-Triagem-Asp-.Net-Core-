using Hamburgueria.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Interfaces.IServices
{
    public interface IPedidoService
    {
        void CadastrarPedido(Pedido pedido);
        IList<Pedido> ListarPedido();
        Pedido GetPedidoById(int pedidoId);
        void DeletarPedido(Pedido pedido);
    }
}
