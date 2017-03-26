using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarTrip
{
    public delegate void EventHandler(object sender, EventArgs args);
    class Program
    {
        static void Main(string[] args)
        {            
            Car car = new Car("Acura", 7.5);
            car.DestinationAchieved += Car_DestinationAchieved;            
            while (car.Serviceable)           
                car.Move(100);            
        }

        private static void Car_DestinationAchieved(object sender, EventArgs args)
        {
            Console.WriteLine(((Car)sender).Name);
            CarEventArgs argsNu = (CarEventArgs)args;
            Console.WriteLine(argsNu.Message);
        }
    }
}
