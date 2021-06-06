using Microsoft.AspNetCore.Mvc;

namespace Mild.MinimalMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}