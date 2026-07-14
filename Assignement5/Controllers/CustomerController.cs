using Microsoft.AspNetCore.Mvc;

namespace Assignement5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {


        [HttpGet]
        public IActionResult GetCustomer()
        {
            var customer = new[]
            {
                new{
                Id = 1,
                Name = "John Doe",
                Email = "john.doe@cust.com"
                },
                new{
                Id = 2,
                Name = "ram teri",
                Email = "ram.t@cust.com"
                }
            };

            return Ok(customer);
        }
    }
}
