using Microsoft.EntityFrameworkCore;
using PracticeShop.DAL.Entities;
using System.Collections.Generic;

namespace PracticeShop.WebAPI
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItem { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //DbContextConfiguration.ConfigureEntities(modelBuilder);
            //DbContextConfiguration.SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
