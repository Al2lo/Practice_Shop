using PracticeShop.BLL.DTOs.Category;
using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task AddCategory(CreateCategory model);
        Task DeleteCategory(int id);

    }
}
