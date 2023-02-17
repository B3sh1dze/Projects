using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonaldMenu
{
    public class Burger
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public List<Burger> ChosenMcFood { get; set; } = new List<Burger>();
        public Burger()
        {

        }
        public Burger(string name, double price)
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
