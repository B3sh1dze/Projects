using EmailSender;
using System.Security.Cryptography.X509Certificates;

class Program 
{
    public static void Main(string[] args)
    {
        while(true)
        {
            var user = new User();
            var email = new Email();
            Console.WriteLine("1 - Log in.");
            Console.WriteLine("2 - Register.");
            Console.WriteLine("3 - Exit.");
            var userChoice = Console.ReadKey().Key;
            Console.WriteLine();
            if(userChoice == ConsoleKey.D1)
            {
                user.UserLogIn();
                email.UsersChoiceInAccesibilityMenu(user, user.Users); 
            }
            else if(userChoice == ConsoleKey.D2)
            {
                user.RegisterUser();
            }
            else if(userChoice == ConsoleKey.D3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input. Try again!");
            }
        }
    }
}

