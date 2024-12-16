using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern_Chat
{
    internal class ChatMediator
    {
        private Dictionary<string, User> _users = new();
        private Dictionary<string, List<string>> _messageHistory = new();

        public void AddUser(User user)
        {
            if (!_users.ContainsKey(user.Name))
            {
                _users[user.Name] = user;
                _messageHistory[user.Name] = new List<string>();
                Console.WriteLine($"Человек {user.Name} присоединился к встречу.");
            }
        }

        public void RemoveUser(string userName)
        {
            if (_users.Remove(userName))
            {
                _messageHistory.Remove(userName);
                Console.WriteLine($"Человек {userName} покинул встречу.");
            }
        }

        public void SendMessage(User sender, string message, string recipientName)
        {
            if (_users.ContainsKey(recipientName))
            {
                _users[recipientName].ReceiveMessage(message, sender.Name);
                _messageHistory[recipientName].Add($"{sender.Name}: {message}");
            }
            else
            {
                Console.WriteLine($"Человек {recipientName} не в зоне действия сети.");
            }

            _messageHistory[sender.Name].Add($"(кому {recipientName}): {message}");
        }

        public void ShowMessageHistory(string userName)
        {
            if (_messageHistory.ContainsKey(userName))
            {
                Console.WriteLine($"История сообщений {userName}а:");
                foreach (var message in _messageHistory[userName])
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine($"Человек {userName} ничего не писал.");
            }
        }
    }
}