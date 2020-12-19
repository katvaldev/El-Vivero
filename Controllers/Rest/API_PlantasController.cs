using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.Extensions.Logging;
using Vivero.Data;
using Vivero.Models;

namespace El_Vivero.Controllers.Rest
{
    [ApiController]
    
    public class API_PlantasController : ControllerBase
    {
        private readonly ILogger<API_PlantasController> _logger;
        private readonly ApplicationDbContext _context; 

        public API_PlantasController(ILogger<API_PlantasController > logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        } 

        [HttpGet]
        [Route("API/Planta")]
        public IEnumerable<Planta> Get()
        {
            var listaPlantas = _context.Planta.OrderBy(x=>x.ID).ToList();
            return listaPlantas.ToArray();
        }
        [HttpGet("{id}")]
        public Planta GetProduct(int? id)
        {
            var planta =  _context.Planta.Find(id);
            return planta;
        }

        [HttpPost]
        public Planta CreateProduct(Planta planta){
            _context.Add(planta);
            _context.SaveChanges();
            return planta;
        }
    }
}