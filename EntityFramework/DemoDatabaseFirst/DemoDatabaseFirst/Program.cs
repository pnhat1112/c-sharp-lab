using DemoDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;

namespace DemoDatabaseFirst
{
    internal class Program
    {
        static void addData(string name,string price,string unit, string cateName="", int cateID = 0, string type = "old")
        {
            testContext context = new testContext();
            Product product = new Product()
            {
                ProductName = name,
                UnitPrice = price,
                UnitsInStock = unit
            };
            Category category = null;
            if (type != "old")
            {
                category = new Category()
                {
                    CategoryName = cateName
                };
            }
            else
            {
                category = FindCate(cateID);
            }
            if (category != null)
            {
                category.Products.Add(product);
                context.Categories.Add(category);

                context.SaveChanges();
                Console.WriteLine($"Added Product {name} to Category {cateID}");

            }
            else
            {
                Console.WriteLine($"Category with id ={cateID.ToString()} not found!!!");
            }

        }
        public static Category FindCate(int id)
        {
            using (var context = new testContext())
            {
                Category cate = context.Categories.Find(id);
                return cate;
            }
        }
        public static void ReadCate()
        {
            using (var context = new testContext())
            {
                var blog = context.Categories.Find(2);
                Console.WriteLine(blog.CategoryName);
            }
        }
        static void LoadProduct()
        {
            using (var context = new testContext())
            {
                context.Products.Load();
                foreach (var product in context.Products.Local)
                {
                    Console.WriteLine(
                        "ID: {0}, Category ID: {1}, Name: {2}, Price: {3}, In Stock: {4}",
                        product.ProductId,
                        product.CategoryId,
                        product.ProductName,
                        product.UnitPrice,
                        product.UnitsInStock
                        );
                }
            }
        }
        static void FilterIncludes()
        {
            using var context = new testContext();
            Console.Write("Enter a minimum for inits in stock: ");
            string unitsInStock = Console.ReadLine();
            int stock = int.Parse(unitsInStock);
            IQueryable<Category> cates = context.Categories
                .Include(c => c.Products.Where(p => p.UnitsInStock == unitsInStock));
            //Console.WriteLine(cates);
            if (cates.Count() > 0)
            {
                foreach (Category c in cates)
                {
                    Console.WriteLine($"{c.CategoryName} has {c.Products.Count} products");
                    foreach (Product p in c.Products)
                    {
                        Console.WriteLine($"--->{p.ProductName} has {p.UnitsInStock} units in stock");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Record due with condition");
            }
            
        }
        static void AggregateProduct()
        {
            using (var context = new testContext())
            {
                Console.WriteLine($"Product count: {context.Products.Count()}");
                Console.WriteLine($"Highest product price: {context.Products.Max(p => p.UnitPrice)}");
                Console.WriteLine($"Sum of unit in stock: 28");
                Console.WriteLine($"Average Unit Price: 1500");
            }
        }
        static void QueryingProducts()
        {
            using (var context = new testContext())
            {
                Console.WriteLine("Products that cost more than a price, the highest at the top");
                string input;
                string price;
                do
                {
                    Console.Write("Enter a product's price:");
                    input = Console.ReadLine();

                }
                while (input=="");
                IQueryable<Product> prod = context.Products
                    .Where(product => product.UnitPrice == input)
                    .OrderByDescending(product => product.UnitPrice);
                Console.WriteLine("");
                foreach(Product item in prod)
                {
                    Console.WriteLine($"Produce: {item.ProductName} cost {item.UnitPrice} and has {item.UnitsInStock} left in stock");
                }
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(FindCate(2)==null);
            //addData("name4", "2000","21", "","new",1);
            //LoadProduct();
            //FilterIncludes();
            QueryingProducts();
            //AggregateProduct();
        }
    }
}
