using PracticeShop.DAL.Data.Repositories.Interfaces;

namespace PracticeShop.DAL.Data.Repositories
{
    public class CategoryRepository : GeneralRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationContext dbContext) : base(dbContext)
        {
            
        }
    }
}
