using System;
using HouseBuilding;

namespace ConstructionSite
{
    class Program
    {
        static void Main(string[] args)
        {
            House BuildingHouse = new House();
            try
            {
                Team buildersTeam = new Team(5);
                int i = 0;
                while (!BuildingHouse.Constructed)
                {
                    i++;
                    try
                    {
                        Console.WriteLine("Day# {1}{0}{2}", Environment.NewLine, i, buildersTeam.Work(BuildingHouse));
                    }
                    catch (OperationCanceledException) { }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


