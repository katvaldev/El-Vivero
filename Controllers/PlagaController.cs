using Microsoft.AspNetCore.Mvc;

namespace Vivero.Controllers
{
    public class PlagaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}