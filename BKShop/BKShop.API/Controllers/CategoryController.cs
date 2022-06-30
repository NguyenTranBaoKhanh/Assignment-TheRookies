using BKShop.Application.Interfaces;
using BKShop.Data.EF;
using BKShop.Data.Entities;
using BKShop.ViewModels.Requests.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BKShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly BKShopDbContext _context;
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService )
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            //var categories = _context.Categories.ToList();
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("Accessory")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAccessoryAsync()
        {
            //var categories = _context.Categories.ToList();
            var categories = await _categoryService.GetAccessoryAsyn();
            return Ok(categories);
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int Id) //[FromRoute] int id
        {
            try
            {
                //var categories = _context.Categories.FirstOrDefault(p => p.Id == id);
                var category = await _categoryService.GetByIdAsync(Id);
                if(category == null)
                {
                    return NotFound($"Cannot find a category with Id: {Id}");
                }
                return Ok(category);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryCreateRequest request)
        {
            //_context.Categories.Add(categories);
            //await _context.SaveChangesAsync();
            var categoryId = await _categoryService.CreateAsync(request);
            if(categoryId == 0)
            {
                return BadRequest();
            }
            var data = await _categoryService.GetByIdAsync(categoryId);
            if(data == null)
            {
                return NotFound($"Cannot find a category with Id: {categoryId}");
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
                var result = await _categoryService.DeleteAsync(Id);
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
        public async Task<IActionResult> Update([FromBody] CategoryUpdateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _categoryService.UpdateAsync(request);

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
