using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float Balance { get; set; }
        public string Password { get; set; }
        public string Password_Salt { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
