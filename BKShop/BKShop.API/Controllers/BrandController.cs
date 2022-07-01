using BKShop.Application.Interfaces;
using BKShop.Data.EF;
using BKShop.Data.Entities;
using BKShop.ViewModels.Requests.Brand;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BKShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly BKShopDbContext _context;
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            //var products = _context.Brands.ToList();
            var brand = await _brandService.GetAllAsync();
            return Ok(brand);
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById([FromRoute] int Id)
        {
            try
            {
                //var product = _context.Brands.FirstOrDefault(p => p.Id == id);
                var brand = await _brandService.GetByIdAsync(Id);
                if(brand == null)
                {
                    return NotFound($"Cannot find a brand with Id: {Id}");
                }
                return Ok(brand);

            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("Name/{Name}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByName([FromRoute]string Name)
        {
            try
            {
                //var product = _context.Brands.FirstOrDefault(p => p.Id == id);
                var brand = await _brandService.GetByNameAsync(Name);
                if (brand == null)
                {
                    return NotFound($"Cannot find a brand with Name: {Name}");
                }
                return Ok(brand);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] BrandCreateRequest request)
        {
            //_context.Brands.Add(brand);
            //await _context.SaveChangesAsync();
            var brandId = await _brandService.CreateAsync(request);
            if(brandId == 0)
            {
                return BadRequest();
            }
            var data = await _brandService.GetByIdAsync(brandId);
            if(data == null)
            {
                return NotFound($"Cannot find a brand with Id: {brandId}");
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
                var result = await _brandService.DeleteAsync(Id);
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
        public async Task<IActionResult> Update([FromBody] BrandUpdateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _brandService.UpdateAsync(request);

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
    }
}
