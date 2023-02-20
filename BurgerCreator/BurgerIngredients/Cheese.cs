using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerCreator.BurgerIngredients
{
    public class Cheese
    {
        public enum BurgerCheese
        {
            PepperJack,
            Stilton,
            Cheddar,
            Gouda
        }
        public string ChooseCheese()
        {
            Console.WriteLine("Choose Cheese:");
            Array Cheese = Enum.GetValues(typeof(BurgerCheese));
            for (int i = 0; i < Cheese.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Cheese.GetValue(i)}");
            }
            int selectedCheeseIndex = int.Parse(Console.ReadLine()!) - 1;
            BurgerCheese selectedCheese = (BurgerCheese)Cheese.GetValue(selectedCheeseIndex)!;
            return selectedCheese.ToString();
        }
    }
}
