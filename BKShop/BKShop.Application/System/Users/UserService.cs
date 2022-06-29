using AutoMapper;
using BKShop.Data.EF;
using BKShop.Data.Entities;
using BKShop.Utilities.Exceptions;
using BKShop.ViewModels.Common;
using BKShop.ViewModels.Requests.System.Users;
using BKShop.ViewModels.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly BKShopDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _config;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;
        public UserService(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration config,
            BKShopDbContext context, RoleManager<Role> roleManager, IMapper mapper)
        {
            _context = context;
            _config = config;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task<ApiResult<string>> AuthenticateAsync(LoginRequest request)
        {
            var username = request.UserName;
            var emailCheck = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.UserName);
            if (emailCheck != null)
            {
                username = emailCheck.UserName;
            }
            else
            {
                return new ApiErrorResult<string>("Tài khoản không tồn tại");
            }

            var user = await _userManager.FindByEmailAsync(emailCheck.Email);

            if (user == null) return new ApiErrorResult<string>("Tài khoản không tồn tại");
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return new ApiErrorResult<string>("Đăng nhập không đúng");
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim("Id", user.Id.ToString()),
                new Claim("Role", string.Join(";", roles)),
                new Claim("UserName", user.UserName.ToString()),
                new Claim("Name", user.Name != null ? user.Name.ToString() : ""),
                new Claim("Address", user.Address != null ? user.Address.ToString(): ""),
                new Claim("PhoneNumber", user.PhoneNumber != null ? user.PhoneNumber.ToString() : ""),
                new Claim("Email", user.Email != null ? user.Email.ToString() : ""),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);

            return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
        }

        

        public async Task<List<UserViewModel>> GetAllAsync()
        {
            return await _userManager.Users.Where(m => m.UserName != "admin")
                .Select(x => new UserViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address,
                    PhoneNumber = x.PhoneNumber,
                    Email = x.Email,
                }
            ).ToListAsync();

        }

        public async Task<UserViewModel> GetByIdAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                throw new BKShopException($"Cannot find user with Id = {id}");
            }
            var userVm = new UserViewModel()
            {
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Id = user.Id,
                Address = user.Address,
                Name = user.Name,
            };
            return userVm;
        }

        public async Task<ApiResult<string>> Register(RegisterRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user != null)
            {
                return new ApiErrorResult<string>("Tài khoản đã tồn tại");
            }
            if (await _userManager.FindByEmailAsync(request.Email) != null)
            {
                return new ApiErrorResult<string>("Emai đã tồn tại");
            }

            user = new User()
            {

                Email = request.Email,
                Address = request.Address,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                Name = request.UserName,

            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<string>("Thanh cong");
            }
            return new ApiErrorResult<string>("Đăng ký không thành công");
        }

       

        public async Task<ApiResult<string>> UpdateUser(UserUpdateRequest request)
        {
            var user = await _userManager.Users.AnyAsync(x => x.UserName == request.UserName && x.Id != request.Id);
            if (user == true)
            {
                return new ApiErrorResult<string>("Tài khoản đã tồn tại");
            }
            var mail = await _userManager.Users.AnyAsync(x => x.Email == request.Email && x.Id != request.Id);
            if (mail == true)
            {
                return new ApiErrorResult<string>("Emai đã tồn tại");
            }
            var usr = await _userManager.FindByIdAsync(request.Id.ToString());
            usr.Name = request.UserName;
            usr.Address = request.Address;
            usr.Email = request.Email;
            usr.PhoneNumber = request.PhoneNumber;
            
            
            var result = await _userManager.UpdateAsync(usr);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<string>("Cap nhat thanh cong");
            }
            return new ApiErrorResult<string>("Cập nhật không thành công");
        }

       

        Task<List<UserViewModel>> IUserService.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<UserViewModel> IUserService.GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        
    }
}
