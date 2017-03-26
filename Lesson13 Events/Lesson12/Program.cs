using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW");
            Car car2 = new Car("Ford");
            Race race = new Race();
            race.AddCarInRace(car1);
            race.AddCarInRace(car2);
            race.Start();
        }
    }
}
