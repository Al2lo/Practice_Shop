using PracticeShop.DAL.Data.Repositories.Interfaces;


namespace PracticeShop.DAL.Data.Repositories
{
    public class UserRepository : GeneralRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
