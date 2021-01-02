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
        private IEnumerable<Planta> _plantas;
        private List<TipoPlanta> ListaTipos;
        private Planta planta;
        private dynamic model;

        
        public PlantaController(ILogger<PlantaController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            _plantas = _context.Planta.ToList();
            ListaTipos = _context.TipoPlanta.ToList();
            planta = new Planta();
            model = new ExpandoObject();
        }            
        
        public IActionResult Index(){
            var ListaTipo = _context.TipoPlanta.ToList();
            // model = new ExpandoObject(); 
            model.TipoPlanta = ListaTipo;
            return View(model);
        }

        public async Task<IActionResult> VerPlantas(int BuscarPlanta)
        {
            // dynamic model= new ExpandoObject();
            model.TipoPlanta = ListaTipos;

            var planta = from m in _plantas
            select m;

            if(BuscarPlanta!=0){
            _plantas = _plantas.Where(s => s.IDTipoPlanta==BuscarPlanta);
            }
            model.Planta = _plantas;
            return View(await Task.FromResult(model));
        }

        public IActionResult Detalle(int? ID)
        {
            if (ID == null)
            {
                return NotFound();
            }
            Planta planta = new Planta();
            foreach(var i in _plantas)
            {
                if (i.ID==ID)
                planta = i;
            }
            return View(planta);
        }

        public IActionResult Formulario()
        {
            var ListaTipo = _context.TipoPlanta.ToList();
            // planta = new Planta();
            // model = new ExpandoObject();
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

            planta = await _context.Planta.FindAsync(id);
            if (planta == null)
            {
                return NotFound();
            }
            model.planta = planta;
            model.TipoPlanta = ListaTipos;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,IDTipoPlanta,ImagenURL,Nombre,Precio,Respuesta,Riego,Stock,TemperaturaIdeal")] Planta _planta)
        {
            if (id != _planta.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _planta.IDTipoPlanta = int.Parse(Request.Form["IDTipoPlanta"]);
                    _context.Update(_planta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                return RedirectToAction(nameof(Index));
            }
            // var errors = ModelState.Values.SelectMany(v => v.Errors);
            model.TipoPlanta=ListaTipos;
            model.planta=_planta;
            return View(model);
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