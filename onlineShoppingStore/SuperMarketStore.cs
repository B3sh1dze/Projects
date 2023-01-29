using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace onlineShoppingStore
{
    public class SuperMarketStore
    {
        public string? Product { get; set; }
        public double Price { get; set; }
        public string? ShelfLife { get; set; }
        public bool Sale { get; set; }
        public double PriceAfterSale { get; set; }
        private const string USERS_MONEY_FILE_PATH = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\UserMoneyCount.txt";
            void Crisps()
            {
                List<string> CrispsList = new List<string> { "Pringles", "Frix", "Doritoes", "Lays" };
                List<double> CrispsPrices = new List<double> { 7.89, 3.25, 4.50, 4.20 };
                List<string> CrispsShelfLife = new List<string> { "3 months", "3 months", "3 months", "3 months" };
                List<bool> CrispsSale = new List<bool> { true, false, false, true };
                List<double> CrispsPriceAfterSale = new List<double> { 6.70, 3.25, 4.50, 3.10 };
                Console.WriteLine("Product name \t price \t  shelf life \t sale \t price after sale");
                for (int i = 0; i < CrispsList.Count; i++)
                {
                    Product = CrispsList[i];
                    Price = CrispsPrices[i];
                    ShelfLife = CrispsShelfLife[i];
                    Sale = CrispsSale[i];
                    PriceAfterSale = CrispsPriceAfterSale[i];
                    Console.WriteLine($"{CrispsList[i]} |\t {CrispsPrices[i]} |\t  {CrispsShelfLife[i]} |\t {CrispsSale[i]} |\t {CrispsPriceAfterSale[i]}");
                }
            }
            void Cereals()
            {
                List<string> CerealsList = new List<string> { "pasta", "macaroni", "noodles", "spaghetti" };
                List<double> CerealsPrices = new List<double> { 15.30, 11.90, 8.50, 9.20 };
                List<string> CerealShelfLife = new List<string> { "6 months", "6 months", "6 months", "6 months" };
                List<bool> CerealsSale = new List<bool> { true, false, false, true };
                List<double> CerealsPriceAfterSale = new List<double> { 8.70, 11.90, 8.50, 6.10 };
                Console.WriteLine("Product name \t price \t  shelf life \t sale \t price after sale");
                for (int i = 0; i < CerealsList.Count; i++)
                {
                    Product = CerealsList[i];
                    Price = CerealsPrices[i];
                    ShelfLife = CerealShelfLife[i];
                    Sale = CerealsSale[i];
                    PriceAfterSale = CerealsPriceAfterSale[i];
                    Console.WriteLine($"{CerealsList[i]} |\t {CerealsPrices[i]} |\t  {CerealShelfLife[i]} |\t {CerealsSale[i]} |\t {CerealsPriceAfterSale[i]}");
                }
            }
            void DairyProducts()
            {
                List<string> DairyProductsList = new List<string> { "milk", "yogurt", "cream", "sour cream", "butter" };
                List<double> DairyProductsPrices = new List<double> { 15.30, 11.90, 8.50, 9.20 };
                List<string> DairyProductsShelfLife = new List<string> { "6 months", "6 months", "6 months", "6 months" };
                List<bool> DairyProductsSale = new List<bool> { true, false, false, true };
                List<double> DairyProductsPriceAfterSale = new List<double> { 8.70, 11.90, 8.50, 6.10 };
                Console.WriteLine("Product name \t price \t  shelf life \t sale \t price after sale");
                for (int i = 0; i < DairyProductsList.Count; i++)
                {
                    Product = DairyProductsList[i];
                    Price = DairyProductsPrices[i];
                    ShelfLife = DairyProductsShelfLife[i];
                    Sale = DairyProductsSale[i];
                    PriceAfterSale = DairyProductsPriceAfterSale[i];
                    Console.WriteLine($"{DairyProductsList[i]} |\t {DairyProductsPrices[i]} |\t  {DairyProductsShelfLife[i]} |\t {DairyProductsSale[i]} |\t {DairyProductsPriceAfterSale[i]}");
                }
            }  
            public void SuperMarketMenu()
            {
                Console.WriteLine("there is some products that might be in your wishes.");
                Console.WriteLine("press 1 to see Crisps board.");
                Console.WriteLine("press 2 to see Cereals board.");
                Console.WriteLine("press 3 to see Dairy products board.");
                int choice = Convert.ToInt32( Console.ReadLine());
                if(choice == 1)
                {
                    Console.Clear();
                    Crisps();
                    double balance = Balance();
                    Console.WriteLine("Your balance is: " + balance);
                    Console.WriteLine($"If you want to buy this product you must pay {Price} dollars.");
                    Console.WriteLine("If you agree this purchase press 'y'.");
                    Console.WriteLine("If you do't agree press 'n'");
                    char agreement = Convert.ToChar(Console.ReadLine()!);
                    if (agreement == 'y')
                    {
                        if (balance >= Price)
                        {
                            double balanceAfter = balance - Price;
                            Console.WriteLine($"Congratulations you bought {Product}.");
                            Console.WriteLine($"Your balance now is: {balanceAfter}$");
                            File.AppendAllText(USERS_MONEY_FILE_PATH, $"you bought {Product} for:${Price} - at {DateTime.Now}" + Environment.NewLine);
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
                            SuperMarketMenu();
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
                    Cereals();
                    double balance = Balance();
                    Console.WriteLine("Your balance is: " + balance);
                    Console.WriteLine($"If you want to buy this product you must pay {Price} dollars.");
                    Console.WriteLine("If you agree this purchase press 'y'.");
                    Console.WriteLine("If you do't agree press 'n'");
                    char agreement = Convert.ToChar(Console.ReadLine()!);
                    if (agreement == 'y')
                    {
                        if (balance >= Price)
                        {
                            double balanceAfter = balance - Price;
                            Console.WriteLine($"Congratulations you bought {Product}.");
                            Console.WriteLine($"Your balance now is: {balanceAfter}$");
                            File.AppendAllText(USERS_MONEY_FILE_PATH, $"you bought {Product} for:${Price} - at {DateTime.Now}" + Environment.NewLine);
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
                            SuperMarketMenu();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input.");
                    }
                }
                else if(choice == 3)
                {
                    Console.Clear();
                    DairyProducts();
                    double balance = Balance();
                    Console.WriteLine("Your balance is: " + balance);
                    Console.WriteLine($"If you want to buy this product you must pay {Price} dollars.");
                    Console.WriteLine("If you agree this purchase press 'y'.");
                    Console.WriteLine("If you do't agree press 'n'");
                    char agreement = Convert.ToChar(Console.ReadLine()!);
                    if (agreement == 'y')
                    {
                        if (balance >= Price)
                        {
                            double balanceAfter = balance - Price;
                            Console.WriteLine($"Congratulations you bought {Product}.");
                            Console.WriteLine($"Your balance now is: {balanceAfter}$");
                            File.AppendAllText(USERS_MONEY_FILE_PATH, $"you bought {Product} for:${Price} - at {DateTime.Now}" + Environment.NewLine);
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
                            SuperMarketMenu();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input.");
                    }
                }
            }
            double Balance()
            {
                string lastLine = "";
                using (StreamReader reader = new StreamReader(USERS_MONEY_FILE_PATH))
                {
                    while (!reader.EndOfStream)
                    {
                        lastLine = reader.ReadLine()!;
                    }
                }
                double Balance = Convert.ToDouble(lastLine);
                return Balance;
            }
    }
}
