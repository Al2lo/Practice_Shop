using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Configurations
{
    public class ProductConfiguration:EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("Products")
                .HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Cost)
                .IsRequired();

            HasRequired(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId);

            HasMany(P =>P.OrderItems)
                .WithRequired(p => p.Product)
                .HasForeignKey(p => p.ProductId);
        }
    }
}
