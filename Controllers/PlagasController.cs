using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Vivero.Data;
using Vivero.Models;

namespace Vivero.Controllers
{
    public class PlagasController : Controller
    {


        private readonly ILogger<PlagasController> _logger;
         private readonly ApplicationDbContext _context;

        public PlagasController(ILogger<PlagasController> logger,
        ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        
        [HttpPost]
        public IActionResult Create(Plaga plaga)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plaga);
                _context.SaveChanges();
                
            }

            return View("PlagasConfirmacion",plaga);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Formulario()
        {
            return View();
        }
    }
}