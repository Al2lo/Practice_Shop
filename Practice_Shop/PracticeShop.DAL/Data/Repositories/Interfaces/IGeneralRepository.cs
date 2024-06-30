
namespace PracticeShop.DAL.Data.Repositories.Interfaces
{
    public interface IGeneralRepository<T>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task Delete(T entity);
        public Task Update(T entity);
        public Task Add(T entity);
    }
}
