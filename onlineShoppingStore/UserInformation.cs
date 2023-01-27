using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace onlineShoppingStore
{
    public class UserInformation
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? Password { get; set; }
        public int MoneyCount { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime LogInDate { get; set; }
        public override string? ToString()
        {
            return $"{FirstName} - {LastName} - {UserName} - {UserEmail} - DOF{DateOfBirth} - DOR - {LogInDate} - money - ${MoneyCount}";
        }
        public static UserInformation ParseUser(string info)
        {
            var parts = info.Split('-');
            var user = new UserInformation()
            {
                UserEmail = parts[0],
                UserName= parts[1],
                FirstName = parts[2],
                LastName = parts[3],
                DateOfBirth = DateTime.Parse(parts[4]),
                LogInDate = DateTime.Parse(parts[5]),
            };
            return user;
        }
        public static UserInformation checkUser(string information)
        {
            var parts = information.Split('-');
            var user = new UserInformation()
            {
                UserEmail = parts[0]
            };
            return user;
        }
        public static UserInformation CheckPassword(string info)
        {
            var parts = info.Split('-');
            var user = new UserInformation()
            {
                Password = parts[0]
            };
            return user;
        }
        
    }
}
