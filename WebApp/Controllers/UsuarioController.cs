using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public UsuarioController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
        Random rng = new Random();
        Thread.Sleep(rng.Next(1000,10000));
           return new List<Usuario>(){
               new Usuario{ID = rng.Next(), DataNasc = DateTime.Now.AddYears(-20), Nome = "Otavio Alfenas", RG = rng.Next().ToString(), CPF = rng.Next().ToString(), DataInclusao = DateTime.Now}
               ,new Usuario{ID = rng.Next(), DataNasc = DateTime.Now.AddYears(-19), Nome = "Rhenan Campos", RG = rng.Next().ToString(), CPF = rng.Next().ToString(), DataInclusao = DateTime.Now}
               ,new Usuario{ID = rng.Next(), DataNasc = DateTime.Now.AddYears(-18), Nome = "Luis Deilson", RG = rng.Next().ToString(), CPF = rng.Next().ToString(), DataInclusao = DateTime.Now}
               ,new Usuario{ID = rng.Next(), DataNasc = DateTime.Now.AddYears(-32), Nome = "Ahmad Issa", RG = rng.Next().ToString(), CPF = rng.Next().ToString(), DataInclusao = DateTime.Now}
               ,new Usuario{ID = rng.Next(), DataNasc = DateTime.Now.AddYears(-20), Nome = "Eliel Pereira", RG = rng.Next().ToString(), CPF = rng.Next().ToString(), DataInclusao = DateTime.Now}
               ,new Usuario{ID = rng.Next(), DataNasc = DateTime.Now.AddYears(-20), Nome = "Marco Antonio", RG = rng.Next().ToString(), CPF = rng.Next().ToString(), DataInclusao = DateTime.Now}
               ,new Usuario{ID = rng.Next(), DataNasc = DateTime.Now.AddYears(-20), Nome = "Gabriela", RG = rng.Next().ToString(), CPF = rng.Next().ToString(), DataInclusao = DateTime.Now}
               ,new Usuario{ID = rng.Next(), DataNasc = DateTime.Now.AddYears(-20), Nome = "Camila Gomes", RG = rng.Next().ToString(), CPF = rng.Next().ToString(), DataInclusao = DateTime.Now}

           };
        }
    }
}
