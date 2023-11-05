using Microsoft.AspNetCore.Mvc;
using TMSBusinessLogicLayer.IBusiness_Components;



namespace TransportMangementSystem.Controllers
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
        private readonly IUserBC _userDC;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserBC transportMgtContext)
        {
            _logger = logger;
            _userDC = transportMgtContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var dbuser = _userDC.GetAllUsers();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}