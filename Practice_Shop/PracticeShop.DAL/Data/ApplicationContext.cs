using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PracticeShop.WebAPI
{
    public class ApplicationContext : DbContext
    {
        //public DbSet<Users> Users { get; set; } = null!;
        //public DbSet<Orders> Orders { get; set; } = null!;
        //public DbSet<OrderItem> OrderItem { get; set; } = null!;
        //public DbSet<Products> Products { get; set; } = null!;
        //public DbSet<Categories> Categories { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //DbContextConfiguration.ConfigureEntities(modelBuilder);
            //DbContextConfiguration.SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
