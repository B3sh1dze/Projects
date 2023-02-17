using McDonaldMenu;
Console.WriteLine("Welcome to McDonald's Menu. Please choose which one you want.");
var burger = new Burger();
var fries = new Fries();
double totalPrice = 0;
while(true)
{
    Console.WriteLine("1 - Hamburger");
    Console.WriteLine("2 - CheeseBurger");
    Console.WriteLine("3 - BigMac");
    Console.WriteLine("4 - SmallFries");
    Console.WriteLine("5 - MediumFries");
    Console.WriteLine("6 - BigFries");
    Console.WriteLine("7 - Show chosen Mc Foods and total Price");
    Console.WriteLine("8 - Exit");
    var choice = Console.ReadKey().Key;
    if (choice == ConsoleKey.D1)
    {
        Console.Clear();
        Console.Write("Please enter the number of hamburgers you want: ");
        var hamburgerCount = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (int.TryParse(hamburgerCount.ToString(), out int numHamburgers))
        {
            for (int i = 0; i < numHamburgers; i++)
            {
                var hamburger = new Hamburger("Hamburger", 12.23);
                burger.ChosenMcFood.Add(hamburger);
                totalPrice += hamburger.Price;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
    else if (choice == ConsoleKey.D2)
    {
        Console.Clear();
        Console.Write("Please enter the number of cheeseBurgers you want: ");
        var cheeseBurgerCount = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (int.TryParse(cheeseBurgerCount.ToString(), out int numCheeseburgers))
        {
            for (int i = 0; i < numCheeseburgers; i++)
            {
                var cheeseBurger = new CheeseBurger("CheeseBurger", 11.45);
                burger.ChosenMcFood.Add(cheeseBurger);
                totalPrice += cheeseBurger.Price;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

    }
    else if (choice == ConsoleKey.D3)
    {
        Console.Clear();
        Console.Write("Please enter the number of Big Macs you want: ");
        var bigMacCount = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (int.TryParse(bigMacCount.ToString(), out int numBigMacs))
        {
            for (int i = 0; i < numBigMacs; i++)
            {
                var bigMac = new BigMac("BigMac", 15.65);
                burger.ChosenMcFood.Add(bigMac);
                totalPrice += bigMac.Price;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

    }
    else if (choice == ConsoleKey.D4)
    {
        Console.Clear();
        Console.Write("Please enter the number of Small Fries you want: ");
        var smallFriesCount = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (int.TryParse(smallFriesCount.ToString(), out int numSmallFries))
        {
            for (int i = 0; i < numSmallFries; i++)
            {
                var smallFries = new SmallFries("SmallFries", 5.67);
                fries.ChosenMcFood.Add(smallFries);
                totalPrice += smallFries.Price;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
    else if (choice == ConsoleKey.D5)
    {
        Console.Clear();
        Console.Write("Please enter the number of Medium Fries you want: ");
        var mediumFriesCount = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (int.TryParse(mediumFriesCount.ToString(), out int numMediumFries))
        {
            for (int i = 0; i < numMediumFries; i++)
            {
                var mediumFries = new MediumFries("MediumFries", 8.46);
                fries.ChosenMcFood.Add(mediumFries);
                totalPrice += mediumFries.Price;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
    else if (choice == ConsoleKey.D6)
    {
        Console.Clear();
        Console.Write("Please enter the number of Medium Fries you want: ");
        var bigFriesCount = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (int.TryParse(bigFriesCount.ToString(), out int numBigFries))
        {
            for (int i = 0; i < numBigFries; i++)
            {
                var bigFries = new BigFries("BigFries", 8.46);
                fries.ChosenMcFood.Add(bigFries);
                totalPrice += bigFries.Price;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
    else if (choice == ConsoleKey.D7)
    {
        Console.Clear();
        Console.WriteLine("Chosen burgers: ");
        foreach (var group in burger.ChosenMcFood.GroupBy(food => food.Name))
        {
            Console.WriteLine($"{group.Key} x{group.Count()}");
        }
        Console.WriteLine("Chosen fries: ");
        foreach (var group in fries.ChosenMcFood.GroupBy(food => food.Name))
        {
            Console.WriteLine($"{group.Key} x{group.Count()}");
        }
        Console.WriteLine($"Total Price: ${totalPrice}");
        break;
    }
    else if (choice == ConsoleKey.D8)
    {
        Console.Clear();
        break;
    }
    else Console.WriteLine("Wrong input");
}