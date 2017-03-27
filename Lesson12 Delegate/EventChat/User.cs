using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventChat
{
    class User
    {
        public int Number { get; set; }
        DateTime now;

        public void EventCatcher(int number, string message)
        {
            System.Threading.Thread.Sleep(500);
            now = DateTime.Now;
            if(number != Number)
            Console.WriteLine("User number {0} read the message. {1}", Number, now.ToString("yyyy/MM/dd. HH:mm:ss.ffff"));
        }
    }
}
