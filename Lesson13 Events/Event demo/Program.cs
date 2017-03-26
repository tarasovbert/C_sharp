using System;
using System.Windows;

namespace Event_demo {
    
    class Program {
        
                
        static void Main(string[] args)
        { Eventer eventer = new Eventer();
           
            eventer.SomeEvent += M;//5 Подписать обработчик на событие, т.е., добавить обработчик в список события.
            eventer.Run();
            Console.Read(); }

        static void M(string str){ Console.WriteLine(str); }//4 Создать обработчик события
    } }
