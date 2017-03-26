using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson12
{
    delegate void SetPosition(int x);
    delegate void Mover(bool raceEnded);   

    public class Race
    {
        SetPosition delSetPosition;
        Mover mover;
        public bool raceEnded { get; set; } = false;

        public void AddCarInRace(Car car)
        {
            delSetPosition += car.OnStart;
            mover += car.Move;
            car.Finish += ShowWinner;
        }

        public void Start()
        {
            delSetPosition(0);
            while(!raceEnded)
            {
                Thread.Sleep(100);
                mover(raceEnded);
            }
        }

        public void ShowWinner(Car car)
        {
            if(!raceEnded)
            Console.WriteLine("Winner is: {0}.", car);
            raceEnded = true;         
        }
    }
}
