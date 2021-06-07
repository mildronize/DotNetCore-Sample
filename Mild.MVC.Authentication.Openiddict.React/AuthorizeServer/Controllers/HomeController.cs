using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AuthorizeServer.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // 
        // GET: /Home

        public IActionResult Index()
        {
            return Ok("Hello");
        }
    }
}

