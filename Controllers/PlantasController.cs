using Microsoft.AspNetCore.Mvc;

namespace Vivero.Controllers
{
    public class PlantasController : Controller
    {
         public IActionResult Index(){
            return View();
        }


        [HttpPost]
        public IActionResult Contacto(Contacto contacto)
        {
            if (ModelState.IsValid) 
            {
                // TODO: Hacer algo con los parámetros del objecto contacto
                return RedirectToAction("ContactoConfirmacion");
            }
            
            return View(contacto);
        }



    }
}