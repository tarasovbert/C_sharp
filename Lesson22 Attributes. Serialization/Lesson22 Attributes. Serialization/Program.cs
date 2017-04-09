using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_Attributes.Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); 
            // car.ShowInfo();
            car.Get();
            Console.Read();
            Console.WriteLine(GetAboutInfo.GetText(typeof(Car)));
            Console.WriteLine(GetAboutInfo.GetText(typeof(Truck)));
            Console.WriteLine(GetAboutInfo.GetText(typeof(SuperTruck)));
            Console.WriteLine(GetAboutInfo.GetText(typeof(Bus)));
        }
        
        static class GetAboutInfo
        {
            public static string GetText(Type type)
            {
                InfoAboutAttribute obj =  (InfoAboutAttribute)Attribute.GetCustomAttribute(type,
                    typeof(InfoAboutAttribute));
                if (obj == null) return String.Empty;
                else
                {
                    if (obj.IsUpper) return obj.Text.ToUpper();
                    return obj.Text;
                }
            }
        } 

        [InfoAbout("Use new class CarNew.")]        
        class Car
        {
      
            [Obsolete("Not supported.", true)]
            public void ShowInfo()
            {
                Console.WriteLine("Car");
            }
            
            public void Get()
            {
                Console.WriteLine("You've got it!");
            }
        }
        [InfoAboutAttribute("More difficult", IsUpper = true)]
        class Truck {}

        class SuperTruck: Truck { }
        
        class Bus { }

        [InfoAboutAttribute("text")]
        [InfoAboutAttribute("text")]//but why to do like this?
        struct Radio { }

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct,
            AllowMultiple = true, Inherited = true)]
        class InfoAboutAttribute : Attribute
        {
            private string text;

            public string Text
            {
                get { return text; }
                set { text = value; }
            }

            public InfoAboutAttribute(string text)
            {
                this.text = text;
            }
            public bool IsUpper { get; set; }
        }
    }
}







