using AutoMapper;
using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Service;
using Hamburgueria.DATA.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaTriagem.Controllers
{
    public class CardapioController : Controller
    {
        private readonly IPratosService _pratosService;
        private readonly IMapper _mapper;

        public CardapioController(IPratosService pratosService, IMapper mapper)
        {
            _pratosService = pratosService;
            _mapper = mapper;
        }


        public IActionResult Index()
        {
            var buscarPratos = _pratosService.ListarPratos();

            var listarPratosDto = _mapper.Map<List<PratosDTO>>(buscarPratos);

            CardapioViewModel vm = new()
            {
                PratosL = listarPratosDto,
                Prato = new PratosDTO()
            };

            return View(vm);
            
        }

        public IActionResult AdicionarPedidoCliente(int pratoId)
        {
            var prato = _pratosService.GetPratoById(pratoId);

            CardapioViewModel vm = new()
            {
                Prato = new PratosDTO
                {
                    Codigo = pratoId,
                    NomePrato = prato.NomePrato,
                    ValorPrato = Convert.ToString(prato.ValorPrato),
                }
            };

            return View(vm);

        }







    }
}
