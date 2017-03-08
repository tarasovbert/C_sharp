using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson10_Inheritance
{
    public class Car
    {
        private double Id;

        Spare sp;
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public Spare S
        {
            get
            {
                return sp;
            }
        }


        public void Do()
        {
            throw new System.NotImplementedException();
        }
    }
}