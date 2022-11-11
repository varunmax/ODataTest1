using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataService.Models;
using System.Text.Json;

namespace ODataTest1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ODataController
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        static List<Product>? data = new();
        static WeatherForecastController()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\varun.phadke\Projects\Personal\OData\ODataTest1\data.txt");

            data = JsonSerializer.Deserialize<List<Product>>(text);
        }

        private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}


        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        //private List<Product> products = new List<Product>()
        //{
        //    new Product()
        //    {
        //        ID = 1,
        //        Name = "Bread",
        //    },
        //     new Product()
        //    {
        //        ID = 2,
        //        Name = "2 Bread",
        //    }
        //};

        [HttpGet]
        [EnableQuery]
        public List<Product> Get()
        {
            return data;
        }
    }
}