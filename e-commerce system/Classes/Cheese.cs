using e_commerce_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system.Classes
{
    public class Cheese:Product,IExpirable, IShippable
    {
      public DateTime ExpiryDate { get; }
        public double Weight { get; }

        public Cheese(string name, decimal price, int quantity, DateTime expirydate, double weight) : base(name, price, quantity)
        {
            this.ExpiryDate = expirydate;
            this.Weight = weight;
        }

     
        
    }
}
