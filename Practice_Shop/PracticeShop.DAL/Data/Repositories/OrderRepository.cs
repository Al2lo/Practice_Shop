using PracticeShop.DAL.Data.Repositories.Interfaces;
using PracticeShop.DAL.Entities;
using PracticeShop.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeShop.DAL.Data.Repositories
{
    public class OrderRepository : GeneralRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationContext dbContext) : base(dbContext) { }
    }
}
