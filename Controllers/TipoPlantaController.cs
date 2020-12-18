using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using Vivero.Data;
using Vivero.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Vivero.Controllers
{
    public class TipoPlantaController : Controller
    {
        private readonly ILogger<TipoPlantaController> _logger;
        private readonly ApplicationDbContext _context;


        public TipoPlantaController(ILogger<TipoPlantaController> logger,
        ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var listTipo=_context.TipoPlanta.Where(x => x.Nombre != null).ToList();
            return View(listTipo);
        }
        public IActionResult Planta()
        {
            var ListaPlantas = _context.Planta.ToList();
            var ListaTipos = _context.TipoPlanta.ToList();
            foreach(var planta in ListaPlantas)
            {
                foreach(var tipo in ListaTipos)
                {     
                    if(planta.IDTipoPlanta==tipo.ID)           
                    tipo.Plantas.Add(planta);
                }
            }
            return View(ListaTipos);
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
        
        public IActionResult Delete(int? id)
        {
            var tipo = _context.TipoPlanta.Find(id);
            _context.TipoPlanta.Remove(tipo);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}