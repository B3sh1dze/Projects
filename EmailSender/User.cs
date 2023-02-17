using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public class User
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public List<Email> UserEmail { get; set; } = new List<Email>();
        public User RegisterUser()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();
            Console.Write("Enter your Email: ");
            var email = Console.ReadLine();
            bool isEmailUsed = IsEmailUsed(email!);
            if(!isEmailUsed) 
            {
                var user = new User()
                {
                    Name = name,
                    Email = email,
                    Password = password
                };
                Users.Add(user);
                user.ShowUserInformation();
                return user;
            }
            else
            {
                Console.WriteLine("Sorry that email is already exists.");
                return null!;
            }
        }
        public override string ToString()
        {
            return
                $"Name: {Name}\n" +
                $"Password: {Password}\n" +
                $"Email: {Email}\n";
        }
        public void ShowUserInformation()
        {
            foreach (var user in Users)
            {
                Console.WriteLine(user);
            }
        }
        private bool IsEmailUsed(string email)
        {
            var generatedUsers = new UserGenerator();
            var users = generatedUsers.GeneratedUsers();
            Users = generatedUsers.Users;
            foreach (var user in users)
            {
                if(email == user.Email)
                {
                    return true;
                }
            }
            return false;
        }
        private void AttemptsCountingOnEmail(int attemptCount)
        {
            while (true)
            {
                Console.Write("Enter your email: ");
                var email = Console.ReadLine();
                bool isEmailCorrect = IsEmailCorrect(email!);
                if (isEmailCorrect)
                {
                    Console.WriteLine("Access granted.");
                    break;
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
                            UserLogIn();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice.");
                        }
                    }
                }
            }
        }
        private void AttemptsCountingOnPassword()
        {
            int attemptCount = 0;
            while (true)
            {
                Console.Write("Enter your password: ");
                var password = Console.ReadLine();
                bool isPasswordCorrect = IsPasswordCorrect(password!);
                if (isPasswordCorrect)
                {
                   AttemptsCountingOnEmail(attemptCount);
                    break;
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
                            UserLogIn();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice.");
                        }
                    }
                }
            }
        }
        public void UserLogIn()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            bool isUservalid = IsUserValid(name!);
            if (isUservalid)
            {
                AttemptsCountingOnPassword();
            }
            else
            {
                Console.WriteLine("Wrong username.");
            }
        }
        private bool IsUserValid(string name)
        {
            var generatedUsers = new UserGenerator();
            var users = generatedUsers.GeneratedUsers();
            Users = generatedUsers.Users;
            foreach (var user in users)
            {
                if(name == user.Name)
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
                if(user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsEmailCorrect(string email)
        {
            var generatedUsers = new UserGenerator();
            var users = generatedUsers.GeneratedUsers();
            Users = generatedUsers.Users;
            foreach (var user in users)
            {
                if(email == user.Email)
                {
                    return true;
                }
            }
            return false;
        }
        public void ShowUserSentMessage()
        {
            foreach (var message in UserEmail)
            {
                Console.WriteLine(message.SentMessage);
            }
        }
        public void ShowUserReceivedMessage()
        {
            foreach (var message in UserEmail)
            {
                Console.WriteLine(message.ReceivedMessage);
            }
        }
    }
}
