using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShoppingStore
{
    public class CarsInformation
    {
        public string? Model { get; set; }
        public string? Engine { get; set; }
        public string? Color { get; set; }
        public int ProduceYears { get; set; }
        public string? Condition { get; set; }
        public string? Description { get; set; }
        public string? Owner { get; set; }
        public int MaxSpeed { get; set; }
        public bool IsCrashed { get; set; }
        public int Price { get; set; }
        public void VolvoCar()
        {
            Model = "Volvo V50";
            Engine = "4-cyl in-line DOHC 1.596 cc";
            Color = "white";
            ProduceYears = 2003;
            Condition = "not very perfect condition";
            Description = "there is some scratch on the driver's door";
            Owner = "Eugine Corbyn";
            MaxSpeed = 220;
            IsCrashed = false;
            Price = 7600;
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"color: {Color}");
            Console.WriteLine($"produce year: {ProduceYears}");
            Console.WriteLine($"Condition: {Condition}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Max Speed: {MaxSpeed}");
            Console.WriteLine($"Is Crashed: {IsCrashed}");
            Console.WriteLine($"Price: {Price}");
        }
        public void RenaultCar()
        {
            Model = "Renault Mégane";
            Engine = "173 hp (129 kW; 175 PS) at 3,750 rpm ";
            Color = "black";
            ProduceYears = 1996;
            Condition = "for this model is perfect condition";
            Description = "there is some crack on the front glass";
            Owner = "Harry Harris";
            MaxSpeed = 200;
            IsCrashed = true;
            Price = 2300;
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"color: {Color}");
            Console.WriteLine($"produce year: {ProduceYears}");
            Console.WriteLine($"Condition: {Condition}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Max Speed: {MaxSpeed}");
            Console.WriteLine($"Is Crashed: {IsCrashed}");
            Console.WriteLine($"Price: {Price}");
        }
        public void BMWCar()
        {
            Model = "BMW X3";
            Engine = "urbocharged 2.0-liter four-cylinder with 248 horsepower and 258 pound-feet of torque (30i)";
            Color = "grey";
            ProduceYears = 2003;
            Condition = "it has the perfect condition. It looks like last year produced.";
            Description = "there is some scratches inside the interior";
            Owner = "Gustavo moore";
            MaxSpeed = 240;
            IsCrashed = true;
            Price = 9350;
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"color: {Color}");
            Console.WriteLine($"produce year: {ProduceYears}");
            Console.WriteLine($"Condition: {Condition}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Max Speed: {MaxSpeed}");
            Console.WriteLine($"Is Crashed: {IsCrashed}");
            Console.WriteLine($"Price: {Price}");
        }
        public void CarsMenu(int carBalance)
        {
            Console.WriteLine("please chose option you want");
            Console.WriteLine("1 for Volvo.");
            Console.WriteLine("2 for Renault.");
            Console.WriteLine("3 for BMW.");
            var num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.Clear();
                VolvoCar();
                Console.WriteLine($"If you want to buy this car you must pay {Price} dollars.");
                Console.WriteLine("If you agree this purchase press 'y'.");
                Console.WriteLine("If you do't agree press 'n'");
                char agreement = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Your balance: " + carBalance);
                if (agreement == 'y')
                {
                    if (carBalance >= Price)
                    {
                        int balanceAfter = carBalance - Price;
                        Console.WriteLine($"Congratulations you bought {Model}.");
                        Console.WriteLine($"Your balance now is: {balanceAfter}$");
                        UsersBalance balance = new UsersBalance()
                        {
                            BalanceAfterCarPurchasing = balanceAfter
                        };
                    }
                    else
                    {
                        Console.WriteLine("We are sorry! you haven't enought balance to make this purchase.");
                    }
                }
                else if(agreement == 'n')
                {
                    Console.WriteLine("Thanks for your opinion.");
                    Console.WriteLine("if you want to return to cars menu press 1");
                    var num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 == 1)
                    {
                        Console.Clear();
                        CarsMenu(carBalance);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
            else if(num == 2) 
            {
                RenaultCar();
                Console.Clear();
                VolvoCar();
                Console.WriteLine($"If you want to buy this car you must pay {Price} dollars.");
                Console.WriteLine("If you agree this purchase press 'y'.");
                Console.WriteLine("If you do't agree press 'n'");
                char agreement = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Your balance: " + carBalance);
                if (agreement == 'y')
                {
                    if (carBalance >= Price)
                    {
                        int balanceAfter = carBalance - Price;
                        Console.WriteLine($"Congratulations you bought {Model}.");
                        Console.WriteLine($"Your balance now is: {balanceAfter}$");
                        UsersBalance balance = new UsersBalance()
                        {
                            BalanceAfterCarPurchasing = balanceAfter
                        };
                    }
                    else
                    {
                        Console.WriteLine("We are sorry! you haven't enought balance to make this purchase.");
                    }
                }
                else if (agreement == 'n')
                {
                    Console.WriteLine("Thanks for your opinion.");
                    Console.WriteLine("if you want to return to cars menu press 1");
                    var num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 == 1)
                    {
                        Console.Clear();
                        CarsMenu(carBalance);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
            else if(num == 3)
            {
                BMWCar();
                Console.Clear();
                VolvoCar();
                Console.WriteLine($"If you want to buy this car you must pay {Price} dollars.");
                Console.WriteLine("If you agree this purchase press 'y'.");
                Console.WriteLine("If you do't agree press 'n'");
                char agreement = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Your balance: " + carBalance);
                if (agreement == 'y')
                {
                    if (carBalance >= Price)
                    {
                        int balanceAfter = carBalance - Price;
                        Console.WriteLine($"Congratulations you bought {Model}.");
                        Console.WriteLine($"Your balance now is: {balanceAfter}$");
                        UsersBalance balance = new UsersBalance()
                        {
                            BalanceAfterCarPurchasing = balanceAfter
                        };
                    }
                    else
                    {
                        Console.WriteLine("We are sorry! you haven't enought balance to make this purchase.");
                    }
                }
                else if (agreement == 'n')
                {
                    Console.WriteLine("Thanks for your opinion.");
                    Console.WriteLine("if you want to return to cars menu press 1");
                    var num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 == 1)
                    {
                        Console.Clear();
                        CarsMenu(carBalance);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
        }
    }
}
