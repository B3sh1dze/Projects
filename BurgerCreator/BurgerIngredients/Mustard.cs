using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BurgerCreator.BurgerIngredients.Meat;

namespace BurgerCreatorProgram.BurgerIngredients
{
    public class Mustard
    {
        public enum BrugerMustards
        {
            Classic,
            Yellow,
            Red,
            Wasabi
        }
        public string ChooseMustard()
        {
            Console.WriteLine("Choose mustard:");
            Array mustard = Enum.GetValues(typeof(BrugerMustards));
            for (int i = 0; i < mustard.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {mustard.GetValue(i)}");
            }
            int selectedMustardIndex = int.Parse(Console.ReadLine()!) - 1;
            BrugerMustards selectedMustard = (BrugerMustards)mustard.GetValue(selectedMustardIndex)!;
            return selectedMustard.ToString();
        }
    }
}
