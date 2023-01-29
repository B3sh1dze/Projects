using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShoppingStore
{
    public class User
    {
        public int UserBalance { get; set; }
        //private const string USERS_FILE_PATH = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\bin\Debug\net6.0\guroo.txt";
        //private const string USERS_EMAILS_FILE_PATH = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\UserEmails.txt";
        private const string USER_MONEY_COUNT_FILE_PATH = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\UserMoneyCount.txt";
        //private const string USER_INFORMATION_FILE_PATH = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\UserInfo.txt";
        private const string PASSWORDS_FILE_PATH = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\passwords.txt";
        public static void MainMenu(string userName)
        {
            while (true)
            {
                
                Console.WriteLine("******************************************");
                Console.WriteLine("ONLINE\t\t SHOPPING\t    STORE");
                Console.WriteLine("******************************************");
                Console.WriteLine("you can chose one of this options.");
                Console.WriteLine("press 1 to get more information about cars.");
                Console.WriteLine("press 2 to get informed about books store.");
                Console.WriteLine("press 3 to have access to our online super market.");
                Console.WriteLine("press 4 to show your balance inforormation.");
                Console.WriteLine("press 5 to exit.");
                var userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                {
                    Console.Clear();
                    CarsInformation cars = new CarsInformation();
                    Console.WriteLine("Please enter your balance for cars.");
                    int carBalance = Convert.ToInt32(Console.ReadLine());
                    cars.CarsMenu();
                }
                else if (userChoice == 2)
                {
                    Console.Clear();
                    BooksStore books = new BooksStore();
                    books.BooksMenu();
                }
                else if (userChoice == 3)
                {
                    SuperMarketStore obj = new SuperMarketStore();
                    obj.SuperMarketMenu();
                }
                else if (userChoice == 4)
                {
                    UsersBalance obj = new UsersBalance();
                    obj.ViewUsersBalance();
                }
                else if (userChoice == 5)
                {
                    break;
                }
                else
                {

                }
            }
        }
        public void LetUserIn(string userName)
        {

            Console.WriteLine("hello there ");
            Console.WriteLine("press 1 to log in.");
            Console.WriteLine("press 2 to register");
            int playerChoice = Convert.ToInt32(Console.ReadLine());
            if (playerChoice == 1)
            {
                Console.WriteLine("Please enter username: ");
                userName = Console.ReadLine() + ".txt";
                bool isUserRegistered = IsUserNameRegistered(userName!);
                if (isUserRegistered)
                {
                    Console.Write("Please enter your password: ");
                    var password = Console.ReadLine();
                    bool running = IsPasswordCorrct(password!);
                    if (running)
                    {
                        Console.WriteLine($"welcome back {userName}");
                        MainMenu(userName!);
                    }
                    else
                    {
                        Console.WriteLine("password is incorrect.");
                    }
                }
                else
                {
                    Console.WriteLine($"there is no account with this username: {userName}. to get access please register first."); 
                }
            }
            else if(playerChoice == 2)
            {
                RegisterUser();
                MainMenu(userName);
            }
            else
            {
                Console.WriteLine("Invalid operator. please choose correct one.");
            }
        }
        public void RegisterUser()
        {
            var user = CreateUser();
            if (user == null)
            {
                return;
            }
            var formattedUser = user.ToString();
            //File.AppendAllText(USER_INFORMATION_FILE_PATH, formattedUser + Environment.NewLine);
        }
        public UserInformation CreateUser()
        {
            Console.Write("Enter your first name: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            var lastName = Console.ReadLine();
            Console.Write("Enter your Email adress: ");
            var email = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();
            Console.Write("Enter your username: ");
            var userName = Console.ReadLine();
            string fileName = userName + ".txt";
            UserBalance = GetBalance();
            UsersBalance obj = new UsersBalance()
            {
                Balance = UserBalance
            };
            Console.Write("Enter your date of birth(mm-dd-yyyy): ");
            DateTime DOF =Convert.ToDateTime(Console.ReadLine());
            Console.Write("Date of registration is: ");
            DateTime DOR = DateTime.Now;
            Console.WriteLine(DOR);
            File.Create(fileName).Dispose();
            File.WriteAllText(fileName, "This is a new file for user: " + userName + Environment.NewLine);
            Console.WriteLine(obj.BalanceInfo());
            var newUser = new UserInformation()
            {
                FirstName = firstName,
                LastName = lastName,
                UserEmail = email,
                UserName = userName,
                Password = password,
                DateOfBirth = DOF,
                MoneyCount = UserBalance,
                LogInDate = DOR
            };
            File.AppendAllText(fileName, newUser + Environment.NewLine);
            File.AppendAllText(USER_MONEY_COUNT_FILE_PATH, UserBalance + Environment.NewLine);
            return newUser;
        }
        public bool IsUserNameRegistered(string userName)
        {
            string fileName = userName;
            if (File.Exists(fileName))
            {
                Console.WriteLine("This file already exists!");
                return true;
            }
            return false;
        }
        public bool IsPasswordCorrct(string password)
        {
            var passwords = File.ReadAllLines(PASSWORDS_FILE_PATH);
            foreach (var pass in passwords)
            {
                var passWord = UserInformation.CheckPassword(pass);
                if(passWord.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public int GetBalance()
        {
            Console.Write("Enter a Balance: $");
            int input = Convert.ToInt32(Console.ReadLine());
            UsersBalance obj = new UsersBalance();
            obj.Balance = input;
            return obj.Balance;
        }
    }
}
