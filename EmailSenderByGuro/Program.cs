using EmailSenderByGuro;

class PRogram
{
    public static void Main(string[] args)
    {
        var user1 = new User("guro","1234","guro@gmail.com");
        var user2 = new User("jimi", "jimi1234", "jimi@gmail.com");
        user1.Users.Add(user1);
        user1.Users.Add(user2);
        while (true)
        {
            Console.WriteLine("1 - Log in.");
            Console.WriteLine("2 - Register.");
            Console.WriteLine("3 - Exit.");
            var choice = Console.ReadKey().Key;
            Console.WriteLine();
            if(choice == ConsoleKey.D1)
            {
                // log in
                user1.UserLogIn();
            }
            else if(choice == ConsoleKey.D2)
            {
                // Register
                user1.RegisterUser();
            }
            else if(choice == ConsoleKey.D3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
