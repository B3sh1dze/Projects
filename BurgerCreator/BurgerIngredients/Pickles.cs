using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BurgerCreator.BurgerIngredients.Meat;
using static BurgerCreator.BurgerIngredients.Pickles;

namespace BurgerCreator.BurgerIngredients
{
    public class Pickles
    {
        public enum BurgerPickles
        {
            Classic,
            Greenhouse,
            GenuineDill,
            Sweet
        }
        public string ChoosePickles()
        {
            Console.WriteLine("Choose pickles:");
            Array Pickles = Enum.GetValues(typeof(BurgerPickles));
            for (int i = 0; i < Pickles.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Pickles.GetValue(i)}");
            }
            int selectedPicklesIndex = int.Parse(Console.ReadLine()!) - 1;
            BurgerPickles selectedPickles = (BurgerPickles)Pickles.GetValue(selectedPicklesIndex)!;
            return selectedPickles.ToString();
        }
    }
}
