using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson12
{
    delegate void SetPosition(int x);
    delegate void Mover();

    public class Race
    {
        SetPosition delSetPosition;
        Mover mover;
        public static bool RaceEnded { get; set; }

        public void AddCarInRace(Car car)
        {
            delSetPosition += car.OnStart;
            mover += car.Move;
            car.Finish += ShowWinner;
        }

        public void Start()
        {
            delSetPosition(0);
            while (true)
            {
                mover();
                if (RaceEnded)                    
                    break;                
                Thread.Sleep(500);
            }
        }

        public void ShowWinner(Car car)
        {
            Console.WriteLine("Winner is: {0}.", car);
        }
    }
}
