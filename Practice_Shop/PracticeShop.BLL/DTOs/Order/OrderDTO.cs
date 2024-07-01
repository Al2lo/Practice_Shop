using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.DTOs.Order
{
    public class OrderDTO
    {
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
