using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventChat
{
    public delegate void EventHandler(int number, string message);
    class Chat
    {
        User[] users;
        EventHandler ChatEvent = EventCatcher;
        DateTime now;

        public Chat(int quantity)
        {
            users = new User[quantity];
            for (int i = 0; i < quantity; i++)
            {
                users[i] = new User();
                users[i].Number = i + 1;
                ChatEvent += users[i].EventCatcher;
            }
        }

        public void Noticement(int number, string message)
        {
            if (number < 1 || number > users.Length)
                throw new ArgumentOutOfRangeException("There's no such user!");
            EventOccured(number, message);
        }

        public void EventOccured(int number, string message)
        {
            System.Threading.Thread.Sleep(500);
            now = DateTime.Now;
            ChatEvent?.Invoke(number, String.Format("User number {0} send message: \"{1}\".{2}", number, message, now.ToString("yyyy/MM/dd. HH:mm:ss.ffff")));
        }

        static void EventCatcher(int number, string message)
        {
            Console.WriteLine(message);
        }
    }
}
