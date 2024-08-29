using AutoMapper;
using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Service;
using Hamburgueria.DATA.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HamburgueriaTriagem.Controllers
{
    public class PratosController : Controller
    {
        private readonly IPratosService _pratosService;
        private readonly IIngredienteService _ingredienteService;
        private readonly IMapper _mapper;


        public PratosController(IPratosService pratosService, IMapper mapper, IIngredienteService ingredienteService)
        {
            _pratosService = pratosService;
            _mapper = mapper;
            _ingredienteService = ingredienteService;
        }


        public IActionResult Index()
        {
            var buscarIngredientes = _ingredienteService.ListarIngredientes();
            var listarIngredienteDto = _mapper.Map<List<IngredienteDTO>>(buscarIngredientes);

            ListarPratosViewModel vm = new()
            {
                IngredienteL = listarIngredienteDto

            };

            return View(vm);
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

        [HttpGet]
        public IActionResult AdicionarIngrediente()
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
        public IActionResult CadastroPrato(Pratos prato, IList<IngredienteDTO> Ingredientes)
        {

            prato.Ativo = true;
            prato.DataCadastro = DateTime.Now;
            prato.ValorPratoPromocional = 0;


            if(_pratosService.GetPratoByName(prato.NomePrato) is null)
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
                    NomePrato = prato.NomePrato,
                    ValorPrato = Convert.ToString(prato.ValorPrato),
                    ValorPratoPromocional = Convert.ToString(prato.ValorPratoPromocional)
                }
            };

            return View(vm);
        }

        public IActionResult SaveEditarPrato(PratosDTO prato)
        {
            var pratoEditar = _mapper.Map<Pratos>(_pratosService.GetPratoById(prato.Codigo));
            pratoEditar.ValorPrato = Convert.ToDecimal(prato.ValorPrato);
            pratoEditar.ValorPratoPromocional = Convert.ToDecimal(prato.ValorPratoPromocional);
            pratoEditar.NomePrato = prato.NomePrato;

            _pratosService.EditarPrato(pratoEditar);

            return RedirectToAction("ListarPratos");
        }
    }
}
