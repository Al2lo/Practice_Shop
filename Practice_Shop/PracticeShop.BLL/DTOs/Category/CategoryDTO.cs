using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.DTOs.Category
{
    public class CategoryDTO
    {
        public string Name{ get; set; }
        public ICollection<ProductDTO> Products { get; set; }
    }
}
