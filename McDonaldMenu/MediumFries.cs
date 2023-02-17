using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonaldMenu
{
    public class MediumFries : Fries
    {
        public MediumFries(string name, double price) : base(name, price)
        {
            Name = name;
            Price = price;
        }
    }
}
