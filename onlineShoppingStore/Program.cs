using System;
using static System.Net.Mime.MediaTypeNames;

namespace onlineShoppingStore
{
    class Program
    {
        public static void Main(string[] args)
        {
            User str = new User();
            UserInformation str1= new UserInformation();
            str.LetUserIn(str1.UserName!);
        }
        
    }
}