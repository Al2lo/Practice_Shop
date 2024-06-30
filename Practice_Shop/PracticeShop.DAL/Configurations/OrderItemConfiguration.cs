using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Configurations
{
    public class OrderItemConfiguration:EntityTypeConfiguration<OrderItem>
    {
        public OrderItemConfiguration()
        {
            ToTable("OrderItems")
                .HasKey(p => p.Id);

            Property(p => p.Amount)
                .IsRequired();

            HasRequired(p => p.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(p => p.ProductId);

            HasRequired(p => p.Order)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(p => p.OrderId);
        }
    }
}
