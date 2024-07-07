
using PracticeShop.BLL.DTOs.User;

namespace PracticeShop.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllAsync(CancellationToken cancellationToken);
        Task CreateUserAsync(UserDTO user, CancellationToken cancellationToken);
        Task UpdateUserAsync(UpdateUser user, CancellationToken cancellationToken);
        Task DeleteUserAsync(Guid id, CancellationToken cancellationToken);
    }
}
