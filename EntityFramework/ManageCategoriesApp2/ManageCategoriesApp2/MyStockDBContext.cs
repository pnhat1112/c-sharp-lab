using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace ManageCategoriesApp2
{
    public class Category
    {
        public Category() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
    internal class MyStockDBContext:DbContext
    {
        public MyStockDBContext() { }
        public DbSet<Category> Catagories { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration= builder.Build();
            optionsBuilder.UseMySQL(configuration.GetConnectionString("MyStockDB"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()
                .HasMaxLength(40);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Name 1" },
                new Category { CategoryId = 2, CategoryName = "Name 2" },
                new Category { CategoryId = 3, CategoryName = "Name 3" });
        }
    }
}
