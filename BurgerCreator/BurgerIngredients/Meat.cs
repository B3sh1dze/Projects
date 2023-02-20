using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerCreator.BurgerIngredients
{
    public class Meat
    {
        public enum BurgerMeats
        {
            Beef,
            Pork,
            Chicken,
            Salmon
        }
        public string ChooseMeat()
        {
            Console.WriteLine("Choose meat:");
            Array meats = Enum.GetValues(typeof(BurgerMeats));
            for (int i = 0; i < meats.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {meats.GetValue(i)}");
            }
            int selectedMeatIndex = int.Parse(Console.ReadLine()!) - 1;
            BurgerMeats selectedMeat = (BurgerMeats)meats.GetValue(selectedMeatIndex)!;
            return selectedMeat.ToString();
        }
    }
}
