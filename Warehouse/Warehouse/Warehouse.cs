using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WarehouseNamespace
{
    public class Warehouse
    {
        public List<Product> Products { get; set; } = new List<Product>();
        private Validation validator = new Validation();

        private bool IsUniqueProduct(string name)
        {
            foreach (var product in Products)
            {
                if(product.Name == name)
                {
                    return true;
                }
            }
            return false;
        }


        public Product RegisterProduct(string name, Category category, double price, int quantity)
        {
            try
            {
                validator.NameValidation(name);

                if (!Enum.IsDefined(typeof(Category), category))
                {
                    throw new ArgumentException($"{category} is not valid.");
                }

                if (price <= 0)
                {
                    throw new ArgumentOutOfRangeException($"{price} cannot be less or equal to 0");
                }

                if (quantity < 0)
                {
                    throw new ArgumentOutOfRangeException($"{quantity} cannot be less than 0");
                }

                var prod = new Product(name, category, price, quantity);
                Products.Add(prod);
                return prod;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error occured: {e.Message}");
                return new Product();
            }

        }
        
        public void DeleteProduct(Product product)
        {
            Products.Remove(product);
        }

        public void ListAllProducts()
        {
            if(Products.Count == 0) {
                Console.WriteLine("No registered products.");
                return;
            }
            Console.WriteLine("List of all products:");
            foreach(Product product in Products)
            {
                product.ProductInformation();
            }
        }

        public void ChangeProductPriceAndQuantity(Product selectedProduct, string newName, int newQuantity)
        {
            validator.NameValidation(newName);

            if (IsUniqueProduct(newName))
            {
                throw new ArgumentException("name");
            }

            if (newQuantity < 0)
            {
                throw new ArgumentOutOfRangeException($"{newQuantity} cannot be less than 0");
            }

            foreach (var product in Products)
            {
                if(product.Name == selectedProduct.Name) {
                    product.Name = newName;
                    product.Quantity = newQuantity; 
                    break;
                }
            }
        }

        

    }
}
