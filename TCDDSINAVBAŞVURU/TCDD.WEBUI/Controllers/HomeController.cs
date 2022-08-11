using Microsoft.AspNetCore.Mvc;

namespace TCDD.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
