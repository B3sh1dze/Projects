using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShoppingStore
{
    public class User
    {
        private const string USERS_EMAILS_FILE_PATH = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\UserEmails.txt";
        private const string USER_MONEY_COUNT_FILE_PATH = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\UserMoneyCount.txt";
        private const string USER_INFORMATION_FILE_PATH = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\UserInfo.txt";
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
                Console.WriteLine("press 4 to exit.");
                var userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                {
                    Console.Clear();
                    CarsInformation cars = new CarsInformation();
                    Console.WriteLine("Please enter your balance for cars.");
                    int carBalance = Convert.ToInt32(Console.ReadLine());
                    UsersBalance balance = new UsersBalance()
                    {
                        BalanceForCars = carBalance
                    };
                    cars.CarsMenu(carBalance);
                }
                else if (userChoice == 2)
                {
                    Console.Clear();
                    BooksStore books = new BooksStore();
                    books.BooksMenu();
                }
                else if (userChoice == 3)
                {

                }
                else if (userChoice == 4)
                {
                    break;
                }
                else
                {

                }
            }
        }

        public void LetUserIn()
        {
            Console.Write("please enter your temporary username: ");
            var userName = Console.ReadLine();
            Console.WriteLine($"hello there {userName}");
            Console.WriteLine("press 1 to log in.");
            Console.WriteLine("press 2 to register");
            int playerChoice = Convert.ToInt32(Console.ReadLine());
            if (playerChoice == 1)
            {
                Console.WriteLine("Please enter email: ");
                var userEmail = Console.ReadLine();
                bool isUserRegistered = IsUserEmailRegistered(userEmail!);
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
                    Console.WriteLine($"there is no account with this email: {userEmail}. to get access please register first."); 
                }
            }
            else if(playerChoice == 2)
            {
                RegisterUser();
                MainMenu(userName!);
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
            File.AppendAllText(USER_INFORMATION_FILE_PATH, formattedUser + Environment.NewLine);
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
            Console.Write("Enter amount of money you have for onlain shopping: ");
            var money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your date of birth(mm-dd-yyyy): ");
            DateTime DOF =Convert.ToDateTime(Console.ReadLine());
            Console.Write("Date of registration is: ");
            DateTime DOR = DateTime.Now;
            Console.WriteLine(DOR);
            var newUser = new UserInformation()
            {
                FirstName = firstName,
                LastName = lastName,
                UserEmail = email,
                UserName = userName,
                Password = password,
                DateOfBirth = DOF,
                MoneyCount = money,
                LogInDate = DOR
            };
            File.AppendAllText(USERS_EMAILS_FILE_PATH, email + Environment.NewLine);
            File.AppendAllText(PASSWORDS_FILE_PATH, password + Environment.NewLine);
            File.AppendAllText(USER_MONEY_COUNT_FILE_PATH,"$" + money + Environment.NewLine);
            return newUser;
        } 
        public bool IsUserEmailRegistered(string userEmail)
        {
            var checking = File.ReadAllLines(USERS_EMAILS_FILE_PATH);

            foreach (var emails in checking)
            {
                var email = UserInformation.checkUser(emails);
                if(email.UserEmail == userEmail)
                {
                    return true;
                }
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
    }
}
