using Microsoft.AspNetCore.Mvc;

namespace Vivero.Controllers
{
    public class CarritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}