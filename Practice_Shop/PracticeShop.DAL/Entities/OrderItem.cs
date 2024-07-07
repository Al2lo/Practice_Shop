
namespace PracticeShop.DAL.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
