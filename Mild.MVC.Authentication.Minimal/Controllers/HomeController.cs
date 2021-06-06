using Microsoft.AspNetCore.Mvc;

namespace Mild.MVC.Authentication.Minimal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}