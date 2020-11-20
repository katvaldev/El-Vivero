using Microsoft.AspNetCore.Mvc;

namespace Vivero.Controllers
{
    public class PlagasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}