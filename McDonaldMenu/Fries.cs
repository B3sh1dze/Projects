using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonaldMenu
{
    public class Fries
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public List<Fries> ChosenMcFood { get; set; } = new List<Fries>();
        public Fries()
        {

        }
        public Fries(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return
                $"food: {Name} -- Price: ${Price}";
        }
    }
}
