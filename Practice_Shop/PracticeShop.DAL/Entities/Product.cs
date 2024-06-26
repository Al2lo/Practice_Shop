using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Cost { get; set; }
        public Guid Category_Id { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderItem> OrderItems{ get; set; }
    }
}
