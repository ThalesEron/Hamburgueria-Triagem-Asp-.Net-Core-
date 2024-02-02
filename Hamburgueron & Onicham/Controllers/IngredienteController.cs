using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Service;
using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaTriagem.Controllers
{
    public class IngredienteController : Controller
    {
        private readonly ILogger<IngredienteController> _logger;

        public IngredienteController(ILogger<IngredienteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public string CadastroIngrediente(string nomeIngrediente)
        {
            var ingredienteService = new IngredienteService();

            Ingrediente ingrediente = new()
            {
                Ativo = true,
                DataCadastro = DateTime.Now,
                NomeIngrediente = nomeIngrediente
               
            };

            ingredienteService.CadastrarIngrediente(ingrediente);


            return "Cadastro de ingrediente realizado com sucesso.";
        }




    }
}
