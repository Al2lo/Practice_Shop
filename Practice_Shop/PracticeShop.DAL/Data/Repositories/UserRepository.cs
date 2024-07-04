using PracticeShop.DAL.Data.Repositories.Interfaces;
using PracticeShop.DAL.Entities;
using PracticeShop.WebAPI;


namespace PracticeShop.DAL.Data.Repositories
{
    public class UserRepository : GeneralRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
