using System;
using System.Collections.Generic;

#nullable disable

namespace DemoDatabaseFirst.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public string UnitsInStock { get; set; }

        public virtual Category Category { get; set; }
    }
}
