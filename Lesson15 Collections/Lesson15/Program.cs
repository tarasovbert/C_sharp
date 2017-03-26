using System;

namespace Drunkard
{   
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.SomeEvent += EventReader;
            game.Start(4);
        }

        static void EventReader(string message)
        {
            Console.WriteLine(message);
        }
    }
}
