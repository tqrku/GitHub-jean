using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProducctosApp.Models;

using ProducctosApp.Data;

namespace ProducctosApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ProductosAppContext _context;

        public HomeController(ILogger<HomeController> logger, ProductosAppContext context )
        {
            _logger = logger;
            _context=context;
        }

        public IActionResult Index()
        {
            var productos = _context.Productos.ToList();
            List<Producto> Lista= new List<Producto>();
            DateTime limitDate=DateTime.Today.AddDays(-7);
            foreach(Producto producto in productos){

                if(DateTime.Compare(producto.Fecha, limitDate)>=0){
                    Lista.Add(producto);
                }
            }
            return View(productos);
        }

        public IActionResult Producto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Producto(Producto p)
        {
            if(ModelState.IsValid){

                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
