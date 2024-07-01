using PracticeShop.BLL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.Services.Interfaces
{
    internal interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        Task<IEnumerable<ProductDTO>> GetProductsByCategoryAsync(int categoryId);
        Task<ProductDTO> GetProductByIdAsync(int id);
        Task AddProductAsync(ProductDTO productDTO);
        Task DeleteProductAsync(int id);
        Task UpdateProductAsync(UpdateProductDTO productDTO);

    }
}
