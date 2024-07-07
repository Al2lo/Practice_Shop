using PracticeShop.BLL.DTOs.User;

namespace PracticeShop.BLL.DTOs.Order
{
    public class OrderDTO
    {
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public virtual UserDTO User { get; set; }
    }
}
