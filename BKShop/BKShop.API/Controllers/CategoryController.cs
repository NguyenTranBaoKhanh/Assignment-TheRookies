using BKShop.Data.EF;
using BKShop.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BKShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly BKShopDbContext _context;
        public CategoryController(BKShopDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var categories = _context.Categories.FirstOrDefault(p => p.Id == id);
            return Ok(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Category categories)
        {
            _context.Categories.Add(categories);
            await _context.SaveChangesAsync();
            return Ok(categories);
        }
    }
}
