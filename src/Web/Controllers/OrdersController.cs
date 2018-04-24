using Microsoft.AspNetCore.Mvc;

namespace PetStore.Web.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        [HttpPost]
        public IActionResult CreateOrder()
        {
            // Stub
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(long id)
        {
            // Stub
            return Ok();
        }
    }
}