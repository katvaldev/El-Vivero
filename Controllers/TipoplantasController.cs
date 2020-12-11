using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vivero.Data;
using Vivero.Models;

namespace Vivero.Controllers
{
    public class TipoPlantasController : Controller
    {

        private readonly ILogger<TipoPlantasController> _logger;
        private readonly ApplicationDbContext _context;


        public TipoPlantasController(ILogger<TipoPlantasController> logger,
        ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
          var listaTipo = (from tipo in _context.TipoPlanta
                                  select new SelectListItem()
                                  {
                                      Text = tipo.Nombre,
                                      Value = tipo.ID.ToString(),
                                  }).ToList();

            listaTipo.Insert(0, new SelectListItem()
            {
                Text = "----Selecciona----",
                Value = string.Empty
            });

            TipoPlantaViewModel tipoViewModel = new TipoPlantaViewModel();
            tipoViewModel.ListaTipoPlanta = listaTipo;

          return View(tipoViewModel);
        }

    }
}