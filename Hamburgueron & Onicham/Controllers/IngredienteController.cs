using AutoMapper;
using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaTriagem.Controllers
{
    public class IngredienteController : Controller
    {
        private readonly IIngredienteService _ingredienteService;
        private readonly IMapper _mapper;


        public IngredienteController(IIngredienteService ingredienteService, IMapper mapper)
        {
            _ingredienteService = ingredienteService;
            _mapper = mapper;
        }


        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]      
        public IActionResult CadastroIngrediente(string nomeIngrediente)
        {

            Ingrediente ingrediente = new()
            {
                Ativo = true,
                DataCadastro = DateTime.Now,
                NomeIngrediente = nomeIngrediente
               
            };


            if(_ingredienteService.GetIngredienteByName(nomeIngrediente) is null)
                _ingredienteService.CadastrarIngrediente(ingrediente);
            else
                return RedirectToAction("ListarIngredientes");



            return RedirectToAction("ListarIngredientes");
        }

        [HttpGet]
        public IActionResult ListarIngredientes()
        {

            var buscarIngredientes = _ingredienteService.ListarIngredientes();

            var listaIngredientesDto = _mapper.Map<List<IngredienteDTO>>(buscarIngredientes);

            ListarIngredientesViewModel vm = new()
            {
                IngredientesL = listaIngredientesDto,
                Ingrediente = new IngredienteDTO()
            };

            return View(vm);
        }



    }
}
