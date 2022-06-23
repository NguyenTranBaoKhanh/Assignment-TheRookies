using BKShop.Data.EF;
using BKShop.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BKShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly BKShopDbContext _context;
        public BrandController(BKShopDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _context.Brands.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var product = _context.Brands.FirstOrDefault(p => p.Id == id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Brand brand)
        {
            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();
            return Ok(brand);
        }
    }
}
