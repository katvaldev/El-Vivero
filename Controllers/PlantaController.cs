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

        
        public PlantaController(ILogger<PlantaController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            // _plantas = _context.Planta.ToList();
            ListaTipos = _context.TipoPlanta.ToList();
        }            
        
        // public IActionResult Index(){
        //     ListaTipos = _context.TipoPlanta.ToList();
        //     dynamic model = new ExpandoObject(); 
        //     model.TipoPlanta = ListaTipos;
        //     return View(model);
        // }

        public async Task<IActionResult> Index(int BuscarPlanta)
        {
            _plantas = _context.Planta.ToList();
            dynamic model= new ExpandoObject();
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
            _plantas = _context.Planta.ToList();
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
            var planta = new Planta();
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
                return RedirectToAction("Index");
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
        //PRUEBAS CON LOS CACTUS
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _planta = await _context.Planta.FindAsync(id);
            if (_planta == null)
            {
                return NotFound();
            }
            dynamic model = new ExpandoObject();
            model.planta = _planta;
            model.TipoPlanta = ListaTipos;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID, Nombre, ImagenURL,Precio, Stock,TemperaturaIdeal,Riego,Tips, IDTipoPlanta")] Planta _planta)
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
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            dynamic model = new ExpandoObject();
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