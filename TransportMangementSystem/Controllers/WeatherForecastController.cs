using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using TMSBusinessEntities;
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
        public IEnumerable<UserBE> Get()
        {
            return _userDC.GetAllUsers();

        }
    }
}