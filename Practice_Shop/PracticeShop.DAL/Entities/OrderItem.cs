using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Entities
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public float Amount { get; set; }
        public Guid Product_Id { get; set; }
        public virtual Product Product { get; set; }
        public Guid Order_Id { get; set; }
        public virtual Order Order { get; set; }
    }
}
