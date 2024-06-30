namespace PracticeShop.DAL.Data.Repositories
{
    public class CategoryRepository : GeneralRepository<Category>
    {
        public CategoryRepository(ApplicationContext dbContext) : base(dbContext)
        {
            
        }
    }
}
