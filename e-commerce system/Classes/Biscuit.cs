using e_commerce_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system.Classes
{

    public class Biscuit : Product, IExpirable
    {
        public DateTime ExpiryDate { get; }
        public Biscuit(string name, decimal price, int quantity, DateTime expirydate) : base(name, price, quantity)
        {
            this.ExpiryDate = expirydate;
            
        }

    }
}