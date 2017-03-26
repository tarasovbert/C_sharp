using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventChat
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat(4);
            chat.Noticement(1, "Hello there!");
            chat.Noticement(2, "Hi, glad to see you guys!");
            chat.Noticement(3, "Hello!");
            chat.Noticement(4, "Let's talk!");
        }
    }
}
