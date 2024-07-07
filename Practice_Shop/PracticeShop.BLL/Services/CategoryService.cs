using PracticeShop.BLL.DTOs.Category;
using PracticeShop.BLL.DTOs.Product;
using PracticeShop.BLL.Services.Interfaces;
using PracticeShop.DAL.Data.Repositories.Interfaces;
using PracticeShop.DAL.Entities;
using SendGrid.Helpers.Errors.Model;

namespace PracticeShop.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        IUnitOfWork unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task AddCategoryAsync(CreateCategory model) {

            var category = await unitOfWork.CategoryRepository.GetCategoryByName(model.Name);
            if(category != null)
            {
                throw new BadRequestException("Category with such name is already exist");
            }

            await unitOfWork.CategoryRepository.Add(new Category() { Name = model.Name});
        }

        public async Task DeleteCategoryAsync(int id)
        {
           var category = await unitOfWork.CategoryRepository.GetById(id);
            if(category == null)
            {
                throw new BadRequestException("Category with such id doesn't exist");
            }

            await unitOfWork.CategoryRepository.Delete(category);
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync()
        {
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
            var categories = await unitOfWork.CategoryRepository.GetAll();
            foreach(var category in categories)
            {
                categoryDTOs.Add(new CategoryDTO() { Name = category.Name, Products = (ICollection<ProductDTO>)category.Products });
            }
            return categoryDTOs;
        }

        public async Task UpdateCategoryAsync(UpdateCategory model)
        {
            var category = await unitOfWork.CategoryRepository.GetById(model.Id);
            if (category == null)
            {
                throw new BadRequestException("Such category doesn't exist");
            }

            await unitOfWork.CategoryRepository.Update(new Category() { Id = model.Id, Name = model.Name});
        }
    }
}
