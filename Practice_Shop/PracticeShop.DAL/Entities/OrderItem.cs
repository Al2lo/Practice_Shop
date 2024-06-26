using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
