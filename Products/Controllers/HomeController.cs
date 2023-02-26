using Microsoft.AspNetCore.Mvc;
using Products.Models;
using System.Diagnostics;

namespace Products.Controllers
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

        [Route("Home/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Privacy");
        }

        [Route("test/{name}")]
        public IActionResult Product(string name)
        {
            return View();
        }

    }
}