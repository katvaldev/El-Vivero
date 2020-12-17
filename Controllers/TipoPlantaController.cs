using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vivero.Data;
using Vivero.Models;
using System.Collections.Generic;
using System.Dynamic;

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
            var ListaPlantas = _context.Planta.ToList();
            var ListaTipo = _context.TipoPlanta.ToList();
            foreach(var planta in ListaPlantas)
            {
                foreach(var tipo in ListaTipo)
                {     
                    if(planta.IDTipoPlanta==tipo.ID)           
                    tipo.Plantas.Add(planta);
                }
            }
            // dynamic model = new ExpandoObject();
            // model.TipoPlanta = ListaTipo;
            return View(ListaTipo);
        }
    }
}