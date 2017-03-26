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

        public void EventCatcher(int number, string message)
        {
            if(number != Number)
            Console.WriteLine("User number {0} read the message.", Number);
        }
    }
}
