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
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();
        Task AddCategoryAsync(CreateCategory model);
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(UpdateCategory model);

    }
}
