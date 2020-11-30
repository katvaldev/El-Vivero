using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vivero.Data;
using Vivero.Models;

namespace Vivero.Controllers
{
    public class PlantasController : Controller
    {
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context; 
        
        public PlantasController(ILogger<ContactoController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }        
        
        
        public IActionResult Index(){
            return View();
        }


        
        [HttpPost]
        public IActionResult Cargar(Planta objPlanta){
            if (ModelState.IsValid)
            {
                _context.Add(objPlanta);
                _context.SaveChanges();
                objPlanta.Response = "Producto cargado a la tienda";
            }
            return View(objPlanta);
        }
        



    }
}