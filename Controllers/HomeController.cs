using System.Diagnostics;
using MenuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuSistemi.Controllers
{
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
}
