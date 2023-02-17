using BurgerCreator;

class Program
{
    static void Main(string[] args)
    {
        var burger = new BurgersCreator();
        var topBun = new TopBun();
        var bottomBun = new BottomBun();
        var meat = new Meat();
        var cheese = new Cheese();
        var pickles = new Pickles();
        var mustard = new Mustard();
        var sauce = new Sauce();
        var ingredients = new BurgerIngredients();
        var bun = new Bun();
        Console.WriteLine("Bottom and top bun automatically added.");
        Console.WriteLine("Choose burger ingredients: ");
        while (true) 
        {
            Console.WriteLine("1 - Add Bun.");
            Console.WriteLine("2 - Add Meat.");
            Console.WriteLine("3 - Add Cheese.");
            Console.WriteLine("4 - Add Pickles.");
            Console.WriteLine("5 - Add Mustard.");
            Console.WriteLine("6 - Add Sauce.");
            Console.WriteLine("If you're done press '7' to see your burger.");
            var choice = Console.ReadKey().Key;
            Console.WriteLine();
            if (choice == ConsoleKey.D1)
            {
                Console.Clear();
                ingredients.BurgersIngredients.Add(bun.AddBun());
            }
            else if (choice == ConsoleKey.D2)
            {
                Console.Clear();
                ingredients.BurgersIngredients.Add(meat.AddMeat());
            }
            else if (choice == ConsoleKey.D3)
            {
                Console.Clear();
                ingredients.BurgersIngredients.Add(cheese.AddCheese());
            }
            else if (choice == ConsoleKey.D4)
            {
                Console.Clear();
                ingredients.BurgersIngredients.Add(pickles.AddPickles());
            }
            else if (choice == ConsoleKey.D5)
            {
                Console.Clear();
                ingredients.BurgersIngredients.Add(mustard.AddMustard());
            }
            else if (choice == ConsoleKey.D6)
            {
                Console.Clear();
                ingredients.BurgersIngredients.Add(sauce.AddSauce());
            }
            else if (choice == ConsoleKey.D7)
            {
                Console.Clear();
                burger.Burger = ingredients.BurgersIngredients;
                burger.Burger.Add(topBun.AddTopBun());
                burger.Burger[0] = bottomBun.AddBottomBun();
                for (int i = burger.Burger.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(burger.Burger[i].ToString());
                }
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong input.");
            } 
        }
    }
}
