using PracticeShop.DAL.Data.Repositories.Interfaces;
using PracticeShop.DAL.Entities;
using System.Data.Entity;

namespace PracticeShop.DAL.Data.Repositories
{
    public class CategoryRepository : GeneralRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationContext dbContext) : base(dbContext)
        {
           
        }
        public async Task<Category> GetCategoryByName(string name)
        {
            return await table.FirstOrDefaultAsync(x => x.Name == name);
        }
    }
}
