using BKShop.ViewModels.Common;
using BKShop.ViewModels.Requests.System.Users;
using BKShop.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> AuthenticateAsync(LoginRequest request);
        Task<List<UserViewModel>> GetAllAsync();

        Task<UserViewModel> GetByIdAsync(Guid Id);

        Task<ApiResult<string>> Register(RegisterRequest request);

        Task<ApiResult<string>> UpdateUser(UserUpdateRequest request);
    }
}
