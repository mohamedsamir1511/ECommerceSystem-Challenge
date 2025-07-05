using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system.Classes
{
    public class ScratchCard : Product
    {
        public ScratchCard(string name, decimal price, int quantity) : base(name, price, quantity)
        {
        }
    }
}
