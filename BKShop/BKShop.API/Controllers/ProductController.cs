using BKShop.Application.Interfaces;
using BKShop.Data.EF;
using BKShop.Data.Entities;
using BKShop.ViewModels.Requests.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BKShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly BKShopDbContext _context;
        private readonly IProductService _productService;
        public ProductController(BKShopDbContext context, IProductService productService)
        {
            _productService = productService;
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            //var products = _context.Products.ToList();
            var products = await _productService.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("Top5")]
        [AllowAnonymous]
        public async Task<IActionResult> GetTop5()
        {
            //var products = _context.Products.ToList();
            var products = await _productService.GetTop5Async();
            return Ok(products);
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
                //var product = _context.Products.FirstOrDefault(p => p.Id == id);
                var product = await _productService.GetByIdAsync(Id);
                if(product == null)
                {
                    return NotFound($"Cannot find a product with Id: {Id}");
                }
                return Ok(product);

            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> Create([FromBody]ProductCreateRequest request)
        {
            var productId = await _productService.CreateAsync(request);
            if (productId == null)
            {
                return BadRequest();
            }
            var data = await _productService.GetByIdAsync(productId);
            if (data == null)
            {
                return NotFound($"Cannot find a product with Id: {productId}");
            }
            return Ok(data);
        }

        [HttpDelete("{Id}")]
        [Authorize]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var result = await _productService.DeleteAsync(Id);
                if (result == 0)
                {
                    return BadRequest();
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update([FromBody] ProductUpdateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _productService.UpdateAsync(request);

                if (result == 0)
                {
                    return BadRequest();
                }

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Paging")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetProductPagingRequest request)
        {
            try
            {
                var data = await _productService.GetAllPagingAsync(request);
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
