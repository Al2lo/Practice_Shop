using PracticeShop.BLL.DTOs.Product;
using PracticeShop.BLL.Services.Interfaces;
using PracticeShop.DAL.Data;
using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.Services
{
    internal class ProductService : IProductService
    {
        private UnitOfWork unitOfWork;

        public ProductService(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task AddProductAsync(ProductDTO productDTO, CancellationToken cancellationToken)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                Product product = new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = productDTO.Name,
                    Description = productDTO.Description,
                    Cost = productDTO.Cost,
                    CategoryId = productDTO.CategoryId
                };

                await unitOfWork.ProductRepository.Add(product);
            }
       
        }

        public async Task DeleteProductAsync(Guid id, CancellationToken cancellationToken)
        {
            if (id != null)
            {
                await unitOfWork.ProductRepository.Delete(new Product() { Id = id });
            }
            else
                throw new Exception("");
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync(CancellationToken cancellationToken)
        {
            var products = await unitOfWork.ProductRepository.GetAll();
            List<ProductDTO> result = new List<ProductDTO>();
            if (products != null)
            {

                foreach (var product in products)
                {
                    result.Add(new ProductDTO()
                    {
                        Name = product.Name,
                        CategoryId = product.CategoryId,
                        Cost = product.Cost,
                        Description = product.Description
                    });
                }
            }
            else throw new Exception("");
            return result;

        }

        public async Task<ProductDTO> GetProductByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.ProductRepository.GetById(id);
            ProductDTO result;
            if (product != null)
            {
                result = new ProductDTO()
                {
                    Name = product.Name,
                    CategoryId = product.CategoryId,
                    Cost = product.Cost,
                    Description = product.Description
                };
            }
            else throw new Exception("");
            return result;
        }

        public async Task<IEnumerable<ProductDTO>> GetProductsByCategoryAsync(int categoryId, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.ProductRepository.GetByCategory(new Category() { Id = categoryId });
            List<ProductDTO> result = new List<ProductDTO>();
            if (products != null)
            {

                foreach (var product in products)
                {
                    result.Add(new ProductDTO()
                    {
                        Name = product.Name,
                        CategoryId = product.CategoryId,
                        Cost = product.Cost,
                        Description = product.Description
                    });
                }
            }
            else throw new Exception("");
            return result;
        }

        public async Task UpdateProductAsync(UpdateProductDTO productDTO, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.ProductRepository.GetById(productDTO.Id);
            if (product != null)
            {
                await unitOfWork.ProductRepository.Update(new Product()
                {
                    Id = productDTO.Id,
                    Name = productDTO.Name,
                    CategoryId = productDTO.CategoryId,
                    Cost = productDTO.Cost,
                    Description = productDTO.Description
                });
            }
            else throw new Exception("");
        }
    }
}
