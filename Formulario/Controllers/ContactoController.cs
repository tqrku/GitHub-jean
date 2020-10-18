using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using formulario.Models;

namespace formulario.Controllers
{
    public class ContactoController : Controller
    {
         private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Contacto objContacto){
            if (ModelState.IsValid)
            {
                //grabar
                objContacto.Response = "Gracias estamos en contacto";
            }
            return View("index", objContacto);
        }

       
    }
}