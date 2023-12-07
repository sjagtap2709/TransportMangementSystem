using Microsoft.AspNetCore.Mvc;
using TMSBusinessEntities;

namespace TransportMangementSystem.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserBE user)
        {
            Response.Cookies.Append("name", "sourabh", new CookieOptions());
            return View("Redirect");
        }
    }
}
