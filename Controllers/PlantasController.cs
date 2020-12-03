using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vivero.Data;
using Vivero.Models;

namespace Vivero.Controllers
{
    public class PlantasController : Controller
    {
         public IActionResult Index(){
            return View();
        }

        

        public IActionResult Cargar()
        {
            return View();
        }


        
        private readonly ILogger<PlantasController> _logger;
        private readonly ApplicationDbContext _context;

        public PlantasController(ILogger<PlantasController> logger,
        ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpPost]
        public IActionResult Cargar(Planta objPlanta){
            if (ModelState.IsValid)
            {
                 _context.Add(objPlanta);
                _context.SaveChanges();
                objPlanta.Respuesta="Planta agregada.";
            }
            return View(objPlanta);
        }

        

    }
}