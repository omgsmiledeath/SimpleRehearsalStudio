using Microsoft.AspNetCore.Mvc;

namespace AspNetRehearsal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
