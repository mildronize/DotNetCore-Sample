using Microsoft.AspNetCore.Mvc;

namespace Mild.MVC.Minimal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}