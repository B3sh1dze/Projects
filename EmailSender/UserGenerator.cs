using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public class UserGenerator
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<User> GeneratedUsers()
        {
            var userNames = new List<string>()
            {
                "guro",
                "jimi",
                "gela"
            };
            var userPasswords = new List<string>()
            {
                "guro1234",
                "jimi1234",
                "gela1234"
            };
            var userEmails = new List<string>()
            {
                "guro@gmail.com",
                "jimi@gmail.com",
                "gela@gmail.com"
            };
            
            for (int i = 0; i < userNames.Count; i++)
            {
                var newUser = new User()
                {
                  Name = userNames[i],
                  Email = userEmails[i],
                  Password = userPasswords[i]
                };
                Users.Add(newUser);
            }
            return Users;
        }
    }
}
