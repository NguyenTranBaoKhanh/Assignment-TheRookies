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
        private readonly IWebHostEnvironment _hostEnvironment;
        public ProductController(BKShopDbContext context, IProductService productService, IWebHostEnvironment hostEnvironment)
        {
            _productService = productService;
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            //var products = _context.Products.ToList();
            var products = await _productService.GetAllAsync();
            products.ForEach(p => p.Image = String.Format("{0}://{1}{2}/Upload/{3}", Request.Scheme, Request.Host, Request.PathBase, p.Image));
            return Ok(products);
        }

        [HttpGet("Top5")]
        [AllowAnonymous]
        public async Task<IActionResult> GetTop5()
        {
            //var products = _context.Products.ToList();
            var products = await _productService.GetTop5Async();
            products.ForEach(p => p.Image = String.Format("{0}://{1}{2}/Upload/{3}", Request.Scheme, Request.Host, Request.PathBase, p.Image));
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
                product.Image = String.Format("{0}://{1}{2}/Upload/{3}", Request.Scheme, Request.Host, Request.PathBase, product.Image);
                if (product == null)
                {
                    return NotFound($"Cannot find a product with Id: {Id}");
                }
                return Ok(product);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        // [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            //if (request.ImageFile.FileName == "default.jpg")
            //{
            //    request.Image = "default.jpg";
            //}
            //else
            //{
            //    request.Image = await SaveImage(request.ImageFile);
            //}
            //var ImageSrc = String.Format("{0}://{1}{2}/Upload/{3}", Request.Scheme, Request.Host, Request.PathBase, request.Image);
            //request.Image = ImageSrc;

            var productId = await _productService.CreateAsync(request);
            if (productId == 0)
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

        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).Take(10).ToArray()).Replace(' ', '-');
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "wwwroot/Upload", imageName);
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }
            return imageName;
        }


        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
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

        [HttpGet("Color/{color}/{group}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByColorAndGroup([FromRoute] string color, string group)
        {
            try
            {
                var data = await _productService.GetByColorAndGroupAsync(color, group);
                data.ForEach(p => p.Image = String.Format("{0}://{1}{2}/Upload/{3}", Request.Scheme, Request.Host, Request.PathBase, p.Image));
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Category/{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByCategory([FromRoute] int Id)
        {
            try
            {
                var data = await _productService.GetByCategoryAsync(Id);
                data.ForEach(p => p.Image = String.Format("{0}://{1}{2}/Upload/{3}", Request.Scheme, Request.Host, Request.PathBase, p.Image));
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Brand/{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByBrand([FromRoute] int Id)
        {
            try
            {
                var data = await _productService.GetByBrandAsync(Id);
                data.ForEach(p => p.Image = String.Format("{0}://{1}{2}/Upload/{3}", Request.Scheme, Request.Host, Request.PathBase, p.Image));
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{categoryId}/{brandId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByCategoryByBrand([FromRoute] int categoryId, int brandId)
        {
            try
            {
                var data = await _productService.GetByCategoryByBrandAsync(categoryId, brandId);
                data.ForEach(p => p.Image = String.Format("{0}://{1}{2}/Upload/{3}", Request.Scheme, Request.Host, Request.PathBase, p.Image));
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Accessory")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByAccessory()
        {
            try
            {
                var data = await _productService.GetByAccessoryAsync();
                data.ForEach(p => p.Image = String.Format("{0}://{1}{2}/Upload/{3}", Request.Scheme, Request.Host, Request.PathBase, p.Image));
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Color/{group}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetColorByGroup([FromRoute] string group)
        {
            try
            {
                var data = await _productService.GetColorByGroupAsync(group);
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("UpdateStar")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateStar([FromBody] ProductStarUpdateRequest request)
        {
            var result = await _productService.UpdateStarAsync(request);
            if (result == 0)
            {
                return BadRequest();
            }
            var product = await _productService.GetByIdAsync(request.productId);
            if (product == null)
            {
                return BadRequest();
            }
            return Ok(product);
        }


    }
}
