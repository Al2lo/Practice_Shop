
using PracticeShop.DAL.Entities;

namespace PracticeShop.DAL.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetById(Guid id, CancellationToken cancellationToken);

    }
}
