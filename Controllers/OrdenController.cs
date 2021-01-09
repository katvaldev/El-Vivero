using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vivero.Data;
using Vivero.Models;

namespace Vivero.Controllers
{
    public class OrdenController : Controller
    {
        private readonly ILogger<PlantaController> _logger;
        private readonly ApplicationDbContext _context; 
        public OrdenController(ILogger<PlantaController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        } 
        [Authorize]
        public IActionResult Index()
        {
            var Ordenes=_context.Orden.Where(x => x.Usuario != null).ToList();
            return View(Ordenes);
        }
        
        public IActionResult AddItem(int? id)
        {
            var planta = _context.Planta.Find(id);
            var orderDetail = new Orden();
            orderDetail.PlantaID = planta.ID;
            orderDetail.Preciounit = planta.Precio;
            orderDetail.Cantidad = 1;
            orderDetail.Usuario = User.Identity.Name;
            orderDetail.Fecha = DateTime.Now;
            orderDetail.Total = orderDetail.Cantidad * orderDetail.Preciounit;
            orderDetail.Producto = planta.Nombre;
            _context.Orden.Add(orderDetail);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}