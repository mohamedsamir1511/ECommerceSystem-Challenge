using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system.Interfaces
{
    internal interface IExpirable
    {
       public DateTime ExpiryDate { get; }
     

    }
}
