using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductService.Data;
using ProductService.Models;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext _context;

        public ProductController(ProductDbContext context) => _context = context;

        [HttpGet]
        public IActionResult GetProducts() => Ok(_context.Products.ToList());

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }

        [HttpGet("validate/{productId}")]
        public IActionResult ValidateProduct(int productId)
        {
            var productExists = _context.Products.Any(p => p.Id == productId);
            return Ok(productExists);
        }
    }
}
