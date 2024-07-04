
namespace PracticeShop.BLL.DTOs.Category
{
    public class CategoryDTO
    {
        public string Name{ get; set; }
        public ICollection<ProductDTO> Products { get; set; }
    }
}
