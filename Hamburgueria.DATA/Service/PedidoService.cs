﻿using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Service
{
    public class PedidoService: IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public void CadastrarPedido(Pedido pedido)
        {
            _pedidoRepository.CadastrarPedido(pedido);

        }
        public IList<Pedido> ListarPedido()
        {
            return _pedidoRepository.ListarPedido();
        }
        public Pedido GetPedidoById(int pedidoId)
        {
            return _pedidoRepository.GetPedidoById(pedidoId);
        }
        public void DeletarPedido(Pedido pedido)
        {
            _pedidoRepository.DeletarPedido(pedido);
        }
    }
}
