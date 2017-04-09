using System;
using System.Text;
using Class_Libraries;

namespace Lesson23_Quiz
//namespace Class_Libraries
{
    public class FlightProcess
    {
        private Plane plane;
        private int velocityDelta;
        private int heightDelta;
        private int answerInt;
        private ConsoleKeyInfo keyInfo;
        private int penaltyPoints;
        private int initialDistance;
        private StringBuilder innerMessage = new StringBuilder();

        public FlightProcess(int distance)
        {
            plane = new Plane(distance);
            plane.SomeEvent = EventReciever;
            initialDistance = plane.DistanceLeft;
        }

        public void Launch()
        {
            while (plane.DispatchersQuantity < plane.MinDispatcherQuantity)
                AddDispatcher();
            plane.Height = 0;
            plane.Velocity = 0;
        }

        private void AddDispatcher()
        {
            Console.Write("Enter the name of dispatcher to connect to: ");
            plane.AddDispatcher(Console.ReadLine());
        }

        private void Fly()
        {
            while (true)
            {
                VelocityAndHeight(ref velocityDelta, ref heightDelta);
                plane.Fly(velocityDelta, heightDelta);
                if (plane.DistanceLeft == 0)
                {
                    VelocityAndHeight(ref velocityDelta, ref heightDelta);
                    if (plane.Velocity == 0 && plane.Height == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("You got to the destination.");
                        break;
                    }
                    else plane.Fly(velocityDelta, heightDelta);
                }
            }
            for (int i = 0; i < plane.dispatchers.Count; i++)
            {
                penaltyPoints += plane.dispatchers[i].PenaltyPoints;
            }
            Console.WriteLine("The sum of your penalty points is {0}.", penaltyPoints);
        }

        private void EventReciever(EventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(((MessageEventArgs)args).Message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private void VelocityAndHeight(ref int velocity, ref int height)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}Speed: {1} kph.{0}Height: {2} meters.{0}Distance left: {3} kilometers.{0}",
                Environment.NewLine, plane.Velocity, plane.Height, plane.DistanceLeft);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"Handling velocity.
RightArrow: +50 kmh;
LeftArrow: - 50kmh;
Shift+RighArrow: +150 kmh;
Shift+LeftArrow: -150 kmh;
Escape to not change the velocity.");
            while (true)
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Modifiers.ToString() == "0")
                {
                    if (keyInfo.Key == ConsoleKey.LeftArrow && plane.Velocity >= 50)
                    {
                        plane.Velocity -= 50;
                        Console.WriteLine("Velocity decreases by 50 kmh.");
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        plane.Velocity += 50;
                        Console.WriteLine("Velocity increases by 50 kmh.");
                        break;
                    }
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("Velocity remains the same.");
                        break;
                    }
                }
                else if (keyInfo.Modifiers.ToString() == "Shift")
                    if (keyInfo.Key == ConsoleKey.LeftArrow && plane.Velocity >= 150)
                    {
                        plane.Velocity -= 150;
                        Console.WriteLine("Velocity decreases by 150 kmh.");
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        plane.Velocity += 150;
                        Console.WriteLine("Velocity increases by 150 kmh.");
                        break;
                    }
            }

            if (plane.Velocity > 0 || plane.DistanceLeft != initialDistance)
            {
                Console.WriteLine(@"{0}Handling height;
UpArrow: +250 meters;
DownArrow: -250meters;
Shift+UpArrow: +500 meters;
Shift+DownArrow: -500 meters;
Escape to not change the height.{0}",
                 Environment.NewLine);
                while (true)
                {
                    keyInfo = Console.ReadKey();
                    if (keyInfo.Modifiers.ToString() == "0")
                    {
                        if (keyInfo.Key == ConsoleKey.DownArrow && plane.Height >= 250)
                        {
                            plane.Height -= 250;
                            Console.WriteLine("Height decreases by 250 meters.");
                            break;
                        }
                        else if (keyInfo.Key == ConsoleKey.UpArrow)
                        {
                            plane.Height += 250;
                            Console.WriteLine("Height increases by 250 meters.");
                            break;
                        }
                        if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            Console.WriteLine("Height remains the same.");
                            break;
                        }
                    }
                    else if (keyInfo.Modifiers.ToString() == "Shift")
                        if (keyInfo.Key == ConsoleKey.DownArrow && plane.Height >= 500)
                        {
                            plane.Height -= 500;
                            Console.WriteLine("Height decreases by 500 meters.");
                            break;
                        }
                        else if (keyInfo.Key == ConsoleKey.UpArrow)
                        {
                            plane.Height += 500;
                            Console.WriteLine("Height increases by 500 meters.");
                            break;
                        }
                }
            }
        }

        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Gray;         
            Console.WriteLine
(@"{0}Choose an action:
1. Fly ahead.
2. Add a dispatcher.
3. Remove a dispatcher by name.
4. Remove a dispatcher by number.
5. View dispatchers.
0. Exit.{0}",
                Environment.NewLine);
            while (!Int32.TryParse(Console.ReadLine(), out answerInt) || answerInt < 0 || answerInt > 5) ;
            switch (answerInt)
            {
                case 1: { Fly(); break; }
                case 2: { AddDispatcher(); break; }
                case 3:
                    {
                        Console.WriteLine("Enter a name of dispatcher to remove.");
                        plane.deleteDispatcher(Console.ReadLine());
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter a number of dispatcher to remove.");
                        while (!Int32.TryParse(Console.ReadLine(), out answerInt)) ;
                        plane.deleteDispatcher(answerInt);
                        break;
                    }
                case 5:
                    {
                        for (int i = 0; i < plane.dispatchers.Count; i++)
                            Console.WriteLine("Dispatcher #{0}: {1}.", i + 1, plane.dispatchers[i].Name);
                        break;
                    }
                case 0:
                    {
                        throw new SomethingWrongException("The flight simulator is turning off. Thank you and goodbye!");
                    }
                default:  break;
            }
        }
    }
}
