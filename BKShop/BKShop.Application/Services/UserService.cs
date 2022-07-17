using BKShop.Application.Interfaces;
using BKShop.Data.EF;
using BKShop.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.Services
{
    public class UserService : IUserService
    {
        private readonly BKShopDbContext _context;

        public UserService(BKShopDbContext context)
        {
            _context = context;
        }
        public async Task<List<UserViewModel>> GetAllAsync()
        {
            return await _context.Users.Select(user => new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Phone = user.Phone,
                Address = user.Address,
                Email = user.Email,

            }).ToListAsync();
        }

        public async Task<UserViewModel> GetByIdAsync(Guid Id)
        {
            var user = await _context.Users.Where(user => user.Id == Id).FirstOrDefaultAsync();
            if(user == null)
            {
                return null;
            }
            return new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Phone = user.Phone,
                Address = user.Address,
                Email = user.Email
            };
        }
    }
}
