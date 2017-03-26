using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTrip
{
    class Car
    {
        public event EventHandler DestinationAchieved; //(object sender, EventArgs e);
        public bool Serviceable { get; set; } = true;
        public string Name { get; set; }
        public int DistanceWent { get; set; }
        public double Fuel { get; set; }
        public double OilLevel { get; set; }
        public int EngineTemperature { get; set; }

        public double Consumption { get; set; }

        public Car(string name, double consumption)
        {
            Name = name;
            Consumption = consumption;
            Fuel = 70;
            OilLevel = 4.2;
            EngineTemperature = 25;
        }

        public void Move(int distance)
        {
            int speed = Randomer.Next(25, 250);
            DistanceWent += distance;
            Fuel -= Consumption *(1 +  Math.Abs(speed - 80)/100);
            if (speed > 150)
                OilLevel -= 0.01 * (speed - 150);
            if (EngineTemperature < 85)
                EngineTemperature += 10;
            if (speed > 180)
                EngineTemperature += speed - 180;
            if (speed < 120 && EngineTemperature > 85)
                EngineTemperature -= 5;
                Console.WriteLine("{0} went, total distance {1}.", distance, DistanceWent);
            if (Fuel <= 0 || OilLevel <= 1.5 || EngineTemperature > 100)
                if (DestinationAchieved != null)
                {
                    Serviceable = false;
                    CarEventArgs carEvent = new CarEventArgs();
                    if (Fuel <= 0)
                        carEvent.Message = "Fuel tank is empty!";
                    if (OilLevel <= 1.5)
                        carEvent.Message = "Check engine!";
                    if (EngineTemperature > 100)
                        carEvent.Message = "The engine is overheated!";
                    DestinationAchieved(this, carEvent);
                }            
            }
        }
    }

