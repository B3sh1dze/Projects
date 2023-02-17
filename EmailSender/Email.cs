using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public class Email
    {
        public string? SentMessage { get; set; }
        public string? ReceivedMessage { get; set; }
        public List<Email> EmailInformation { get; set; } = new List<Email>();
        private void DisplayAccessibilityMenu(User currentUser, List<User> Users)
        {
            //Console.Clear();
            Console.WriteLine("1 - Send email.");
            Console.WriteLine("2 - Show sent email.");
            Console.WriteLine("3 - Redact sent email.");
            Console.WriteLine("4 - Remove sent email.");
            Console.WriteLine("5 - Show received email.");
            Console.WriteLine("6 - Exit");
        }
        public void UsersChoiceInAccesibilityMenu(User currentUser, List<User> Users)
        {
            while (true)
            {
                DisplayAccessibilityMenu(currentUser, Users);
                var userChoice = Console.ReadKey().Key;
                Console.WriteLine();
                var addressee = new User();
                if (userChoice == ConsoleKey.D1)
                {
                    SendEmail(currentUser, Users, addressee);
                }
                else if (userChoice == ConsoleKey.D2)
                {
                    ShowSentEmail(currentUser, addressee);
                }
                else if (userChoice == ConsoleKey.D3)
                {
                    RedactSentEmail();
                }
                else if (userChoice == ConsoleKey.D4)
                {
                    RemoveSentEmail();
                }
                else if (userChoice == ConsoleKey.D5)
                {
                    ShowReceivedEmail();
                }
                else if(userChoice == ConsoleKey.D6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                    continue;
                }
            }
        }
        void SendEmail(User currentUser, List<User> Users, User addressee)
        {
            Console.Clear();
            var generatedUser = new UserGenerator();
            Console.WriteLine("Choose adressee's number you want to send message: ");
            for (int i = 0; i < Users.Count; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine(Users[i]);
            }
            var userChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int choice = userChoice - '0';
            addressee = Users[choice - 1];
            
            if (currentUser.Name == addressee.Name)
            {
                Console.WriteLine("You can't send message to yourself.");
            }
            else if (choice > 0 && choice <= Users.Count)
            {
                //send email to the selected user
                Console.WriteLine();
                Console.WriteLine($"Sending email to  {Users[choice - 1].Name} on email {Users[choice - 1].Email}");
                
                Console.WriteLine("Write text you want to send: ");
                var message = Console.ReadLine();
                var newSentMessage = new Email()
                {
                    SentMessage = message,
                };
                var newReceivedMessage = new Email()
                {
                    ReceivedMessage = message,
                };
                currentUser.UserEmail.Add(newSentMessage);
                addressee.UserEmail.Add(newReceivedMessage);
                Console.WriteLine("Email sent successfully.");
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
        }
        void ShowSentEmail(User currentUser, User addressee)
        {
            Console.WriteLine($"Message sent by {currentUser.Name} with email {currentUser.Email}.");
            Console.Write("Message: ");
            currentUser.ShowUserSentMessage();
            Console.WriteLine($"Sent to {addressee.Name} on email {addressee.Email}.");
        }
        void ShowReceivedEmail()
        {

        }
        void RemoveSentEmail()
        {

        }
        void RedactSentEmail()
        {

        }
    }
}
