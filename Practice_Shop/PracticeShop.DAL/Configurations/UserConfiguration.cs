using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Configurations
{
    public class UserConfiguration:EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users")
                .HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(50);
            
            Property(p => p.Password)
                .IsRequired()
                .HasMaxLength(30);

            Property(p => p.PasswordSalt)
                .IsRequired()
                .HasMaxLength(30);

            Property(p => p.Balance)
                .IsRequired();

            HasMany(p => p.Orders)
                .WithRequired(p => p.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}
