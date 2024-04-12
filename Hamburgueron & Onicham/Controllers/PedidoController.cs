using AutoMapper;
using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Service;
using Hamburgueria.DATA.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaTriagem.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoService _pedidoService;
        private readonly IMapper _mapper;


        public PedidoController(IPedidoService pedidoService, IMapper mapper)
        {
            _pedidoService = pedidoService;
            _mapper = mapper;
        }


        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CadastrarPedido(int numeroMesa, string nomeCliente)
        {

            Pedido pedido = new()
            {
                Ativo = true,
                DataCadastro = DateTime.Now,
                NumeroMesa = numeroMesa,
                NomeCliente = nomeCliente,
               
            };
          
                _pedidoService.CadastrarPedido(pedido);
         

            return RedirectToAction("ListarPedido");
        }
        [HttpGet]
        public IActionResult ListarPedido()
        {

            var buscarPedido = _pedidoService.ListarPedido();

            var listaPedidoDto = _mapper.Map<List<PedidoDTO>>(buscarPedido);

            ListarPedidoViewModel vm = new()
            {
                PedidosL = listaPedidoDto,
                Pedido = new PedidoDTO()
            };

            return View(vm);
        }
        public IActionResult DeletarPedido(int pedidoId)
        {
            var pedido = _pedidoService.GetPedidoById(pedidoId);

            pedido.Ativo = false;

            _pedidoService.DeletarPedido(pedido);

            return RedirectToAction("ListarPedido");
        }
    }

}

