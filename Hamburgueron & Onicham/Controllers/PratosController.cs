using AutoMapper;
using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Interfaces.IServices;
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
        public IActionResult ListarPratos()
        {

            var buscarIngredientes = _pratosService.ListarIngredientes();

            var listaIngredientesDto = _mapper.Map<List<IngredienteDTO>>(buscarIngredientes);

            ListarIngredientesViewModel vm = new()
            {
                IngredientesL = listaIngredientesDto,
                Ingrediente = new IngredienteDTO()
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


            if (_pratosService.GetPratoByName(nomePrato) is null)
                _pratosService.CadastrarPrato(prato);
            else
                return RedirectToAction("ListarPratos");



            return RedirectToAction("ListarPratos");
        }
    }
}
