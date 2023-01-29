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
            return $"First name: {FirstName} {Environment.NewLine} " +
                $"Last name: {LastName} {Environment.NewLine} " +
                $"Username: {UserName} {Environment.NewLine}" +
                $"Email: {UserEmail} {Environment.NewLine}" +
                $"DOF: {DateOfBirth} {Environment.NewLine}" +
                $"DOR: {LogInDate} {Environment.NewLine}" +
                $"money: ${MoneyCount}{Environment.NewLine}";
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
