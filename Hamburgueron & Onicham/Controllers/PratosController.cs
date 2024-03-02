using AutoMapper;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Service;
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
    {
    }
}
