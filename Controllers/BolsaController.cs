using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pc1OperacionesZamudio.Models;

namespace Pc1OperacionesZamudio.Controllers
{
    [Route("[Bolsa]")]
    public class BolsaController : Controller
    {
        private readonly ILogger<BolsaController> _logger;

        public BolsaController(ILogger<BolsaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("Invertir")]
        public IActionResult Invertir(Operacion operacion){
            operacion.IGV = operacion.MontoAbonar * 0.18M;
            if (operacion.MontoAbonar > 300)
                operacion.Comision = 1;
            else
                operacion.Comision = 3;
            

            operacion.TotalPagar = operacion.MontoAbonar + operacion.IGV + operacion.Comision;    
            
            return View("Resumen", operacion);
        }


        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}