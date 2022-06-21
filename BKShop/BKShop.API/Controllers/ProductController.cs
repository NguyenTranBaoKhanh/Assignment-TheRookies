using BKShop.Data.EF;
using BKShop.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BKShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly BKShopDbContext _context;
        public ProductController(BKShopDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }
    }
}
