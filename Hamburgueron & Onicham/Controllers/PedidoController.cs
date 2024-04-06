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

            Pedido pedido= new()
            {
                Ativo = true,
                DataCadastro = DateTime.Now,
                NumeroMesa = numeroMesa,
                NomeCliente = nomeCliente,

            };



                _pedidoService.CadastrarPedido(pedido);
           

            return RedirectToAction("ListarPedidos");
        }

        [HttpGet]
        public IActionResult ListarPedidos()
        {

            var buscarPedidos = _pedidoService.ListarPedidos();

            var listarPedidosDto = _mapper.Map<List<PedidoDTO>>(buscarPedidos);

            ListarPedidosViewModel vm = new()
            {
                PedidosL = listarPedidosDto,
                Pedido = new PedidoDTO()
            };

            return View(vm);
        }


    }
}
