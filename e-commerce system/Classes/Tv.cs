using e_commerce_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system.Classes
{
    public class Tv:Product,IShippable
    {
        public double Weight { get; }
        public Tv(string name, decimal price, int quantity,double weight) : base(name, price, quantity)
        {
            this.Weight = weight;
        }
        


    }
}
