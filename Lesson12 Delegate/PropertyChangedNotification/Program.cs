using System;

namespace PropertyChangedNotification
{   
    class Program
    {
        static void Main(string[] args)
        {
            PhisycalObject PhObj = new PhisycalObject();
            PhObj.PropertyChanged += EventReader;
            PhObj.Mass = 3.2;
            PhObj.Type = "Liquid";

            PhisycalObject PhObj2 = new PhisycalObject();
            PhObj2.PropertyChanged += EventReader;
            PhObj2.Mass = 5.75;
            PhObj2.Type = "Solid";
        }

        static void EventReader(object sender, PropertyEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
