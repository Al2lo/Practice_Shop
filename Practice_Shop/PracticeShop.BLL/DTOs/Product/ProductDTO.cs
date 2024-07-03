using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.DTOs.Product
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public int CategoryId { get; set; }
    }
}
