using Microsoft.AspNetCore.Mvc;

namespace Versteey.HelloWorld.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hellow world");
        }
    }
}
