using AutoMapper;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Models.DTO;
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

            var ingredienteDto = _mapper.Map<IngredienteDTO>(ingrediente);            

            _ingredienteService.CadastrarIngrediente(ingredienteDto);


            return View();
        }

        [HttpGet]
        public IActionResult ListarIngredientes()
        {

            ListarIngredientesViewModel vm = new()
            {
                IngredientesL = _ingredienteService.ListarIngredientes(),
                Ingrediente = new Ingrediente()
            };

            return View(vm);
        }



    }
}
