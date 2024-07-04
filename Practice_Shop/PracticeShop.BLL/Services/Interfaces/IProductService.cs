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
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductDTO>> GetProductsByCategoryAsync(int categoryId, CancellationToken cancellationToken);
        Task<ProductDTO> GetProductByIdAsync(Guid id, CancellationToken cancellationToken);
        Task AddProductAsync(ProductDTO productDTO, CancellationToken cancellationToken);
        Task DeleteProductAsync(Guid id, CancellationToken cancellationToken);
        Task UpdateProductAsync(UpdateProductDTO productDTO, CancellationToken cancellationToken);

    }
}
