using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_Interface
{
    class Car :ICloneable //: IComparer        
    {

        RadioInfo radio;
        public string Name { get; set; }
        public decimal Price { get; set; }

        public RadioInfo Radio
        {
            get
            {
                return radio;
            }

            set
            {
                radio = value;
            }
        }

        public Car()
        {
            radio = new RadioInfo();
        }

        public object Clone()
        {
            //return this.MemberwiseClone();//shallow copying     
            return new Car() { Price = this.Price, Name = this.Name,
                radio = new RadioInfo() { Type = radio.Type } };     
        }

        //public int CompareTo(object obj)
        //{
        //    Car car = (Car)obj;
        //    return this.Price.CompareTo(car.Price);
        //    throw new NotImplementedException();
        //}

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}.", Name, Price, radio.Type);
        }
    }
}
