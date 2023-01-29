using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShoppingStore
{
    public class UsersBalance
    {
        public int Balance { get; set; }
        private const string USERS_MONEY_FILE_PATH = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\UserMoneyCount.txt";
        public int BalanceInfo()
        {
            Console.WriteLine("Your balance is: " + Balance);
            return Balance;
        }
        public void ViewUsersBalance()
        {
            string lastLine = "";
            using (StreamReader reader = new StreamReader(USERS_MONEY_FILE_PATH))
            {
                while (!reader.EndOfStream)
                {
                    lastLine = reader.ReadLine()!;
                }
            }
            Console.WriteLine("Your balance is: " + lastLine);
        }

    }
}
