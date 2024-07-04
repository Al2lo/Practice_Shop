using PracticeShop.DAL.Data.Repositories.Interfaces;
using PracticeShop.DAL.Entities;


namespace PracticeShop.DAL.Data.Repositories
{
    public class UserRepository : GeneralRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }

        public async Task<User> GetById(Guid id, CancellationToken cancellationToken)
        {
            return await table.FindAsync(id);
        }
    }
}
