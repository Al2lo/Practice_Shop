using Microsoft.EntityFrameworkCore;
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
    internal class ProductRepository : GeneralRepository<Product>, IProductRepository<Product>
    {
        public ProductRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }

        public Task<IEnumerable<Product>> GetByCategory(Category category)
        {
            return (Task<IEnumerable<Product>>)table.Where<Product>(prod => prod.Category.Id == category.Id);
        }
    }
}
