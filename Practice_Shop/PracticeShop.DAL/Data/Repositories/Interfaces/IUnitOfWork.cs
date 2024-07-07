using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Data.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        CategoryRepository CategoryRepository { get; }
        OrderItemRepository OrderItemRepository { get; }
        OrderRepository OrderRepository { get; }
        ProductRepository ProductRepository { get; }
        UserRepository UserRepository { get; }

    }
}
