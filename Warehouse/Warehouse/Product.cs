using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseNamespace
{
    // საკვები, ელექტრო ტექნიკა, სპორტული ინვენტარი, წიგნი და ა.შ.
    public enum Category {
        Food = 1,
        Tech = 2,
        Sport = 3,
        Book = 4,
        Other = 5,
    }

    public class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }
        public Product(string name, Category category, double price, int quantity)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
        }

        public void ProductInformation()
        {
            Console.WriteLine($"Product Information:   name - {Name}, category - {Category},   price - {Price},   quantity - {Quantity}");
        }

    }
}
