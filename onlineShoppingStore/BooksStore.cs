using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShoppingStore
{
    public class BooksStore
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string? Country { get; set; }
        public string? Year { get; set; }
        public int PagesCount { get; set; }
        public int Price { get; set; }
        public string? Genre { get; set; }
        private const string USERS_MONEY_FILE_PATH = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\UserMoneyCount.txt";
        public void BooksMenu()
        {
            string lastLine = "";
            using (StreamReader reader = new StreamReader(USERS_MONEY_FILE_PATH))
            {
                while (!reader.EndOfStream)
                {
                    lastLine = reader.ReadLine()!;
                }
            }
            int Money = Convert.ToInt32(lastLine);
            Console.WriteLine("hello to books store");
            Console.WriteLine("Your balance is: " + Money);
            Console.WriteLine("press 1 to view The lord of the rings saga.");
            Console.WriteLine("press 2 to view Harry Potter's saga.");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1)
            {
                Console.Clear();
                TheLordOfTheRingsWorld();
                Console.WriteLine($"If you want to buy this book you must pay {Price} dollars.");
                Console.WriteLine("If you agree this purchase press 'y'.");
                Console.WriteLine("If you do't agree press 'n'");
                char agreement = Convert.ToChar(Console.ReadLine()!);
                UsersBalance obj1 = new UsersBalance();
                Console.WriteLine("Your balance: " + Money);
                if (agreement == 'y')
                {
                    if (Money >= Price)
                    {
                        int balanceAfter = Money - Price;
                        Console.WriteLine($"Congratulations you bought {Name}.");
                        Console.WriteLine($"Your balance now is: {balanceAfter}$");
                        File.AppendAllText(USERS_MONEY_FILE_PATH, $"you bought {Name} for:${Price} - at {DateTime.Now}" + Environment.NewLine);
                        File.AppendAllText(USERS_MONEY_FILE_PATH, balanceAfter + Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine("We are sorry! you haven't enought balance to make this purchase.");
                    }
                }
                else if (agreement == 'n')
                {
                    Console.WriteLine("Thanks for your opinion.");
                    Console.WriteLine("if you want to return to books menu press 1");
                    var num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 == 1)
                    {
                        Console.Clear();
                        BooksMenu();
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
            else if(choice == 2)
            {
                Console.Clear();
                HarryPottersWorld();
                Console.WriteLine($"If you want to buy this book you must pay {Price} dollars.");
                Console.WriteLine("If you agree this purchase press 'y'.");
                Console.WriteLine("If you do't agree press 'n'");
                char agreement = Convert.ToChar(Console.ReadLine()!);
                Console.WriteLine("Your balance: " + Money);
                if (agreement == 'y')
                {
                    if (Money >= Price)
                    {
                        int balanceAfter = Money - Price;
                        Console.WriteLine($"Congratulations you bought {Name}.");
                        Console.WriteLine($"Your balance now is: {balanceAfter}$");
                        File.AppendAllText(USERS_MONEY_FILE_PATH, $"you bought {Name} for: ${Price} - at {DateTime.Now}" + Environment.NewLine);
                        File.AppendAllText(USERS_MONEY_FILE_PATH, balanceAfter + Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine("We are sorry! you haven't enought balance to make this purchase.");
                    }
                }
                else if (agreement == 'n')
                {
                    Console.WriteLine("Thanks for your opinion.");
                    Console.WriteLine("if you want to return to books menu press 1");
                    var num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 == 1)
                    {
                        Console.Clear();
                        BooksMenu();
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }

        }
        public void TheLordOfTheRingsWorld()
        {
            Console.WriteLine("There is 3 part of this book.");
            Console.WriteLine("1. The Lord of the Rings: The Fellowship of the Ring.");
            Console.WriteLine("2. The Lord of the Rings: The Two Towers.");
            Console.WriteLine("2. The Lord of the Rings: The Return of the King.");
            Console.WriteLine("Choose which one you want to get informed about.");
            int LOTR = Convert.ToInt32(Console.ReadLine());
            if(LOTR == 1)
            {
                Name = "The Lord of the Rings: The Fellowship of the Ring";
                Author = "J.R.R. Tolkien";
                Country = "England";
                Year = "29th July 1954";
                PagesCount = 479;
                Price = 30;
                Genre = "High fantasy, Adventure";
                Console.WriteLine($"The name: {Name}");
                Console.WriteLine($"The Author: {Author}");
                Console.WriteLine($"Country: {Country}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Pages count: {PagesCount}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Genre: {Genre}");
            }
            else if(LOTR == 2 )
            {
                Name = "The Lord of the Rings: The Two Towers";
                Author = "J.R.R. Tolkien";
                Country = "England";
                Year = "11th November 1954";
                PagesCount = 415;
                Price = 30;
                Genre = "High fantasy, Adventure";
                Console.WriteLine($"The name: {Name}");
                Console.WriteLine($"The Author: {Author}");
                Console.WriteLine($"Country: {Country}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Pages count: {PagesCount}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Genre: {Genre}");
            }
            else if(LOTR == 3)
            {
                Name = "The Lord of the Rings: The Return of the King";
                Author = "J.R.R. Tolkien";
                Country = "England";
                Year = "20th October 1955";
                PagesCount = 347;
                Price = 30;
                Genre = "High fantasy, Adventure";
                Console.WriteLine($"The name: {Name}");
                Console.WriteLine($"The Author: {Author}");
                Console.WriteLine($"Country: {Country}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Pages count: {PagesCount}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Genre: {Genre}");
            }
            

        }
        public void HarryPottersWorld()
        {
            Console.WriteLine("In Harry Potter's saga there is 7 books");
            Console.WriteLine("1. Harry Potter and The Philosopher's stone.");
            Console.WriteLine("2. Harry Potter and Chamber of Secrets.");
            Console.WriteLine("3. Harry Potter and Prisoner of Azkaban.");
            Console.WriteLine("4. Harry Potter and Goblet of Fire.");
            Console.WriteLine("5. Harry Potter and Order of the Phoenix.");
            Console.WriteLine("6. Harry Potter and Half-Blood Prince.");
            Console.WriteLine("7. Harry Potter and Deathly Hallows.");
            Console.WriteLine("You can choose which one you want.");
            int HP = Convert.ToInt32(Console.ReadLine());
            if(HP == 1)
            {
                Name = "Harry Potter and The Philosopher's stone";
                Author = "J.K. Rowling";
                Country = "England";
                Year = "26th June 1997";
                PagesCount = 223;
                Price = 30;
                Genre = "fantasy";
                Console.WriteLine($"The name: {Name}");
                Console.WriteLine($"The Author: {Author}");
                Console.WriteLine($"Country: {Country}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Pages count: {PagesCount}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Genre: {Genre}");
            }
            else if(HP == 2)
            {
                Name = "Harry Potter and Chamber of Secrets";
                Author = "J.K. Rowling";
                Country = "England";
                Year = "2nd July 1998";
                PagesCount = 251;
                Price = 30;
                Genre = "fantasy";
                Console.WriteLine($"The name: {Name}");
                Console.WriteLine($"The Author: {Author}");
                Console.WriteLine($"Country: {Country}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Pages count: {PagesCount}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Genre: {Genre}");
            }
            else if (HP == 3)
            {
                Name = "Harry Potter and Prisoner of Azkaban";
                Author = "J.K. Rowling";
                Country = "England";
                Year = "8th July 1999";
                PagesCount = 317;
                Price = 30;
                Genre = "fantasy";
                Console.WriteLine($"The name: {Name}");
                Console.WriteLine($"The Author: {Author}");
                Console.WriteLine($"Country: {Country}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Pages count: {PagesCount}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Genre: {Genre}");
            }
            else if (HP == 4)
            {
                Name = "Harry Potter and Goblet of Fire";
                Author = "J.K. Rowling";
                Country = "England";
                Year = "8th July 2000";
                PagesCount = 636;
                Price = 30;
                Genre = "fantasy";
                Console.WriteLine($"The name: {Name}");
                Console.WriteLine($"The Author: {Author}");
                Console.WriteLine($"Country: {Country}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Pages count: {PagesCount}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Genre: {Genre}");
            }
            else if (HP == 5)
            {
                Name = "Harry Potter and Order of the Phoenix";
                Author = "J.K. Rowling";
                Country = "England";
                Year = "21th June 2003";
                PagesCount = 766;
                Price = 30;
                Genre = "fantasy";
                Console.WriteLine($"The name: {Name}");
                Console.WriteLine($"The Author: {Author}");
                Console.WriteLine($"Country: {Country}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Pages count: {PagesCount}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Genre: {Genre}");
            }
            else if (HP == 6)
            {
                Name = "Harry Potter and Half-Blood Prince";
                Author = "J.K. Rowling";
                Country = "England";
                Year = "16th July 2005";
                PagesCount = 607;
                Price = 30;
                Genre = "fantasy";
                Console.WriteLine($"The name: {Name}");
                Console.WriteLine($"The Author: {Author}");
                Console.WriteLine($"Country: {Country}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Pages count: {PagesCount}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Genre: {Genre}");
            }
            else if (HP == 7)
            {
                Name = "Harry Potter and Deathly Hallows";
                Author = "J.K. Rowling";
                Country = "England";
                Year = "21th July 2007";
                PagesCount = 607;
                Price = 30;
                Genre = "fantasy";
                Console.WriteLine($"The name: {Name}");
                Console.WriteLine($"The Author: {Author}");
                Console.WriteLine($"Country: {Country}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Pages count: {PagesCount}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Genre: {Genre}");
            }
        }

    }
}