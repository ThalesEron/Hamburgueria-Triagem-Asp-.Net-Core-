using System.Diagnostics;
using Hamburgueria.DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace HamburgueriaTriagem.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
      
        return View();
    }




}
