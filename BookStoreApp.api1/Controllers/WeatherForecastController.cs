using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.api1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger; 
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.LogInformation("Made call to Weather Endpoint");

            try
            {
                throw new Exception("This is our loggin test exception");

                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    //Date = (DateOnly)(DateTime.Now.AddDays(index).Date),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToArray();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fatal Error Occurred");
                throw; 
            }
        }
    }
}