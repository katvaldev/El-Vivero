using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        public IActionResult Formulario(){
            
            return View("Formulario");

        }


        public IActionResult Detalle(Planta objPlanta){
            
            return View("Detalle", objPlanta);

        }


        public IActionResult Comprar(Planta objPlanta){
            
            return View("Comprar", objPlanta);

        }
        
        [HttpPost]
        public IActionResult Cargar(Planta objPlanta){
            if (ModelState.IsValid)
            {
                _context.Add(objPlanta);
                _context.SaveChanges();
                objPlanta.Respuesta = "Producto cargado a la tienda";
                return View(objPlanta);
            }else
            {
                objPlanta.Respuesta = "Error no se pudo cargar a la tienda";
                return View(objPlanta);
            }
            
        }
        
    }
}