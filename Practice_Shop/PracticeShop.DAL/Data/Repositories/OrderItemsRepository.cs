using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Data.Repositories
{
    public class OrderItemsRepository:GeneralRepository<OrderItem>
    {
        public OrderItemsRepository(ApplicationContext dbContext) :base(dbContext)
        {
        }
    }
}
