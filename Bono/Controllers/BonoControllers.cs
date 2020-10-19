using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bono.Models;
using Bono.Data;

namespace Bono.Controllers
{
    public class BonoController : Controller
    {

       private readonly ILogger<BonoController> _logger;
       private readonly DatabaseContext _context;


        public BonoController(ILogger<BonoController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Bonos objBono){
            if (ModelState.IsValid)
            {
                //grabar
                _context.Add(objBono);
                _context.SaveChanges();
                objBono.Response = "Se  ha registrado para recibir el bono";
            }
            return View("index", objBono);
        }

    }
}