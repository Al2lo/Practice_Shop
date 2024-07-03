using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.DTOs.Order
{
    public class UpdateOrder
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
    }
}
