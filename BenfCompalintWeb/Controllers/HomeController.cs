using Microsoft.AspNetCore.Mvc;

namespace BenfCompalintWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Logins()
        {
            return View();
        }
    }
}
