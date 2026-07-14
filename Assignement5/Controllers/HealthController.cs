using Microsoft.AspNetCore.Mvc;

namespace Assignement5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Application is healthy");
        }
    }
}
