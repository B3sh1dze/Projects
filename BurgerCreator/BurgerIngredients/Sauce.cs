using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BurgerCreator.BurgerIngredients.Meat;

namespace BurgerCreatorProgram.BurgerIngredients
{
    public class Sauce
    {
        public enum BurgerSauces
        {
            Classic,
            BeerCheese,
            Jalapeno,
            ChipotelaFeta
        }
        public string ChooseSauce()
        {
            Console.WriteLine("Choose sauce:");
            Array sauces = Enum.GetValues(typeof(BurgerSauces));
            for (int i = 0; i < sauces.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {sauces.GetValue(i)}");
            }
            int selectedSauceIndex = int.Parse(Console.ReadLine()!) - 1;
            BurgerSauces selectedSauce = (BurgerSauces)sauces.GetValue(selectedSauceIndex)!;
            return selectedSauce.ToString();
        }

    }
}
