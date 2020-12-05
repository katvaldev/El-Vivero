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

namespace El_Vivero.Controllers
{
    public class TipoplantasController
    {

       private readonly ILogger<TipoplantasController> _logger;
        private readonly ApplicationDbContext _context;


        public TipoplantasController(ILogger<TipoplantasController> logger,
        ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


//        [HttpPost]
  //      public IActionResult Cargar(Tipoplanta objTipoplantas){
    //        if (ModelState.IsValid)
    //        {
      //           _context.Add(objTipoplantas);
         //       _context.SaveChanges();
       //         objTipoplantas.Respuesta="Planta agregada.";
      //      }
      //      return View(objTipoplantas);
    //    }


    }
}