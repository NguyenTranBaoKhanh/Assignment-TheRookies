using BKShop.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BKShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAllAsync();
            if (users == null)
            {
                return NotFound("Can not find any account!");
            }
            return Ok(users);
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById([FromRoute]Guid Id)
        {
            var user = await _userService.GetByIdAsync(Id);
            if (user == null)
            {
                return NotFound($"Can not find any account with id {Id}");
            }
            return Ok(user);
        }
    }
}
