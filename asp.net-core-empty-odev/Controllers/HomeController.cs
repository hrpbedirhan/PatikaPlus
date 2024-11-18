using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_empty_odev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
