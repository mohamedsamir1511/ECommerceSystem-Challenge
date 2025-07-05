using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system.Classes
{
    public abstract class Product
    {
        public string Name {  get; set; }
        public decimal Price { get; set; }
        public int Quantity {  get; set; }
        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity=quantity;
        }

    }
}
