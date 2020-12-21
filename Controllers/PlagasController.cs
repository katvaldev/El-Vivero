using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
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

            return View("PlagasConfirmacion");
        }


        public IActionResult Index()
        {
            var listplagas=_context.Plagas.ToList();
            return View(listplagas);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plaga = await _context.Plagas.FindAsync(id);
            if (plaga == null)
            {
                return NotFound();
            }
            return View(plaga);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nombreplaga,descripcion,adicional")] Plaga plaga)
        {
            if (id != plaga.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plaga);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(plaga);
        }



        public IActionResult Delete(int? id)
        {
            var plaga = _context.Plagas.Find(id);
            _context.Plagas.Remove(plaga);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Detalle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plaga plaga = await _context.Plagas.FindAsync(id);
            if (plaga == null)
            {
                return NotFound();
            }
            return View("Detalle",plaga);
        }




        public IActionResult Formulario()
        {
            return View();
        }
    }
}