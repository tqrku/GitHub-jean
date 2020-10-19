using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcLab.Models;
using mvcLab.Data;

namespace mvcLab.Controllers
{
    public class CovidController : Controller
    {
        private readonly ILogger<CovidController> _logger;
        private readonly DatabaseContext _context;

        public CovidController(ILogger<CovidController> logger,
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
        public IActionResult Registrar(Covid covid){
            if(ModelState.IsValid){
                //Grabar
                covid.Autor="HuamanCalderon JeanPieer";
                _context.Add(covid);
                _context.SaveChanges();            
                covid.Respuesta="Gracias por registrarse al bono";
            }
            return View("Index",covid);
        }

        
    }
}