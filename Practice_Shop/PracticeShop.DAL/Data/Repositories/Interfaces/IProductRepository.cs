using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Data.Repositories.Interfaces
{
    internal interface IProductRepository<T>
    {
        public Task<IEnumerable<T>> GetByCategory(Category category);
    }
}
