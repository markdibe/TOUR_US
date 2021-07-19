using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using TOUR_US.DAL.Models;
using TOUR_US.DAL.Services;

namespace IdentityAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize(Roles ="User")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IGenericRepos<Category> _cat;

  


        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IGenericRepos<Category> cat)
        {
            _logger = logger;
            _cat = cat;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            var result = _cat.GetAll().Where("Title== @0","Test");
            return result;
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}
