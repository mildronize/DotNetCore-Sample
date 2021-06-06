using Microsoft.AspNetCore.Mvc;

namespace Mild.MVC.Authentication.Openiddict.OAuth2.ClientCredentials.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}