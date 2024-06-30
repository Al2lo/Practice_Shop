using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Configurations
{
    public class CategoryConfiguration:EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories")
                .HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            HasMany(p => p.Products)
                .WithRequired(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
