using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BurgerCreator.Meat;

namespace BurgerCreator
{
    public class Cheese : BurgerIngredients
    {
        public enum BurgerCheese
        {
            Stilton,
            Gouda,
            Provolone,
            Cheddar
        }
        public string AddCheese()
        {
            string[] cheese = Enum.GetNames(typeof(BurgerCheese));
            Console.WriteLine();
            Console.WriteLine("Select a cheese for burger:");
            for (int i = 0; i < cheese.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cheese[i]}");
            }
            int selection;
            if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= cheese.Length)
            {
                var selectedCheese = (BurgerCheese)Enum.Parse(typeof(BurgerCheese), cheese[selection - 1]);
                var selectedCheeseString = selectedCheese.ToString();
                Console.WriteLine($"You selected {selectedCheese}.");
                return selectedCheeseString;
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                return null;
            }
        }
    }
}
