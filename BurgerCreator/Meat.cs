using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerCreator
{
    public class Meat : BurgerIngredients
    {
       public enum BurgerMeats
        {
            Pork,
            beef,
            salmon,
            Lamb
        }
        public string AddMeat()
        {
            string[] meats = Enum.GetNames(typeof(BurgerMeats));
            Console.WriteLine();
            Console.WriteLine("Select a meat for burger:");
            for (int i = 0; i < meats.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {meats[i]}");
            }
            int selection;
            if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= meats.Length)
            {
                var selectedMeat = (BurgerMeats)Enum.Parse(typeof(BurgerMeats), meats[selection - 1]);
                var selectedMeatString = selectedMeat.ToString();
                Console.WriteLine($"You selected {selectedMeat}.");
                return selectedMeatString;
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                return null;
            }
        }
    }
}
