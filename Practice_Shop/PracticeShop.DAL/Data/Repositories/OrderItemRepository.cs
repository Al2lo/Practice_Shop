using PracticeShop.DAL.Data.Repositories.Interfaces;
using PracticeShop.DAL.Entities;

namespace PracticeShop.DAL.Data.Repositories
{
    public class OrderItemRepository:GeneralRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
