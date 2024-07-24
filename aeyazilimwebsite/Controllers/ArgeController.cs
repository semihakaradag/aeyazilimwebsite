using Microsoft.AspNetCore.Mvc;

namespace aeyazilimwebsite.Controllers
{
    public class ArgeController : Controller
    {
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
    }
}
