using PracticeShop.DAL.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using PracticeShop.WebAPI;

namespace PracticeShop.DAL.Data.Repositories
{
    public class GeneralRepository<T> : IGeneralRepository<T> where T : class
    {
        public ApplicationContext dbContext;
        public DbSet<T> table;
        public GeneralRepository(ApplicationContext dbContext)
        {
            this.dbContext = dbContext;
            table = this.dbContext.Set<T>();
        }
        public async Task Add(T entity)
        {
            await table.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            table.Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.AsNoTracking().ToListAsync<T>();
        }

        public async Task<T> GetById(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task Update(T entity)
        {
            table.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
