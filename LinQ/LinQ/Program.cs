using System.Collections.Generic;
using System.Linq;
using static Programs;

class Programs
{
    static void Main(string[] args)
    {
        var brands = new List<Brand>() {
            new Brand{ID = 1, Name = "Cong ty AAA"},
            new Brand{ID = 2, Name = "Cong ty BBB"},
            new Brand{ID = 3, Name = "Cong ty CCC"},
        };
        var products = new List<Product>()
        {
            new Product(1, "Ban tra",    400, new string[] {"Xam", "Xanh"},         2),
            new Product(2, "Tranh treo", 400, new string[] {"Vang", "Xanh"},        1),
            new Product(3, "den trum",   500, new string[] {"Trang"},               3),
            new Product(4, "Ban hoc",    200, new string[] {"Trang", "Xanh"},       1),
            new Product(5, "Tui da",     300, new string[] {"do", "den", "Vang"},   2),
            new Product(6, "Giuong ngu", 500, new string[] {"Trang"},               2),
            new Product(7, "Tu ao",      600, new string[] {"Trang"},               3),
        };

        /*In san pham gia 500*/
        var ketqua = from product in products
                     where product.Price == 500
                     select product;
        Console.WriteLine("San pham gia 500");
        foreach (var product in ketqua)
        {
            Console.WriteLine(product.ToString());
        }
        /*Danh Sach Ten San Pham*/
        var ketquaName = from product in products
                         select product.Name;
        Console.WriteLine("Danh Sach Ten San Pham");
        foreach (var name in ketquaName) Console.WriteLine(name);

        /*Danh Sach KQ Where*/
        var ketquaWhere = from product in products
                          where product.Price >= 400
                          where product.Name.StartsWith("Ban")
                          select product;
        Console.WriteLine("Danh Sach San Pham Gia > 400 Ten Bat Dau la: Ban ");
        foreach (var name in ketquaWhere) Console.WriteLine(name);
        /*Danh Sach KQ From*/
        var ketquaFrom = from product in products
                         from color in product.Colors
                         where product.Price < 500
                         where color == "Vang"
                         select product;
        Console.WriteLine("Danh Sach San Pham Gia < 500 Mau Vang ");
        foreach (var name in ketquaFrom) Console.WriteLine(name);

        /*Danh Sach KQ OderBy*/
        var ketquaOderBy = from product in products
                           where product.Price <= 300
                           orderby product.Price descending
                           select product;
        Console.WriteLine("Danh Sach San Pham Gia <= 300 Sap xep theo Price ");
        foreach (var product in ketquaOderBy) Console.WriteLine($"{product.Name} - {product.Price}");

        /*Danh Sach KQ Group By*/
        var ketquaGroup = from product in products
                          where product.Price >= 400 && product.Price <= 500
                          group product by product.Price;
        Console.WriteLine("Danh Sach San Pham Gia >= 400 hoac <= 500  ");
        foreach (var group in ketquaGroup)
        {
            // Key là giá trị dùng để phân loại (nhóm): là giá
            Console.WriteLine(group.Key);
            foreach (var product in group)
            {
                Console.WriteLine($"    {product.Name} - {product.Price}");
            }

        }

        /*Danh Sach KQ Inner Join*/
        var ketquaInnerJoin = from product in products
                              join brand in brands on product.Brand equals brand.ID
                              select new
                              {
                                  name = product.Name,
                                  brand = brand.Name,
                                  price = product.Price
                              };
        Console.WriteLine("Danh Sach San Pham Cung Brand San Xuat Inner Join ");
        foreach (var item in ketquaInnerJoin)
        {
            Console.WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");
        }

        /*Danh Sach KQ Left Join*/
        var ketquaLeftJoin = from product in products
                             join brand in brands on product.Brand equals brand.ID into t
                             from brand in t.DefaultIfEmpty()
                             select new
                             {
                                 name = product.Name,
                                 brand = (brand == null) ? "NO-BRAND" : brand.Name,
                                 price = product.Price
                             };
        Console.WriteLine("Danh Sach San Pham Cung Brand San Xuat Left Join ");
        foreach (var item in ketquaLeftJoin)
        {
            Console.WriteLine($"{item.name,10} {item.price,4} {item.brand,12}");

        }
    }


    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }         // tên
        public double Price { set; get; }        // gia
        public string[] Colors { set; get; }     // cac mau sac
        public int Brand { set; get; }           // ID Nhãn hiệu, hãng
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thong tin sản phẳm gồm ID, Name, Price
        override public string ToString()
           => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";


    }
    public class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }
    }
}