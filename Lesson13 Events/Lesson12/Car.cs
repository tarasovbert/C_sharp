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
        private int speed;
        private string name;

        // todo: make speed random

        internal OnFinish Finish { get; set; }

        public Car(string name)
        {
            this.name = name;
            speed = 10;
        }

        public void OnStart(int position)
        {
            this.position = position;
        }

        public override string ToString()
        {
            return String.Format($"{name} - {position} %");
        }

        public void Move()
        {
            position += speed;
            Console.WriteLine(ToString());
            if (position >= 100)
            {
                Race.RaceEnded = true;
                Finish(this);
            }
        }
    }
}
