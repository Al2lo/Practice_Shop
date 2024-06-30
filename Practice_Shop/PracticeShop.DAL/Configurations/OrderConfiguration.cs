using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Configurations
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            ToTable("Orders")
                .HasKey(p => p.Id);

            Property(p => p.Date)
                .IsRequired();

            HasRequired(p => p.User)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.UserId);

            HasMany(p=>p.OrderItems)
                .WithRequired(p => p.Order)
                .HasForeignKey(p => p.OrderId);
        }
    }
}
