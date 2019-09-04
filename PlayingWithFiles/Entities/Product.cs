using System;
using System.Globalization;

namespace Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }   
        
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double total()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return  Name
                    + ","
                    + total().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
