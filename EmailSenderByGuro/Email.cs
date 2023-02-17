using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderByGuro
{
    public class Email
    {
        public string? ReceivedMessage { get; set; }
        public string? SentMessage { get; set; }

        private void DisplayAccessibilityMenu(User currentUser, List<User> Users)
        {
            //Console.Clear();
            Console.WriteLine("1 - Send email.");
            Console.WriteLine("2 - Show received email.");
            Console.WriteLine("3 - Exit");
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
                    ShowReceivedEmail(currentUser);
                }
                else if (userChoice == ConsoleKey.D3)
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
                var sentMessage = new Email()
                {
                    SentMessage = message,
                };
                var receivedMessage = new Email()
                {
                    ReceivedMessage = message,
                };
                currentUser.UserEmail.Add(sentMessage);
                addressee.UserEmail.Add(receivedMessage);
                Console.Clear();
                Console.WriteLine("Email sent successfully.");
                SentEmailActionsBoard(currentUser, addressee, sentMessage);
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
        }
        private void SentEmailActionsBoard(User currentUser, User addressee, Email message)
        {
            while (true)
            {
                Console.WriteLine("1 - Show sent email.");
                Console.WriteLine("2 - Remove sent email.");
                Console.WriteLine("3 - Redact sent email.");
                Console.WriteLine("4 - Exit.");
                var choice = Console.ReadKey().Key;
                Console.WriteLine();
                if (choice == ConsoleKey.D1)
                {
                    ShowSentEmail(currentUser, addressee);
                }
                else if (choice == ConsoleKey.D2)
                {
                    RemoveSentEmail(currentUser, addressee, message);
                }
                else if (choice == ConsoleKey.D3)
                {
                    RedactSentEmail(currentUser, addressee, message);
                }
                else if (choice == ConsoleKey.D4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
        }
        public void ShowSentEmail(User currentUser, User addressee)
        {
            Console.Clear();
            
            foreach (var email in currentUser.UserEmail)
            {
                if(email == null)
                {
                    Console.WriteLine("Sorry no data found.");
                }
                else
                {
                    Console.WriteLine($"Message sent by {currentUser.Name} with email {currentUser.Email}.");
                    Console.Write("Message: ");
                    Console.WriteLine(email);
                    Console.WriteLine($"Sent to {addressee.Name} on email {addressee.Email}.");
                }
            }
        }
        public void RemoveSentEmail(User currentUser, User addressee, Email message)
        {
            Console.Clear();
            currentUser.UserEmail.Remove(message);
            Console.WriteLine($"message: \"{message}\"  will be removed.");
            addressee.UserEmail.Remove(message);
        }
        public void RedactSentEmail(User currentUser, User addressee, Email message)
        {
            Console.WriteLine($"Your sent message: \"{message}\".");
            Console.WriteLine("Please enter new message: ");
            var newMessage = Console.ReadLine();
            var newSentMessage = new Email()
            {
                SentMessage = newMessage,
            };
            var newReceivedMessage = new Email()
            {
                ReceivedMessage = newMessage,
            };
            currentUser.UserEmail.Remove(message);
            currentUser.UserEmail.Add(newSentMessage);
            addressee.UserEmail.Remove(message);
            addressee.UserEmail.Add(newReceivedMessage);
            Console.WriteLine("Message redacted successfully.");
        }
        public void ShowReceivedEmail(User currentUser) 
        {
            Console.WriteLine("If you want to show received message press 1.");
            Console.WriteLine("To show received message on another email press 2.");
            var choice = Console.ReadKey().Key;
            if(choice == ConsoleKey.D1)
            {

            }
        }
    }
}
