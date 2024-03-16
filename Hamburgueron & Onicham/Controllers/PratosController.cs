using AutoMapper;
using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Service;
using Hamburgueria.DATA.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaTriagem.Controllers
{
    public class PratosController : Controller
    {
        private readonly PratosService _pratosService;
        private readonly IMapper _mapper;


        public PratosController(PratosService pratosService, IMapper mapper)
        {
            _pratosService = pratosService;
            _mapper = mapper;
        }


        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult ListarPratos()
        {

            var buscarPratos = _pratosService.ListarPratos();

            var listarPratosDto = _mapper.Map<List<PratosDTO>>(buscarPratos);

            ListarPratosViewModel vm = new()
            {
                PratosL = listarPratosDto,
                Prato = new PratosDTO()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult CadastroPrato(string nomePrato, int valorPrato)
        {

            Pratos prato = new()
            {
                Ativo = true,
                DataCadastro = DateTime.Now,
                NomePrato = nomePrato,
                ValorPrato = valorPrato,
                ValorPratoPromocional = 0
            };


            if(_pratosService.GetPratoByName(nomePrato) is null)
                _pratosService.CadastrarPrato(prato);
            else
                return RedirectToAction("ListarPratos");



            return RedirectToAction("ListarPratos");
        }

        public IActionResult DeletarPrato(int pratoId)
        {
            var prato = _pratosService.GetPratoById(pratoId);

            prato.Ativo = false;

            _pratosService.DeletarPrato(prato);

            return RedirectToAction("ListarPratos");
        }

        public IActionResult EditarPrato(int pratoId)
        {

            var prato = _pratosService.GetPratoById(pratoId);

            ListarPratosViewModel vm = new()
            {
                Prato = new PratosDTO
                {
                    Codigo = pratoId,
                    DataCadastro = prato.DataCadastro,
                    Ativo = prato.Ativo
                }
            };

            return View(vm);
        }

        public IActionResult SaveEditarPrato(PratosDTO prato)
        {

            if(_pratosService.GetPratoByName(prato.NomePrato) is null)
                _pratosService.EditarPrato(_mapper.Map<Pratos>(prato));
            else
                return RedirectToAction("ListarPratos");


            return RedirectToAction("ListarPratos");
        }
    }
}
