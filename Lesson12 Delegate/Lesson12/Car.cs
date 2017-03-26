using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    delegate void OnFinish(Car car);
    public class Car
    {
        private int position;
        private string name;

        // todo: make speed random

        internal OnFinish Finish { get; set; }

        public Car(string name)
        {
            this.name = name;           
        }      

        public void OnStart(int position)
        {
            this.position = position;
        }

        public override string ToString()
        {
            return String.Format($"{name} - {position} %");
        }

        public void Move(bool raceEnded)
        {
            if (!raceEnded)
            {
                Randomer rand = new Randomer();
                position += rand.Next(1, 20);
                Console.WriteLine(ToString());
                if (position >= 100)
                {
                    Finish(this);
                }
            }
        }
    }
}
