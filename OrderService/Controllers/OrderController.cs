using Microsoft.AspNetCore.Mvc;
using OrderService.Data;
using OrderService.Models;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderDbContext _context;
        private readonly ProductServiceClient _productServiceClient;

        public OrderController(OrderDbContext context, ProductServiceClient productServiceClient)
        {
            _context = context;
            _productServiceClient = productServiceClient;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            var isValidProduct = await _productServiceClient.ValidateProductAsync(order.ProductId);
            if (!isValidProduct)
            {
                return BadRequest("Invalid ProductId.");
            }

            _context.Orders.Add(order);

            await _context.SaveChangesAsync();
            return Ok(order);
        } 

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(_context.Orders.ToList());
        }
    }
}