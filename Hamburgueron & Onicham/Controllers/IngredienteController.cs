using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Service;
using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaTriagem.Controllers
{
    public class IngredienteController : Controller
    {
        private readonly IIngredienteRepository _ingredienteRepository;


        public IngredienteController(IIngredienteRepository ingredienteRepository)
        {
            _ingredienteRepository = ingredienteRepository;
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

            _ingredienteRepository.CadastrarIngrediente(ingrediente);


            return "Cadastro de ingrediente realizado com sucesso.";
        }




    }
}
