using BurgerCreator;
using BurgerCreator.BurgerCreator;

class Program
{
    static void Main(string[] args)
    {
        var burger = new BurgerCreator.BurgerCreator.BurgerCreator()
            //.AddBun()
            .AddMeat()
            .AddMustard()
            .AddPickles()
            .AddCheese()
            .AddBun();
        //burger.ShowBurgerIngredients();
        //var burger = new BurgerCreator.BurgerCreator.BurgerCreator();
        bool isBurgerValid = burger.IsValidBurger();
        if(isBurgerValid)
        {
            burger.ShowBurgerIngredients();
        }
        else
        {
            Console.WriteLine("Invalid burger.");
        }
    }
}
