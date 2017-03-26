using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Program
    {
        delegate bool DelegateIsRange(int lower, int upper, int v);

        static void Main(string[] args)
        {
            // Лямбда-выражения для проверки попадания в интервал
            DelegateIsRange isRange = (Min, Max, N) => N >= Min && N <= Max;
            Console.WriteLine(isRange(10, 50, 25));
            Console.ReadKey();
            Car car1 = new Car("BMW");
            Car car2 = new Car("Ford");
            Race race = new Race();
            race.AddCarInRace(car1);
            race.AddCarInRace(car2);
            race.Start();


        }
    }
}
