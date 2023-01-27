using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShoppingStore
{
    public class UsersBalance
    {
        public int BalanceForCars { get; set; }
        public int  BalanceForBooks { get; set; }
        public int BalanceForSuperMarket { get; set; }
        public int BalanceAfterCarPurchasing { get; set; }
        public int BalanceAfterBookPurchasing { get; set; }
        public int BalanceAfterSuperMarket { get; set; }
        private string USERS_BALANCE_INFORMATION = @"C:\Users\99559\Desktop\onlineShoppingStore\onlineShoppingStore\UserMoneyCount.txt";

        public void SavingUsersBalance()
        {
            UserInformation user = new UserInformation();
            File.AppendAllText(USERS_BALANCE_INFORMATION, $"{user.UserName}'s book balance before purchasing was: {BalanceForBooks} and after: {BalanceAfterBookPurchasing}"); 
        }
    }
}
