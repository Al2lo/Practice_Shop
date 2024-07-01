
using PracticeShop.BLL.DTOs.User;

namespace PracticeShop.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task CreateUserAsync(UserDTO user);
        Task UpdateUserAsync(UpdateUser user);
    }
}
