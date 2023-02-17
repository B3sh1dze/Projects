using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BurgerCreator.Cheese;

namespace BurgerCreator
{
    public class Sauce : BurgerIngredients
    {
        public enum BurgerSauces
        {
            classic,
            BeerCheese,
            Jalapeno,
            ChipotelaFeta
        }
        public string AddSauce()
        {
            string[] Sauce = Enum.GetNames(typeof(BurgerSauces));
            Console.WriteLine();
            Console.WriteLine("Select a Sauce for burger:");
            for (int i = 0; i < Sauce.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Sauce[i]}");
            }
            int selection;
            if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= Sauce.Length)
            {
                var selectedSauce = (BurgerSauces)Enum.Parse(typeof(BurgerSauces), Sauce[selection - 1]);
                var selectedSauceString = selectedSauce.ToString();
                Console.WriteLine($"You selected {selectedSauce}.");
                return selectedSauceString;
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                return null;
            }
        }
    }
}
