using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetStore.Web.Interfaces;
using PetStore.Web.Models.Entities;

namespace PetStore.Web.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] Order order)
        {
            // Ensure there were no binding issues.
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var savedOrder = await _orderService.SaveOrderAsync(order);

            return Ok(savedOrder);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(long id)
        {
            var order = await _orderService.GetOrderAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }
    }
}