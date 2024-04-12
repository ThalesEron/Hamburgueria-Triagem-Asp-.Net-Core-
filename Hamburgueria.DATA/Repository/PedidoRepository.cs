using Hamburgueria.DATA.Infrastructure;
using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ConnectionContext _context = new();

        public void CadastrarPedido(Pedido pedido)
        {
            _context.Pedido.Add(pedido);
            _context.SaveChanges();
        }

        public IList<Pedido> ListarPedidos()
        {
            return _context.Pedido.Where(a => a.Ativo == true).ToList();
        }

        public void DeletarPedido(Pedido pedido)
        {
            _context.Entry(pedido).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Pedido GetPedidoById(int pedidoId)
        {
            return _context.Pedido.Where(a => a.Codigo == pedidoId && a.Ativo == true).ToList().FirstOrDefault();
        }
    }
}
