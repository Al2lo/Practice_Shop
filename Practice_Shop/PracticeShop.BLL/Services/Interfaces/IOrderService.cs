using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.Services.Interfaces
{
    public interface IOrderService
    {
        Task AddOrderAsync(int UserID);
        Task DeleteCategoryAsync(int OrderID);
        Task UpdateCategoryAsync(int OrderID, int UserID);
    }
}
