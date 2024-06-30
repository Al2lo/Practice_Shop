using PracticeShop.DAL.Entities;

namespace PracticeShop.DAL.Data.Repositories
{
    public class OrderItemRepository:GeneralRepository<OrderItem>
    {
        public OrderItemRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
