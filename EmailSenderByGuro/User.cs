using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmailSenderByGuro
{
    public class User
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public long ? ID { get; set; } = new Random().Next();
        public List<User> Users { get; set; } = new List<User>();
        public List<Email> UserEmail { get; set; } = new List<Email>();
        public User()
        {

        }
        public User(string name, string password, string email)
        {
            Name = name;
            Email = email;
            Password = password;
        }
        public User RegisterUser()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();
            Console.Write("Enter your Email: ");
            var email = Console.ReadLine();
            bool isEmailUsed = IsEmailUsed(email!);
            if (!isEmailUsed)
            {
                var user = new User()
                {
                    Name = name,
                    Email = email,
                    Password = password
                };
                Users.Add(user);
                Console.Clear();
                Console.WriteLine("User succesfully registered.");
                return user;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sorry that email is already exists.");
                return null!;
            }
        }
        private bool IsEmailUsed(string email)
        { 
            foreach (var user in Users)
            {
                if (email == user.Email)
                {
                    return true;
                }
            }
            return false;
        }
        public User UserLogIn()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            bool isUservalid = IsUserValid(name!);
            if (isUservalid)
            {
                return AttemptsCountingOnPassword(name!);
            }
            else
            {
                Console.WriteLine("Wrong username.");
                return null!;
            }
        }
        private User AttemptsCountingOnPassword(string name)
        {
            int attemptCount = 0;
            start:
            while (true)
            {
                Console.Write("Enter your password: ");
                var password = Console.ReadLine();
                bool isPasswordCorrect = IsPasswordCorrect(password!);
                if (isPasswordCorrect)
                {
                    return AttemptsCountingOnEmail(attemptCount, name, password!);
                }
                else
                {
                    attemptCount++;
                    Console.WriteLine("Password is incorrect.");
                    if (attemptCount == 3)
                    {
                        Console.WriteLine("Wait for 10 seconds or log in to another account?");
                        Console.WriteLine("Enter 'w' to wait or 'l' to log in to another account: ");
                        string userChoice = Console.ReadLine()!;

                        if (userChoice == "w")
                        {
                            Console.WriteLine("Wait for 10 seconds.");
                            Console.WriteLine();
                            Stopwatch stopwatch = Stopwatch.StartNew();
                            while (stopwatch.ElapsedMilliseconds < 10000)
                            {
                                // wait for 10 seconds
                            }
                        }
                        else if (userChoice == "l")
                        {
                            Console.WriteLine("Log in to another account.");
                            return UserLogIn();
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice.");
                        }
                    }
                    goto start;
                }
            }
        }
        private User AttemptsCountingOnEmail(int attemptCount, string name, string password)
        {
            start:
            while (true)
            {
                Console.Write("Enter your email: ");
                var email = Console.ReadLine();
                bool isEmailCorrect = IsEmailValid(email!);
                if (isEmailCorrect)
                {
                    Console.Clear();
                    var newEmail = new Email();
                    Console.WriteLine("Access granted.");
                    var user = new User();
                    user.Name = name;
                    user.Password = password;
                    user.Email = email;
                    newEmail.UsersChoiceInEmailSendOption(user, Users);
                    return user;
                }
                else
                {
                    attemptCount++;
                    Console.WriteLine("Wrong email.");
                    if (attemptCount == 3)
                    {
                        Console.WriteLine("Wait for 10 seconds or log in to another account?");
                        Console.WriteLine("Enter 'w' to wait or 'l' to log in to another account: ");
                        string userChoice = Console.ReadLine()!;

                        if (userChoice == "w")
                        {
                            Console.WriteLine("Wait for 10 seconds.");
                            Console.WriteLine();
                            Stopwatch stopwatch = Stopwatch.StartNew();
                            while (stopwatch.ElapsedMilliseconds < 10000)
                            {
                                // wait for 10 seconds
                            }
                        }
                        else if (userChoice == "l")
                        {
                            Console.WriteLine("Log in to another account.");
                            return UserLogIn();
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice.");
                        }
                    }
                    goto start;
                }
            }
        }
        private bool IsUserValid(string name)
        {
            foreach (var user in Users)
            {
                if(user.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsPasswordCorrect(string password)
        {
            foreach (var user in Users)
            {
                if (user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsEmailValid(string email)
        {
            foreach (var user in Users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return 
                $"name: {Name}\n" +
                $"password: {Password}\n" +
                $"email: {Email}\n" +
                $"ID: {ID}.";
        }
    }
}
