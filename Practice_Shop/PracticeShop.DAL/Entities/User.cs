
namespace PracticeShop.DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float Balance { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
