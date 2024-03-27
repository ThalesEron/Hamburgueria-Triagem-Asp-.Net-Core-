using AutoMapper;
using Hamburgueria.DATA.Interfaces.IServices;
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
    }
}

