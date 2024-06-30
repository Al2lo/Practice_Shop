using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeShop.DAL.Entities;

namespace PracticeShop.DAL.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users")
                .HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Password)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(p => p.PasswordSalt)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(p => p.Balance)
                .IsRequired();

            builder.HasMany(p => p.Orders)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}
