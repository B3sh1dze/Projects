using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerCreator
{
    public class Mustard : BurgerIngredients
    {
        public string AddMustard()
        {
            Console.WriteLine("Mustard added.");
            return "Mustard";
        }
    }
}
