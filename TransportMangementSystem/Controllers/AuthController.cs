using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TransportMangementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Auth()
        {
           return new List<string>() { "sourabh" ,"hari"};
        }
    }

}
