
using PracticeShop.BLL.DTOs.User;

namespace PracticeShop.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllAsync();
        Task CreateUserAsync(UserDTO user);
        Task UpdateUserAsync(UpdateUser user);
        Task DeleteUserAsync(Guid id);
    }
}
