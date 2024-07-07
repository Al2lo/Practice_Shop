using PracticeShop.DAL.Data.Repositories.Interfaces;
using PracticeShop.DAL.Entities;

namespace PracticeShop.DAL.Data.Repositories
{
    public class CategoryRepository : GeneralRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationContext dbContext) : base(dbContext)
        {
            
        }
    }
}
