using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;

namespace Models
{
    public class MyDbContext : DbContext, ICategoryRepository<Category>, IProductRepository<Product>, IDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProductDatabase;Integrated Security=True;");
        }
    }
}
