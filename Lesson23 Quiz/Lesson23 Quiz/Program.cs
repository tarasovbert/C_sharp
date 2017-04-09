using System;

namespace Lesson23_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {                   
            FlightProcess flight = new FlightProcess(500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to the flight simulator.");
            Console.ForegroundColor = ConsoleColor.Gray;
            flight.Launch();
            try { while (true) { flight.Menu(); } }
            catch (Exception ex) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0}{1}{0}", Environment.NewLine, ex.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.ReadKey();
        }
    }
}
