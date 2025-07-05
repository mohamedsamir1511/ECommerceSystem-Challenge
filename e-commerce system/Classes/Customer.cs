using e_commerce_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system.Classes
{
    public class Customer
    {
        public string Name {  get; set; }
        public decimal Balance {  get; set; }
        public Cart Cart { get; set; }

        public Customer() { }

        public Customer(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
            Cart = new Cart();
        }
        


    }
}
