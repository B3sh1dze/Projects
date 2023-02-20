using BurgerCreator.BurgerIngredients;
using BurgerCreatorProgram.BurgerIngredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerCreator.BurgerCreator
{
    public class BurgerCreator
    {
        public List<string> Ingredients { get; set; } = new List<string>(); 
        public bool IsValidBurger()
        {
            if(Ingredients.First() == "Bun" && Ingredients.Last() == "Bun")
            {
                return true;
            }
            return false;
        }
        public void ShowBurgerIngredients()
        {
            for(int i = Ingredients.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(Ingredients[i]);
            }
        }
        public BurgerCreator AddBun()
        {
            Ingredients.Add("Bun");
            return this;
        }
        public BurgerCreator AddMeat()
        {
            var meat = new Meat();
            var ChosenMeat = meat.ChooseMeat();
            Ingredients.Add(ChosenMeat);
            return this;
        }
        public BurgerCreator AddCheese()
        {
            var cheese = new Cheese();
            var chosenCheese = cheese.ChooseCheese();
            Ingredients.Add(chosenCheese);
            return this;
        }
        public BurgerCreator AddPickles()
        {
            var pickles = new Pickles();
            var chosenPickles = pickles.ChoosePickles();
            Ingredients.Add(chosenPickles);
            return this;
        }
        public BurgerCreator AddMustard()
        {
            var mustard = new Mustard();
            var chosenMustard = mustard.ChooseMustard();
            Ingredients.Add(chosenMustard);
            return this;
        }
        public BurgerCreator AddSauce()
        {
            var sauce = new Sauce();
            var ChosenSauce = sauce.ChooseSauce();
            Ingredients.Add(ChosenSauce);
            return this;
        }
    }
}
