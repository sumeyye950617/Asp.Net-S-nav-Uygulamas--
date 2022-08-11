using Microsoft.AspNetCore.Mvc;

namespace TCDD.WEBUI.Controllers
{
    public class SınavController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            return View();
        }
    }
}

