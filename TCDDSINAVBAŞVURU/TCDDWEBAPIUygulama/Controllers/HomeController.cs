using Microsoft.AspNetCore.Mvc;

namespace TCDDWEBAPIUygulama.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
