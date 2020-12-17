using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Vivero.Models;
using Microsoft.AspNetCore.Mvc;

namespace Vivero.Controllers
{
    public class CarritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}