using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UnsortedControllersRepro.CFeature.Controllers
{
    /// <summary>
    /// C Simple Weather Forecast
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CWeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger _logger;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="logger"></param>
        public CWeatherForecastController(ILogger<CWeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Returns the current weather forecast
        /// </summary>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}