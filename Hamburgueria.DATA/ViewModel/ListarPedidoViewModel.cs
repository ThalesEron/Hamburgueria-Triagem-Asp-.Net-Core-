using Hamburgueria.DATA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.ViewModel
{
    public class ListarPedidoViewModel
    {
        public IList<PedidoDTO> PedidosL { get; set; } = new List<PedidoDTO>();
        public PedidoDTO Pedido { get; set; }
    }
}
