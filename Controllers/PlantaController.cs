using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Vivero.Data;
using Vivero.Models;
using System.Dynamic;
using System.Collections.Generic;

namespace Vivero.Controllers
{
    public class PlantaController : Controller
    {
        private readonly ILogger<PlantaController> _logger;
        private readonly ApplicationDbContext _context; 
        private List<Planta> _plantas;
        
        public PlantaController(ILogger<PlantaController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            _plantas = _context.Planta.ToList();
        }            
        
        public IActionResult Index(){
            var ListaTipo = _context.TipoPlanta.ToList();
            dynamic model = new ExpandoObject(); 
            model.TipoPlanta = ListaTipo;
            return View(model);
        }

        public IActionResult VerPlantas(){
            var ListaTipo = _context.TipoPlanta.ToList();
            Planta planta = new Planta();
            dynamic model = new ExpandoObject();
            model.planta = planta;
            model.TipoPlanta = ListaTipo;
            return View(model);
        }

        public IActionResult Detalle()
        {
            int id = int.Parse(Request.Form["ID"]);
            var planta = _plantas.Where(x=>x.ID==id);
            return View(planta);
        }

        public IActionResult Formulario()
        {
            var ListaTipo = _context.TipoPlanta.ToList();
            Planta planta = new Planta();
            dynamic model = new ExpandoObject();
            model.planta = planta;
            model.TipoPlanta = ListaTipo;
            return View(model);
        }

        [HttpPost]
        public IActionResult Formulario(Planta planta)
        {
            planta.IDTipoPlanta = int.Parse(Request.Form["IDTipoPlanta"]);
            if (ModelState.IsValid)
            {
                _context.Add(planta);
                _context.SaveChanges();
                planta.Respuesta="Planta creada";
                return RedirectToAction("VerPlantas");
            }
            else{
                planta.Respuesta="No se pudo añadir";
                return View(planta);
            }         
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
                objPlanta.Respuesta = "Error, no se pudo cargar a la tienda";
                return View(objPlanta);
            }
            
        }

        //GET
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planta = await _context.Planta.FindAsync(id);
            if (planta == null)
            {
                return NotFound();
            }
            return View(planta);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Imagen,Precio,Stock,Temperatura Inicial,Temperatura Final,Riego,Tips,IDTipoPlanta")] Planta planta)
        {
            if (id != planta.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(planta);
        }
        
        public IActionResult Delete(int? id)
        {
            var planta = _context.Planta.Find(id);
            _context.Planta.Remove(planta);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        
    }
}