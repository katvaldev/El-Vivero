using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using Vivero.Data;
using Vivero.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Dynamic;

namespace Vivero.Controllers
{
    public class TipoPlantaController : Controller
    {
        private readonly ILogger<TipoPlantaController> _logger;
        private readonly ApplicationDbContext _context;
        private IEnumerable<Planta> _plantas;
        private List<TipoPlanta> ListaTipos;


        public TipoPlantaController(ILogger<TipoPlantaController> logger,
        ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            _plantas = _context.Planta.ToList();
            ListaTipos = _context.TipoPlanta.ToList();
        }

        public IActionResult Index()
        {
            var listTipo=_context.TipoPlanta.Where(x => x.Nombre != null).ToList();
            return View(listTipo);
        }
        public async Task<IActionResult> PlantaAsync(int BuscarPlanta)
        {
            dynamic modelo= new ExpandoObject();
            modelo.TipoPlanta = ListaTipos;

            var planta = from m in _plantas
            select m;

            if(BuscarPlanta!=0){
            _plantas = _plantas.Where(s => s.IDTipoPlanta==BuscarPlanta);
            }
            modelo.Planta = _plantas;
            return View(await Task.FromResult(modelo));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TipoPlanta tipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipo);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipo = await _context.TipoPlanta.FindAsync(id);
            if (tipo == null)
            {
                return NotFound();
            }
            return View(tipo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre")] TipoPlanta tipo)
        {
            if (id != tipo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tipo);
        }
        
        // public IActionResult Delete(int? id)
        // {
        //     var tipo = _context.TipoPlanta.Find(id);
        //     _context.TipoPlanta.Remove(tipo);
        //     _context.SaveChanges();
        //     return RedirectToAction(nameof(Index));
        // }
        public IActionResult Habilitar(int? id)
        {
            var tipo = _context.TipoPlanta.Find(id);
            tipo.Deshabilitado = true ? false : true;

            _context.TipoPlanta.Update(tipo);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}