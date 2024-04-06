using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.DTO
{
    public class PedidoDTO
    {
        public int Codigo { get; set; }
        [DisplayName("Valor Pedido")]
        public string ValorPedido { get; set; }
        [DisplayName("Numero Mesa")]
        public string NumeroMesa { get; set; }
        [DisplayName("Nome Cliente")]
        public string NomeCliente { get; set; }
        [DisplayName("Data Cadastro")]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
