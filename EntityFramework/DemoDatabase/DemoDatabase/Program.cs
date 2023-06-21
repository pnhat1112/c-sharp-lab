using DemoDatabase.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Tls;


namespace DemoDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mystoreContext mystore = new mystoreContext();

            var products = from p in mystore.Products select new { p.ProductName, p.CategoryId };

            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.ProductName}, Category ID: {product.CategoryId}");
            }
            Console.WriteLine("-xxx-xxx-");
            IQueryable<Category> cats = mystore.Categories.Include(c => c.Products);

            foreach (Category c in cats)
            {
                Console.WriteLine($"Category ID: {c.CategoryId} has {c.Products.Count} products.");
            }
            FilteredIncludes();
            QueryingProducts();
            AggregateProduct();
            Console.ReadLine();
        }
        static void FilteredIncludes()
        {
            using var db = new mystoreContext();
            Console.WriteLine("Enter Minimum for Units in Stock: ");
            string unitInStock = Console.ReadLine();
            int stock = int.Parse(unitInStock);
            IQueryable<Category> cats = db.Categories.Include(c => c.Products.Where(p => p.UnitslnStock >= stock));
            foreach (Category c in cats)
            {
                Console.WriteLine($"Category ID: {c.CategoryId} has {c.Products.Count} products.");
                foreach(Product p in c.Products)
                {
                    Console.WriteLine($"xxxx->: {p.ProductName} has {p.UnitslnStock} units in stock.");
                }
            }
        }
        static void QueryingProducts()
        {
            using (var context = new mystoreContext())
            {
                Console.WriteLine("Products that cost more than a price, the highest at the top");
                string input;
                double price;
                do
                {
                    Console.Write("Enter a product's price:");
                    input = Console.ReadLine();

                }
                while (!double.TryParse(input, out price));

                IQueryable<Product> prod = context.Products
                    .Where(product => product.UnitPrice > price)
                    .OrderByDescending(product => product.UnitPrice);
                Console.WriteLine("");
                foreach (Product item in prod)
                {
                    Console.WriteLine($"Produce: {item.ProductName} cost {item.UnitPrice} and has {item.UnitslnStock} left in stock");
                }
            }
        }
        static void AggregateProduct()
        {
            using (var context = new mystoreContext())
            {
                Console.WriteLine($"Product count: {context.Products.Count()}");
                Console.WriteLine($"Highest product price: {context.Products.Max(p => p.UnitPrice)}");
                Console.WriteLine($"Sum of unit in stock: {context.Products.Sum(p => p.UnitslnStock)}" );
                Console.WriteLine($"Average Unit Price: {context.Products.Average(p => p.UnitslnStock)}" );
            }
        }
    }
}
