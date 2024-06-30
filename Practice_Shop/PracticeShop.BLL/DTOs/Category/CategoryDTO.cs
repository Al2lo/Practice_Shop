using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.DTOs.Category
{
    public class CategoryDTO
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
