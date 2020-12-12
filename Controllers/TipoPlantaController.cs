using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vivero.Data;
using Vivero.Models;
using System.Collections.Generic;

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
        //   var listaTipo = (from tipo in _context.TipoPlanta
        //                           select new SelectListItem()
        //                           {
        //                               Text = tipo.Nombre,
        //                               Value = tipo.ID.ToString(),
        //                           }).ToList();

        //     listaTipo.Insert(0, new SelectListItem()
        //     {
        //         Text = "----Selecciona----",
        //         Value = string.Empty
        //     });

        //     TipoPlantaViewModel tipoViewModel = new TipoPlantaViewModel();
        //     tipoViewModel.ListaTipoPlanta = listaTipo;

            // return View();

            var listTipos=_context.TipoPlanta.ToList();
            return View(listTipos);
        }
    }
}