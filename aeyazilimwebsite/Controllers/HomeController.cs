using aeyazilimwebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace aeyazilimwebsite.Controllers
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

        public IActionResult Projeler()
        {
            return View();
        }
        public IActionResult Gizlilik()
        {
            return View();
        }
        public IActionResult EpostaUyari()
        {
            return View();
        }
        public IActionResult Iot()
        {
            return View();
        }
        public IActionResult Biomedikal()
        {
            return View();
        }
        public IActionResult Mutfak()
        {
            return View();
        }
        public IActionResult Stajyer()
        {
            return View();
        }
         







        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}