using Microsoft.AspNetCore.Mvc;
using @model Vivero.Models;

namespace Vivero.Controllers
{
    public class PlantasController : Controller
    {
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