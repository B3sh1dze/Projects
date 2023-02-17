using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerCreator
{
    internal class Pickles : BurgerIngredients
    {
        public string AddPickles()
        {
            Console.WriteLine("Pickles added.");
            return "Pickles";
        }
    }
}
